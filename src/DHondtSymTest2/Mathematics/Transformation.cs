using System;
using System.IO;
using System.Linq;
using DHondtSymTest2.Politics;
//using Shishaq.Serialization;

namespace DHondtSymTest2.Mathematics
{
	public class Transformation// : ISerializable
	{
		public const string DataFormatName = "DHST";
		public const int DataFormatVersion = 1;

		public TransformationPart[] Parts;

		public Transformation()
		{
			Parts = TransformationPartRegistry.GetParts();
		}

		//public void Serialize(Stream outputStream)
		//{
		//	using (var serializer = new BinarySerializer(outputStream, DataFormatName, DataFormatVersion))
		//	{
		//		Serialize(serializer, "Transformation");
		//	}
		//}

		//public void Deserialize(Stream inputStream)
		//{
		//	using (var deserializer = new BinaryDeserializer(inputStream, DataFormatName, DataFormatVersion))
		//	{
		//		Deserialize(deserializer, "Transformation");
		//	}
		//}

		//public void Serialize(ISerializer serializer, string key)
		//{
		//	serializer.SerializeClassCollection(Parts, "Parts");
		//}

		//public void Deserialize(IDeserializer deserializer, string key)
		//{
		//	Parts = deserializer.DeserializeClassCollection<TransformationPart>("Parts");
		//}

		public OszacowaniePartie<int> Run(OszacowaniePartie<double> poll, double electionThreshold = 0)
		{
			if (Parts == null || !Parts.Any())
				throw new NullReferenceException("No transformation part is registered.");

			var p = poll / poll.GetSum();
			p.ForEach(i => p[i] >= electionThreshold ? p[i] : 0);
			p = p / p.GetSum();

			var pollFactors = new Vector<double>[Parts.Length];
			for (var i = 0; i < Parts.Length; i++)
			{
				var et = Parts[i].GetTotalElectionTransformation();
				pollFactors[i] = Parts[i].GetPollFactor(et, p);
			}
			var length = pollFactors.First().Length;
			foreach (var okreg in Oszacowanie.Okregi.Values)
			{
				var sumaOkregowa = Vector<double>.Create(length);
				foreach (var jt in okreg.JednostkiTerytorialne)
				{
					for (var i = 0; i < Parts.Length; i++)
					{
						var et = Parts[i].GetTerytElectionTransformation(jt.Teryt);
						var weightedEstimation = Parts[i].GetElectionWeigthedEstimation(et, pollFactors[i]);
						sumaOkregowa += weightedEstimation;
					}
					
				}
				okreg.Glosy = sumaOkregowa
					.ConvertTo<OszacowaniePartie<int>, int>();
				Calculate(okreg);
			}

			var suma = OszacowaniePartie<int>.Create<OszacowaniePartie<int>>(length);
			suma = Oszacowanie.Okregi.Values.Aggregate(suma, (om, o) => OszacowaniePartie<int>.Add<OszacowaniePartie<int>>(om, o.ObliczoneMandaty));
			return suma;
		}

		public static void Calculate(OkregOszacowania okreg)
		{
			try
			{
				var tablica = new float?[okreg.Glosy.Length, okreg.OgolnieMandaty];
				var ilorazy = new float[okreg.Glosy.Length * okreg.OgolnieMandaty];
				var i = 0;
				for (var p = 0; p < okreg.Glosy.Length; p++)
				{
					var glosy = okreg.Glosy[p];
					var g = (float)glosy;
					if (g <= 0)
						continue;

					for (var m = 1; m <= okreg.OgolnieMandaty; m++)
					{
						var iloraz = g / m;
						ilorazy[i++] = iloraz;
						tablica[p, m - 1] = iloraz;
					}
				}
				var uporzadkowane = ilorazy.OrderByDescending(x => x).ToArray();
				var graniczna = uporzadkowane[okreg.OgolnieMandaty - 1];

				for (var p = 0; p < okreg.Glosy.Length; p++)
				{
					for (var m = 1; m <= okreg.OgolnieMandaty; m++)
					{
						var t = tablica[p, m - 1];
						if (t == null)
						{
							okreg.ObliczoneMandaty[p] = 0;
							break;
						}

						if (t.Value < graniczna)
						{
							okreg.ObliczoneMandaty[p] = m - 1;
							break;
						}
					}
				}

			}
			catch (Exception exception)
			{
				throw;
			}

		}

	}
}
