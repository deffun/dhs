using System;
using System.Collections.Generic;
//using Shishaq.Serialization;

namespace DHondtSymTest2.Mathematics
{
	public class Matrix<T> : IEquatable<Matrix<T>>//, ISerializable
		where T : IConvertible
	{
		private int _width;
		private int _height;
		private Dictionary<long, T> _data;

		public void Initialize(int width, int height)
		{
			_width = width;
			_height = height;
			_data = new Dictionary<long, T>();
		}
		public void Initialize(T[,] array)
		{
			_width = array.GetLength(0);
			_height = array.GetLength(1);
			_data = new Dictionary<long, T>();

			for (var x = 0; x < _width; x++)
				for (var y = 0; y < _height; y++)
					this[x, y] = array[x, y];
		}
		public static Matrix<T> CopyFrom(T[,] array)
		{
			var result = new Matrix<T>();
			result.Initialize(array);
			return result;
		}

		//public void Serialize(ISerializer serializer, string key)
		//{
		//	serializer.Serialize(_width, "Width");
		//	serializer.Serialize(_height, "Height");
		//	serializer.SerializePrimitiveDictionary(_data, "Data");
		//}

		//public void Deserialize(IDeserializer deserializer, string key)
		//{
		//	_width = deserializer.DeserializeInt32("Width");
		//	_height = deserializer.DeserializeInt32("Height");
		//	_data = deserializer.DeserializePrimitiveDictionary<long, T>("Data");
		//}

		public override int GetHashCode()
		{
			var result = -8404894;
			var i = 0;
			foreach (var pair in _data)
			{
				result ^= (i++).GetHashCode() ^ pair.Key.GetHashCode() ^ pair.Value.GetHashCode();
			}
			return result;
		}

		public override bool Equals(object v)
		{
			return Equals((Matrix<T>)v);
		}

		public bool Equals(Matrix<T> m)
		{
			return _data.Equals(m._data);
		}

		internal T this[long key]
		{
			get
			{
				T temp;
				return _data.TryGetValue(key, out temp) ? temp : default(T);
			}
			set
			{
				if (!value.Equals(default(T)))
					_data[key] = value;
				else if (_data.ContainsKey(key))
					_data.Remove(key);
			}
		}
		public T this[int x, int y]
		{
			get
			{
				Validate(x, y);

				var key = GetKey(x, y);
				T temp;
				return _data.TryGetValue(key, out temp) ? temp : default(T);
			}
			set
			{
				Validate(x, y);

				var key = GetKey(x, y);
				if (!value.Equals(default(T)))
					_data[key] = value;
				else if (_data.ContainsKey(key))
					_data.Remove(key);
			}
		}

		public int Width
		{
			get { return _width; }
		}

		public int Height
		{
			get { return _height; }
		}

		private static void ValidateLengths(Matrix<T> m, Vector<T> v)
		{
			if (m.Height != v.Length)
				throw new IndexOutOfRangeException("Matrix and Vector dimensions do not match.");
		}
		private static void ValidateLengths(Vector<T> v, Matrix<T> m)
		{
			ValidateLengths(m, v);
		}

		private static long GetKey(int x, int y)
		{
			return ((long)y << 0x20) | x;
		}

		private static int GetX(long key)
		{
			return (int)key;
		}

		private static int GetY(long key)
		{
			return (int)(key >> 0x20);
		}

		private void ValidateX(int x)
		{
			if (x < 0)
				throw new IndexOutOfRangeException("Index is below 0.");
			if (x >= _width)
				throw new IndexOutOfRangeException("Index exceeds the width.");
		}

		private void ValidateY(int y)
		{
			if (y < 0)
				throw new IndexOutOfRangeException("Index is below 0.");
			if (y >= _height)
				throw new IndexOutOfRangeException("Index exceeds the height.");
		}

		private void Validate(int x, int y)
		{
			ValidateX(x);
			ValidateY(y);
		}

		public static TResult Mul<TResult>(Matrix<T> m, Vector<T> v)
			where TResult : Vector<T>, new()
		{
			ValidateLengths(m, v);
			var op = OperationProviderRegistry.Get<T>();

			var r = Vector<T>.Create<TResult>(m.Width);
			for (var y = 0; y < m.Height; y++)
			{
				var vy = v[y];
				for (var x = 0; x < m.Width; x++)
				{
					var temp = op.Mul(vy, m[x, y]);
					r[x] = op.Add(r[x], temp);
				}
			}
			return r;
		}

		public static Vector<T> operator *(Matrix<T> m, Vector<T> v)
		{
			return Mul<Vector<T>>(m, v);
		}

		public static TResult Mul<TResult>(Vector<T> v, Matrix<T> m)
			where TResult : Vector<T>, new()
		{
			ValidateLengths(v, m);
			var op = OperationProviderRegistry.Get<T>();

			var r = Vector<T>.Create<TResult>(m.Height);
			for (var x = 0; x < m.Width; x++)
			{
				var vx = v[x];
				for (var y = 0; y < m.Height; y++)
				{
					var temp = op.Mul(vx, m[x, y]);
					r[y] = op.Add(r[y], temp);
				}
			}
			return r;
		}

		public static Vector<T> operator *(Vector<T> v, Matrix<T> m)
		{
			return Mul<Vector<T>>(v, m);
		}

		public void ForEach(Func<int, int, T> func)
		{
			for (var y = 0; y < Height; y++)
			{
				for (var x = 0; x < Width; x++)
				{
					var key = GetKey(x, y);
					_data[key] = func(x, y);
				}
			}
		}
		public void ForEach(Func<long, T> func)
		{
			foreach (var key in _data.Keys)
				_data[key] = func(key);
		}

		public TResult ConvertTo<TResult, TTarget>()
			where TResult : Matrix<TTarget>, new()
			where TTarget : IConvertible
		{
			var c = ConverterRegistry.Get<TTarget, T>();
			if (c == null)
				throw new NullReferenceException(string.Format("Unregistered converter ({0} => {1}).", typeof(T), typeof(TTarget)));

			var result = Create<TResult, TTarget>(Width, Height);
			result.ForEach(i => c.ConvertFrom(this[i]));
			return result;
		}
		public Matrix<TTarget> ConvertTo<TTarget>()
			where TTarget : IConvertible
		{
			return ConvertTo<Matrix<TTarget>, TTarget>();
		}

		internal static TResult Create<TResult, TTarget>(int width, int height)
			where TResult : Matrix<TTarget>
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

			result.Initialize(width, height);
			return result;
		}

	}

}
