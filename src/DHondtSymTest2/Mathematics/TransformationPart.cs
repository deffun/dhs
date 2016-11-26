﻿using System.Collections.Generic;
using System.Linq;
using DHondtSymTest2.Geography;
//using Shishaq.Serialization;

namespace DHondtSymTest2.Mathematics
{
	public class TransformationPart// : ISerializable
	{
		public string Name { get; set; }
		public double Weight { get; set; }
		public Matrix<double> Flows { get; set; }
		public Vector<int> TotalResult { get; set; }
		public Vector<double> TotalRatio { get; set; }
		public Dictionary<Teryt, Vector<int>> TerytResults { get; set; }
		public Dictionary<Teryt, Vector<double>> TerytRatios { get; set; }

		//public void Initialize<TVectorInt>(string name, double weight, IDictionary<Teryt, TVectorInt> electionResults)
		//	where TVectorInt : Vector<int>
		//{
		//	Name = name;
		//	Weight = weight;
		//	TerytRatios = electionResults.ToDictionary(p => p.Key, p => p.Value.ConvertTo<double>());
		//	if (!electionResults.Any())
		//		return;

		//	TotalRatio = Vector<double>.Create(electionResults.First().Value.Length);
		//	foreach (var tr in TerytRatios)
		//	{
		//		TotalRatio += tr.Value;
		//	}
		//}

		//public void Serialize(ISerializer serializer, string key)
		//{
		//	serializer.Serialize(Name, "Name");
		//	serializer.Serialize(Weight, "Weight");
		//	Flows.Serialize(serializer, "Flows");
		//	TotalResults.Serialize(serializer, "TotalResults");
		//	serializer.SerializeClassDictionary(TerytResults, "TerytResults");
		//}

		//public void Deserialize(IDeserializer deserializer, string key)
		//{
		//	Name = deserializer.DeserializeString("Name");
		//	Weight = deserializer.DeserializeDouble("Weight");
		//	Flows.Deserialize(deserializer, "Flows");
		//	TotalResults.Deserialize(deserializer, "TotalResults");
		//	TerytResults = deserializer.DeserializeClassDictionary<Teryt, Vector<double>>("TerytResults");
		//}

		public Vector<double> GetTerytTranformedResult(Teryt teryt)
		{
			var et = Flows * TerytResults[teryt].ConvertTo<double>();
			return et;
		}

		public Vector<double> GetTotalTranformedResult()
		{
			var et = Flows * TotalResult.ConvertTo<double>();
			return et;
		}

		public Vector<double> GetPollFactor(Vector<double> electionTransformationResult, Vector<double> poll)
		{
			var et = electionTransformationResult / electionTransformationResult.GetSum();
			var pf = poll / et;
			return pf;
		}

		public Vector<double> GetElectionWeigthedEstimation(Vector<double> electionTransformationResult, Vector<double> pollFactor)
		{
			var ee = Weight * electionTransformationResult * pollFactor;
			return ee;
		}

	}


}
