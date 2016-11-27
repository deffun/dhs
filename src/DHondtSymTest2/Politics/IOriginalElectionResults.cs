using System.Collections.Generic;
using DHondtSymTest2.Geography;
using DHondtSymTest2.Mathematics;

namespace DHondtSymTest2.Politics
{
	public interface IOriginalElectionResults<TElecteeVector>
		where TElecteeVector : Vector<int>
	{
		Dictionary<Teryt, TElecteeVector> Details { get; }
	}
}
