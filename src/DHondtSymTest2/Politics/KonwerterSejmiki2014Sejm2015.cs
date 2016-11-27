using DHondtSymTest2.Mathematics;

namespace DHondtSymTest2.Politics
{
	//public class KonwerterSejmiki2014Sejm2015 : IElecteeVectorConverter<Sejmiki2014Partie<int>, Sejm2015Partie<double>>
	public class KonwerterSejmiki2014Sejm2015 : IElecteeVectorConverter<Vector<int>, Vector<double>>
	{
		private static readonly Matrix<double> FlowsStatic = Matrix<double>.CopyFrom(new[,]
		{	//Pis   Po    Psl   SldLr NpJkm Rn    Tr
			{ 0.90, 0.10, 0.00, 0.00, 0.00, 0.20, 0.00, },	// Pis
			{ 0.00, 0.45, 0.00, 0.00, 0.00, 0.00, 0.00, },	// Po
			{ 0.00, 0.00, 0.00, 0.15, 0.00, 0.00, 0.30, },	// Razem
			{ 0.00, 0.00, 0.00, 0.00, 1.00, 0.00, 0.00, },	// Korwin
			{ 0.00, 0.00, 1.00, 0.00, 0.00, 0.00, 0.00, },	// Psl
			{ 0.00, 0.00, 0.00, 0.85, 0.00, 0.00, 0.70, },	// Zlew
			{ 0.10, 0.30, 0.00, 0.00, 0.00, 0.80, 0.00, },	// Kukiz15
			{ 0.00, 0.15, 0.00, 0.00, 0.00, 0.00, 0.00, },	// Nowoczesna
		});

		public Matrix<double> Flows
		{
			get { return FlowsStatic; }
		}

	}
}
