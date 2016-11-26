using DHondtSymTest2.Mathematics;
using DHondtSymTest2.Politics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DHondtSymTest.Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestOszacowanie()
		{
			var t = new Transformation();
			var poll = new OszacowaniePartie<double>
			{
				//Pis = 37.58,
				//Po = 24.09,
				//Razem = 3.62,
				//Korwin = 4.76,
				//Psl = 5.13,
				//Zlew = 7.55,
				//Kukiz15 = 8.81,
				//Nowoczesna = 7.60,
				//Pis = 40,
				//Po = 18,
				//Razem = 1.5,
				//Korwin = 3.5,
				//Psl = 3,
				//Zlew = 3,
				//Kukiz15 = 10,
				//Nowoczesna = 9,
				Pis = 34,
				Po = 19,
				Razem = 2,
				Korwin = 1,
				Psl = 5,
				Zlew = 4,
				Kukiz15 = 8,
				Nowoczesna = 9,
			};
			var electionThreshold = new OszacowaniePartie<double>
			{
				Pis = 8,
				Po = 5,
				Razem = 5,
				Korwin = 5,
				Psl = 5,
				Zlew = 8,
				Kukiz15 = 5,
				Nowoczesna = 5,
			};
			var o = t.Run(poll, electionThreshold);
		}

		public void TestSavingTranformations()
		{
			var t = new Transformation();
		}
	}
}
