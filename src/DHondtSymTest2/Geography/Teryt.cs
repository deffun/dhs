using System;

namespace DHondtSymTest2.Geography
{
	public struct Teryt : IComparable, IComparable<Teryt>, IEquatable<Teryt>, IConvertible	// IConvertible przestanie wkrótce być tu używany - nie korzystać z jego członków!
	{
		public readonly RodzajTeryt Rodzaj;
		public readonly decimal Wojewodztwo;
		public readonly decimal Powiat;
		public readonly decimal Gmina;
		public readonly TypGminy TypGminy;

		private Teryt(RodzajTeryt rodzaj, decimal wojewodztwo, decimal powiat, decimal gmina, TypGminy typGminy)
		{
			Rodzaj = rodzaj;
			Wojewodztwo = wojewodztwo;
			Powiat = powiat;
			Gmina = gmina;
			TypGminy = typGminy;
		}

		public Teryt(decimal wojewodztwo)
			: this(RodzajTeryt.Wojewodztwo, wojewodztwo, 0, 0, TypGminy.Brak)
		{ }

		public Teryt(decimal wojewodztwo, decimal powiat)
			: this(RodzajTeryt.Powiat, wojewodztwo, powiat, 0, TypGminy.Brak)
		{ }

		public Teryt(decimal wojewodztwo, decimal powiat, decimal gmina, TypGminy typGminy)
			: this(RodzajTeryt.Gmina, wojewodztwo, powiat, gmina, typGminy)
		{ }

		public Teryt(string teryt)
		{
			Gmina = Powiat = 0;
			TypGminy = TypGminy.Brak;

			var length = teryt.Length;
			if (length != 2 && length != 4 && length != 6 && length != 7)
			{
				throw new IndexOutOfRangeException("Niewłaściwa długość kodu TERYT.");
			}

			try
			{
				Wojewodztwo = decimal.Parse(teryt.Substring(0, 2));
				if (length == 2)
					Rodzaj = RodzajTeryt.Wojewodztwo;
				else
				{
					Powiat = decimal.Parse(teryt.Substring(2, 2));
					if (length == 4)
						Rodzaj = RodzajTeryt.Powiat;
					else
					{
						Gmina = decimal.Parse(teryt.Substring(4, 2));
						Rodzaj = RodzajTeryt.Gmina;
						if (length == 7)
							TypGminy = (TypGminy)Enum.Parse(typeof(TypGminy), teryt);
					}
				}
			}
			catch (Exception exception)
			{
				throw new Exception(string.Format("Błąd podczas parsowania kodu TERYT (\"{0}\").", teryt), exception);
			}
		}

		public override string ToString()
		{
			switch (Rodzaj)
			{
				case RodzajTeryt.Wojewodztwo:
					return string.Format("{0:00}", Wojewodztwo);

				case RodzajTeryt.Powiat:
					return string.Format("{0:00}{1:00}", Wojewodztwo, Powiat);

				case RodzajTeryt.Gmina:
					return TypGminy == TypGminy.Brak
						? string.Format("{0:00}{1:00}{2:00}", Wojewodztwo, Powiat, Gmina)
						: string.Format("{0:00}{1:00}{2:00}{3:0}", Wojewodztwo, Powiat, Gmina, (byte)TypGminy);

				default:
					throw new IndexOutOfRangeException(string.Format("Nieznany rodzaj kodu TERYT ({0}).", Rodzaj));
			}
		}

		public override int GetHashCode()
		{
			return
				Rodzaj.GetHashCode() ^
				Wojewodztwo.GetHashCode() ^
				Powiat.GetHashCode() ^
				Gmina.GetHashCode() ^
				TypGminy.GetHashCode();
		}

		public decimal ToDecimal()
		{
			switch (Rodzaj)
			{
				case RodzajTeryt.Wojewodztwo:
					return Wojewodztwo;

				case RodzajTeryt.Powiat:
					return Wojewodztwo * 100 + Powiat;

				case RodzajTeryt.Gmina:
					return TypGminy == TypGminy.Brak
						? Wojewodztwo * 10000 + Powiat * 100 + Gmina
						: Wojewodztwo * 100000 + Powiat * 1000 + Gmina * 10 + (byte)TypGminy;

				default:
					throw new IndexOutOfRangeException(string.Format("Nieznany rodzaj kodu TERYT ({0}).", Rodzaj));
			}
		}


		public int CompareTo(object teryt)
		{
			return CompareTo((Teryt)teryt);
		}

		public int CompareTo(Teryt teryt)
		{
			if (teryt.Rodzaj != Rodzaj)
			{
				throw new Exception(string.Format("Próba porównania kodów TERYT różnego rodzaju ({0} i {1}).", teryt, this));
			}

			return string.Compare(teryt.ToString(), ToString(), StringComparison.Ordinal);
		}

		public override bool Equals(object teryt)
		{
			return Equals((Teryt)teryt);
		}

		public bool Equals(Teryt teryt)
		{
			//return string.Equals(teryt.ToString(), ToString(), StringComparison.Ordinal);
			return
				teryt.Rodzaj == Rodzaj &&
				teryt.Wojewodztwo == Wojewodztwo &&
				teryt.Powiat == Powiat &&
				teryt.Gmina == Gmina &&
				teryt.TypGminy == TypGminy;
		}

		#region Implementacja interfejsu IConvertible, do czasu zaprzestania jego używania (nie używać tych członków!)
		public TypeCode GetTypeCode()
		{
			throw new NotImplementedException();
		}

		public bool ToBoolean(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public char ToChar(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public sbyte ToSByte(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public byte ToByte(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public short ToInt16(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public ushort ToUInt16(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public int ToInt32(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public uint ToUInt32(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public long ToInt64(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public ulong ToUInt64(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public float ToSingle(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public double ToDouble(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public decimal ToDecimal(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public DateTime ToDateTime(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public string ToString(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public object ToType(Type conversionType, IFormatProvider provider)
		{
			throw new NotImplementedException();
		}
		#endregion

	}
}
