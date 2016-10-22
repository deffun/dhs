using System;
using System.Linq;
using Shishaq.Serialization;

namespace DHondtSymTest2.Mathematics
{
	public class Vector<T> : IEquatable<Vector<T>>, ISerializable
		where T : IConvertible
	{
		private T[] _data;
		//public TOperationProvider OperationProvider;

		public void Initialize(int length)
		{
			_data = new T[length];
		}

		public void Serialize(ISerializer serializer, string key)
		{
			serializer.SerializePrimitiveCollection(_data, "Data");
		}

		public void Deserialize(IDeserializer deserializer, string key)
		{
			_data = deserializer.DeserializePrimitiveCollection<T>("Data");
		}

		public override int GetHashCode()
		{
			var result = 0;
			for (var i = 0; i < _data.Length; i++)
				result ^= _data[i].GetHashCode() ^ i.GetHashCode();
			return result;
		}

		public override bool Equals(object v)
		{
			return Equals((Vector<T>)v);
		}

		public bool Equals(Vector<T> v)
		{
			for (var i = 0; i < _data.Length; i++)
				if (v._data[i].Equals(_data[i]))
					return false;
			return true;
		}

		public T this[int index]
		{
			get { return _data[index]; }
			set { _data[index] = value; }
		}

		public int Length
		{
			get { return _data.Length; }
		}

		public T GetSum()
		{
			var op = OperationProviderRegistry.Get<T>();
			return _data.Aggregate(op.Zero, op.Add);
		}

		private static void ValidateLengths(Vector<T> v0, Vector<T> v1)
		{
			if (v0.Length != v1.Length)
				throw new Exception("Nierówne długości.");
		}

		//public Vector<T> Ujemny<Vector<T>>()
		//	where Vector<T> : Vector<T>, new()
		//{
		//	return Generate(_data.Length, i => OperationProvider.Ujemny(_data[i]));
		//}

		public static TResult Add<TResult>(Vector<T> v0, Vector<T> v1)
			where TResult : Vector<T>, new()
		{
			ValidateLengths(v0, v1);

			return Generate(Create<TResult>(v0.Length), i => OperationProviderRegistry.Get<T>().Add(v0[i], v1[i]));
		}
		public void Add(Vector<T> v)
		{
			ForEach(i => OperationProviderRegistry.Get<T>().Add(this[i], v[i]));
		}
		public static Vector<T> operator +(Vector<T> v0, Vector<T> v1)
		{
			return Add<Vector<T>>(v0, v1);
		}

		//public Vector<T> Odejmij<Vector<T>>(Vector<T> w)
		//{
		//	var dlugosc = _data.Length;
		//	if (dlugosc != w._data.Length)
		//		throw new Exception("Nierówne długości.");

		//	return Generate(dlugosc, i => OperationProvider.Dodaj(_data[i], OperationProvider.Ujemny(w._data[i])));
		//}

		public static TResult Mul<TResult>(double d, Vector<T> v)
			where TResult : Vector<T>, new()
		{
			return Generate(Create<TResult>(v.Length), i => OperationProviderRegistry.Get<T>().MulD(d, v[i]));
		}
		public static Vector<T> operator *(double d, Vector<T> v)
		{
			return Mul<Vector<T>>(d, v);
		}

		public static TResult Mul<TResult>(Vector<T> v, double d)
			where TResult : Vector<T>, new()
		{
			return Mul<TResult>(d, v);
		}
		public static Vector<T> operator *(Vector<T> v, double d)
		{
			return Mul<Vector<T>>(v, d);
		}

		public static TResult Div<TResult>(Vector<T> v, double d)
			where TResult : Vector<T>, new()
		{
			return Mul<TResult>(1 / d, v);
		}
		public static Vector<T> operator /(Vector<T> v, double d)
		{
			return Div<Vector<T>>(v, d);
		}

		public static TResult Mul<TResult>(Vector<T> v0, Vector<T> v1)
			where TResult : Vector<T>, new()
		{
			ValidateLengths(v0, v1);

			return Generate(Create<TResult>(v0.Length), i => OperationProviderRegistry.Get<T>().Mul(v0[i], v1[i]));
		}
		public static Vector<T> operator *(Vector<T> v0, Vector<T> v1)
		{
			return Mul<Vector<T>>(v0, v1);
		}

		public static TResult Div<TResult>(Vector<T> v0, Vector<T> v1)
			where TResult : Vector<T>, new()
		{
			ValidateLengths(v0, v1);

			return Generate(Create<TResult>(v0.Length), i => OperationProviderRegistry.Get<T>().Div(v0[i], v1[i]));
		}
		public static Vector<T> operator /(Vector<T> v0, Vector<T> v1)
		{
			return Div<Vector<T>>(v0, v1);
		}

		//public Vector<T> Pomnoz<Vector<T>>(Vector<T> w)
		//{
		//	var dlugosc = _data.Length;
		//	if (dlugosc != w._data.Length)
		//		throw new Exception("Nierówne długości.");

		//	return Generate(dlugosc, i => OperationProvider.Pomnoz(_data[i], w._data[i]));
		//}

		//public Vector<T> PodzielPrzez(Vector<T, Vector<T>> w)
		//{
		//	var dlugosc = _dane.Length;
		//	if (dlugosc != w._dane.Length)
		//		throw new Exception("Nierówne długości.");

		//	return Generuj(dlugosc, i => DostawcaOperacji.Podziel(_dane[i], w._dane[i]));
		//}

		public static bool operator ==(Vector<T> v0, Vector<T> v1)
		{
			if ((object)v0 == null && (object)v1 == null)
				return true;
			if ((object)v0 == null || (object)v1 == null)
				return false;
			return v0.Equals(v1);
		}

		public static bool operator !=(Vector<T> w0, Vector<T> w1)
		{
			return !(w0 == w1);
		}

		//public static Vector<T> operator +(Vector<T> w0, Vector<T> w1)
		//{
		//	var w = new Vector<T>(DostawcaOperacji, w0.Dlugosc);
		//	w.Dodaj<>()
		//	return w0.Dodaj<Vector<T>>(w1);
		//}
		//public static Vector<T> operator -(Vector<T> w0, Vector<T> w1)
		//{
		//	return w0.Odejmij<T>(w1);
		//}
		//public static Vector<T> operator -(Vector<T> w)
		//{
		//	return w.Ujemny();
		//}
		//public static Vector<T> operator *(Vector<T> w0, Vector<T> w1)
		//{
		//	return w0.Pomnoz<Vector<T>>(w1);
		//}


		public void ForEach(Func<int, T> func)
		{
			for (var i = 0; i < _data.Length; i++)
			{
				_data[i] = func(i);
			}
		}

		public TResult ConvertTo<TResult, TTarget>()
			where TResult : Vector<TTarget>, new()
			where TTarget : IConvertible
		{
			var c = ConverterRegistry.Get<TTarget, T>();
			if (c == null)
				throw new NullReferenceException(string.Format("Unregistered converter ({0} => {1}).", typeof(T), typeof(TTarget)));

			var result = Create<TResult, TTarget>(Length);
			result.ForEach(i => c.ConvertFrom(this[i]));
			return result;
		}
		public Vector<TTarget> ConvertTo<TTarget>()
			where TTarget : IConvertible
		{
			return ConvertTo<Vector<TTarget>, TTarget>();
		}

		//private static Vector<T> Generate(int length, Func<int, T> func)
		//{
		//	Vector<T> result;
		//	try
		//	{
		//		result = new Vector<T>(OperationProvider, length);
		//	}
		//	catch (Exception exception)
		//	{
		//		return null;
		//	}

		//	if (result._data.Length != length)
		//		throw new Exception("Niezgodna długość generowanego wektora.");

		//	result.ForEach(func);

		//	return result;
		//}

		internal static TResult Create<TResult, TTarget>(int length)
			where TResult : Vector<TTarget>
			where TTarget : IConvertible
		{
			TResult result;
			//try
			//{
				result = Activator.CreateInstance<TResult>();
			//}
			//catch (Exception exception)
			//{
			//	return null;
			//}

			result.Initialize(length);
			return result;
		}
		internal static TResult Create<TResult>(int length)
			where TResult : Vector<T>, new()
		{
			return Create<TResult, T>(length);
		}
		internal static Vector<T> Create(int length)
		{
			return Create<Vector<T>, T>(length);
		}
		//internal static Vector<T> Create(int length)
		//{
		//	try
		//	{
		//		return new Vector<T>(length);
		//	}
		//	catch (Exception exception)
		//	{
		//		return null;
		//	}
		//}
		internal static TResult Generate<TResult>(TResult result, Func<int, T> func)
			where TResult : Vector<T>
		{
			if (result == null)
				return null;

			result.ForEach(func);

			return result;
		}

		//private TResult Generate<TResult>(Func<int, T> func)
		//	where TResult : Vector<T>, new()
		//{
		//	TResult result;
		//	try
		//	{
		//		result = new TResult
		//		{
		//			OperationProvider = OperationProvider,
		//			_data = new T[Length],
		//		};
		//	}
		//	catch (Exception exception)
		//	{
		//		return null;
		//	}

		//	result.ForEach(func);

		//	return result;
		//}

	}

}
