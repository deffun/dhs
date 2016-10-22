using System;
using System.Collections.Generic;

namespace DHondtSymTest2.Mathematics
{
	public interface IOperationProvider<T>
	{
		T Zero { get; }
		T Add(T t0, T t1);
		T MulD(double d, T t);
		T Mul(T t0, T t1);
		T Div(T t0, T t1);
	}

	public interface IConverter<out TTarget, in TSource>
	{
		TTarget ConvertFrom(TSource source);
	}

	public class OperationProviderDouble : IOperationProvider<double>, IConverter<int, double>
	{
		private readonly static object Locker = new object();
		private static OperationProviderDouble _instance;

		public static OperationProviderDouble Instance
		{
			get
			{
				if (_instance == null)
					lock (Locker)
						if (_instance == null)
							_instance = new OperationProviderDouble();
				return _instance;
			}
		}

		private OperationProviderDouble()
		{ }

		public double Zero
		{
			get { return 0; }
		}

		public double Add(double t0, double t1)
		{
			return t0 + t1;
		}

		//public double Ujemny(double t)
		//{
		//	return -t;
		//}

		public double MulD(double d, double t)
		{
			return d * t;
		}

		public double Mul(double t0, double t1)
		{
			return t0 * t1;
		}

		public double Div(double t0, double t1)
		{
			return t0 / t1;
		}

		public int ConvertFrom(double source)
		{
			return (int)Math.Round(source);
		}
	}

	public class OperationProviderInt : IOperationProvider<int>, IConverter<double, int>
	{
		private readonly static object Locker = new object();
		private static OperationProviderInt _instance;

		public static OperationProviderInt Instance
		{
			get
			{
				if (_instance == null)
					lock (Locker)
						if (_instance == null)
							_instance = new OperationProviderInt();
				return _instance;
			}
		}

		private OperationProviderInt()
		{ }

		public int Zero
		{
			get { return 0; }
		}

		public int Add(int t0, int t1)
		{
			return t0 + t1;
		}

		public int MulD(double d, int t)
		{
			return (int)Math.Round(d * t);
		}

		public int Mul(int t0, int t1)
		{
			return t0 * t1;
		}

		public int Div(int t0, int t1)
		{
			return t0 / t1;
		}

		public double ConvertFrom(int source)
		{
			return source;
		}
	}

	public static class OperationProviderRegistry
	{
		private readonly static Dictionary<Type, object> Items = new Dictionary<Type, object>();

		static OperationProviderRegistry()
		{
			Register(OperationProviderInt.Instance);
			Register(OperationProviderDouble.Instance);
		}

		public static void Register<T>(IOperationProvider<T> operationProvider)
		{
			Items.Add(typeof(IOperationProvider<T>), operationProvider);
		}

		public static IOperationProvider<T> Get<T>()
		{
			//object temp;
			//OperationProviders.TryGetValue(typeof(T), out temp);
			//return temp as IOperationProvider<T>;
			return Items[typeof(IOperationProvider<T>)] as IOperationProvider<T>;
		}

	}

	public static class ConverterRegistry
	{
		private readonly static Dictionary<Type, object> Items = new Dictionary<Type, object>();

		static ConverterRegistry()
		{
			Register(OperationProviderInt.Instance);
			Register(OperationProviderDouble.Instance);
		}

		public static void Register<TTarget, TSource>(IConverter<TTarget, TSource> converter)
		{
			Items.Add(typeof(IConverter<TTarget, TSource>), converter);
		}

		public static IConverter<TTarget, TSource> Get<TTarget, TSource>()
		{
			//object temp;
			//OperationProviders.TryGetValue(typeof(T), out temp);
			//return temp as IOperationProvider<T>;
			return Items[typeof(IConverter<TTarget, TSource>)] as IConverter<TTarget, TSource>;
		}

	}


}
