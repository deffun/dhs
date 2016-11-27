using DHondtSymTest2.Mathematics;

namespace DHondtSymTest2.Politics
{
	public class KonwerterPrezydent2015Sejm2015 : IElecteeVectorConverter<Vector<int>, Vector<double>>
	{
		private static readonly Matrix<double> FlowsStatic = Matrix<double>.CopyFrom(new[,]
		{	//Braun Duda  Jarub Komor Korwi Kowal Kukiz Ogore Palik Tanaj Wilk
			{ 1.00, 1.00, 0.00, 0.10, 0.00, 0.10, 0.40, 0.00, 0.00, 0.70, 0.60, },	// Pis
			{ 0.00, 0.00, 0.00, 0.60, 0.00, 0.00, 0.10, 0.00, 0.00, 0.00, 0.00, },	// Po
			{ 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.20, 0.00, 0.00, 0.00, },	// Razem
			{ 0.00, 0.00, 0.00, 0.00, 1.00, 0.00, 0.00, 0.00, 0.00, 0.10, 0.10, },	// Korwin
			{ 0.00, 0.00, 1.00, 0.10, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, },	// Psl
			{ 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.10, 0.80, 1.00, 0.00, 0.00, },	// Zlew
			{ 0.00, 0.00, 0.00, 0.00, 0.00, 0.90, 0.40, 0.00, 0.00, 0.20, 0.30, },	// Kukiz15
			{ 0.00, 0.00, 0.00, 0.20, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, },	// Nowoczesna
		});

		public Matrix<double> Flows
		{
			get { return FlowsStatic; }
		}

	}
}
