using System.Collections.Generic;
using System.Diagnostics;

namespace DHondtSymTest2.Geography
{
	[DebuggerDisplay("{Teryt}: {Nazwa}")]
	public class JednostkaTerytorialna
	{
		public Teryt Teryt { get; set; }
		public string Nazwa { get; set; }
		public JednostkaTerytorialna Nadrzedna { get; set; }
		public List<JednostkaTerytorialna> Podrzedne { get; set; }

		public JednostkaTerytorialna()
		{
			Podrzedne = new List<JednostkaTerytorialna>();
		}
	}
}
