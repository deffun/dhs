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
				Pis = 40,
				Po = 18,
				Razem = 1.5,
				Korwin = 3.5,
				Psl = 3,
				Zlew = 3,
				Kukiz15 = 10,
				Nowoczesna = 9,
			};
			var o = t.Run(poll, .05);
		}

		public void TestSavingTranformations()
		{
			var t = new Transformation();
		}
	}
}
