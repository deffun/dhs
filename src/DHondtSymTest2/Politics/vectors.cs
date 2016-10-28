using System;
using DHondtSymTest2.Mathematics;

namespace DHondtSymTest2.Politics
{
	public class Sejmiki2014Partie<T> : Vector<T>
		where T : IConvertible
	{
		public const int Size = 7;

		/// <summary>
		/// Prawo i Sprawiedliwość
		/// </summary>
		public T Pis { get { return this[0]; } set { this[0] = value; } }

		/// <summary>
		/// Platforma Obywatelska
		/// </summary>
		public T Po { get { return this[1]; } set { this[1] = value; } }

		/// <summary>
		/// Polskie Stronnictwo Ludowe
		/// </summary>
		public T Psl { get { return this[2]; } set { this[2] = value; } }

		/// <summary>
		/// SLD Lewica Razem
		/// </summary>
		public T SldLr { get { return this[3]; } set { this[3] = value; } }

		/// <summary>
		/// Nowa Prawica - Janusza Korwin-Mikke
		/// </summary>
		public T NpJkm { get { return this[4]; } set { this[4] = value; } }

		/// <summary>
		/// Ruch Narodowy
		/// </summary>
		public T Rn { get { return this[5]; } set { this[5] = value; } }

		/// <summary>
		/// Twój Ruch (Palikota)
		/// </summary>
		public T Tr { get { return this[6]; } set { this[6] = value; } }

		public Sejmiki2014Partie()
		{
			Initialize(Size);
		}
	}

	public class Prezydent2015Kandydaci<T> : Vector<T>
		where T : IConvertible
	{
		public const int Size = 11;

		public T GrzegorzBraun { get { return this[0]; } set { this[0] = value; } }

		/// <summary>
		/// Prawo i Sprawiedliwość
		/// </summary>
		public T AndrzejDuda { get { return this[1]; } set { this[1] = value; } }

		/// <summary>
		/// Polskie Stronnictwo Ludowe
		/// </summary>
		public T AdamJarubas { get { return this[2]; } set { this[2] = value; } }

		/// <summary>
		/// Platforma Obywatelska
		/// </summary>
		public T BronislawKomorowski { get { return this[3]; } set { this[3] = value; } }

		/// <summary>
		/// KORWiN
		/// </summary>
		public T JanuszKorwinMikke { get { return this[4]; } set { this[4] = value; } }

		/// <summary>
		/// Ruch Narodowy
		/// </summary>
		public T MarianKowalski { get { return this[5]; } set { this[5] = value; } }

		public T PawelKukiz { get { return this[6]; } set { this[6] = value; } }

		/// <summary>
		/// Sojusz Lewicy Demokratycznej
		/// </summary>
		public T MagdalenaOgorek { get { return this[7]; } set { this[7] = value; } }

		public T JanuszPalikot { get { return this[8]; } set { this[8] = value; } }

		public T PawelTanajno { get { return this[9]; } set { this[9] = value; } }

		public T JacekWilk { get { return this[10]; } set { this[10] = value; } }

		public Prezydent2015Kandydaci()
		{
			Initialize(Size);
		}
	}

	public class Sejm2015Partie<T> : Vector<T>
		where T : IConvertible
	{
		public const int Size = 8;

		/// <summary>
		/// Prawo i Sprawiedliwość
		/// </summary>
		public T Pis { get { return this[0]; } set { this[0] = value; } }

		/// <summary>
		/// Platforma Obywatelska
		/// </summary>
		public T Po { get { return this[1]; } set { this[1] = value; } }

		/// <summary>
		/// Partia Razem
		/// </summary>
		public T Razem { get { return this[2]; } set { this[2] = value; } }

		/// <summary>
		/// KORWiN
		/// </summary>
		public T Korwin { get { return this[3]; } set { this[3] = value; } }

		/// <summary>
		/// Polskie Stronnictwo Ludowe
		/// </summary>
		public T Psl { get { return this[4]; } set { this[4] = value; } }

		/// <summary>
		/// Zjednoczona Lewica
		/// </summary>
		public T Zlew { get { return this[5]; } set { this[5] = value; } }

		/// <summary>
		/// Kukiz'15
		/// </summary>
		public T Kukiz15 { get { return this[6]; } set { this[6] = value; } }

		/// <summary>
		/// Nowoczesna Ryszarda Petru
		/// </summary>
		public T Nowoczesna { get { return this[7]; } set { this[7] = value; } }

		public Sejm2015Partie()
		{
			Initialize(Size);
		}
	}

	public class OszacowaniePartie<T> : Vector<T>
		where T : IConvertible
	{
		public const int Size = 8;
		//public static Sejm2019Partie Zero = new Sejm2019Partie();

		/// <summary>
		/// Prawo i Sprawiedliwość
		/// </summary>
		public T Pis { get { return this[0]; } set { this[0] = value; } }

		/// <summary>
		/// Platforma Obywatelska
		/// </summary>
		public T Po { get { return this[1]; } set { this[1] = value; } }

		/// <summary>
		/// Partia Razem
		/// </summary>
		public T Razem { get { return this[2]; } set { this[2] = value; } }

		/// <summary>
		/// KORWiN
		/// </summary>
		public T Korwin { get { return this[3]; } set { this[3] = value; } }

		/// <summary>
		/// Polskie Stronnictwo Ludowe
		/// </summary>
		public T Psl { get { return this[4]; } set { this[4] = value; } }

		/// <summary>
		/// Zjednoczona Lewica
		/// </summary>
		public T Zlew { get { return this[5]; } set { this[5] = value; } }

		/// <summary>
		/// Kukiz'15
		/// </summary>
		public T Kukiz15 { get { return this[6]; } set { this[6] = value; } }

		/// <summary>
		/// Nowoczesna Ryszarda Petru
		/// </summary>
		public T Nowoczesna { get { return this[7]; } set { this[7] = value; } }

		public OszacowaniePartie()
		{
			Initialize(Size);
		}
	}

}
