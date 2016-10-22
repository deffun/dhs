using System;
using System.Collections.Generic;
using System.Linq;

namespace DHondtSymTest2.Mathematics
{
	public class VectorKind
	{
		private readonly int _length;
		private readonly Dictionary<string, int> _fields;

		public string Name { get; set; }

		public VectorKind(IEnumerable<string> keys)
		{
			var i = 0;
			_fields = keys.ToDictionary(p => p, p => i++);
			_length = _fields.Count;
		}

		public Vector<T> CreateVector<T>()
		{
			return new Vector<T>(this);
		}

		public int Length
		{
			get { return _length; }
		}

		public string[] GetFields()
		{
			return _fields.Keys.ToArray();
		}

		//public string this[int index]
		//{
		//	get
		//	{
		//		if (index < 0 || index >= _fields.Length)
		//			throw new IndexOutOfRangeException("Index out of Vector Kind range.");

		//		return _fields[index];
		//	}
		//	set
		//	{
		//		if (index < 0 || index >= _fields.Length)
		//			throw new IndexOutOfRangeException("Index out of Vector Kind range.");

		//		_fields[index] = value;
		//	}
		//}

		internal int GetIndex(string key)
		{
			int index;
			if (!_fields.TryGetValue(key, out index))
				throw new IndexOutOfRangeException("Unknown key.");

			return index;
		}

		public void SetKeys(IEnumerable<string> keys)
		{
			_fields.Clear();
			var i = 0;
			foreach (var key in keys)
			{
				_fields.Add(key, i++);
			}
		}

	}

}
