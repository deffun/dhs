using DHondtSymTest2.Mathematics;

namespace DHondtSymTest2.Politics
{
	public interface IElecteeVectorConverter<TSourceVector, TTargetVector>
		where TSourceVector : Vector<int>
		where TTargetVector : Vector<double>, new()
	{
		Matrix<double> Flows { get; }

	}

	public static class ElecteeVectorConverterExtension
	{
		//public static TTargetVector Convert<TSourceVector, TTargetVector>(this IElecteeVectorConverter<TSourceVector, TTargetVector> converter, Vector<int>/*TSourceVector*/ sourceVector)
		//	where TSourceVector : Vector<int>
		//	where TTargetVector : Vector<double>, new()
		//{
		//	return (converter.Flows * sourceVector.ConvertTo<double>())
		//		.ConvertTo<TTargetVector, double>();
		//}

		public static Vector<double> Convert(this IElecteeVectorConverter<Vector<int>, Vector<double>> converter, Vector<int>/*TSourceVector*/ sourceVector)
		{
			return (converter.Flows * sourceVector.ConvertTo<double>());
		}

	}

}
