﻿using System;
using System.IO;
using System.Linq;
using DHondtSymTest2.Geography;
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

		public OszacowaniePartie<int> Run(OszacowaniePartie<double> poll, OszacowaniePartie<double> electionThreshold = null)
		{
			if (Parts == null || !Parts.Any())
				throw new NullReferenceException("No transformation part is registered.");

			var p = poll / poll.GetSum();
			var eth = electionThreshold / 100;
			if (electionThreshold != null)
				p.ForEach(i => p[i] >= eth[i] ? p[i] : 0);
			p = p / p.GetSum();

			for (var i = 0; i < Parts.Length; i++)
			{
				var etr = Parts[i].GetTotalTranformedResult();
				var pf = Parts[i].GetPollFactor(etr, p);

				foreach (var okreg in Oszacowanie.Okregi.Values)
				{
					var sumaOkregowa = Vector<double>.Create(etr.Length);
					foreach (var jt in okreg.JednostkiTerytorialne)
					{
						var etrx = Parts[i].GetTerytTranformedResult(jt.Teryt);
						var estx = Parts[i].GetElectionWeigthedEstimation(etrx, pf);

						sumaOkregowa += estx;
					}
					okreg.Glosy = sumaOkregowa
						.ConvertTo<OszacowaniePartie<int>, int>();
					Calculate(okreg);
				}

			}

			var suma = OszacowaniePartie<int>.Create<OszacowaniePartie<int>>(OszacowaniePartie<int>.Size);
			suma = Oszacowanie.Okregi.Values
				.Aggregate(suma, (om, o) => OszacowaniePartie<int>.Add<OszacowaniePartie<int>>(om, o.ObliczoneMandaty));
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
