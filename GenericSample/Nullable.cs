using System;

namespace GenericSample
{
	// T must be a value type
	public class Nullable<T> where T : struct
	{
		private object _value;

		public Nullable (T value)
		{
			_value = value;
		}


		public bool HasValue()
		{
			return _value != null;
		}

		public T GetValueOrDefault()
		{
			if (HasValue)
				return (T)_value;

			return default(T);
		}
	}
}

