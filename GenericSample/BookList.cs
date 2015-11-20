using System;

namespace GenericSample
{
	public class BookList
	{
		public void Add(Book BookList)
		{
			throw new NotImplementedException();
		}

		public Book this[int index]
		{
			get { throw new NotImplementedException ();}
		}

		public BookList ()
		{
		}
	}

	public class GenericDictionary<TKey, TValue>
	{
		public void Add(TKey key, TValue val)
		{
			
		}
	}

	public class GenericList<T>
	{
		public void Add(T value)
		{
			
		}

		public T this[int index]
		{
			get { throw new NotImplementedException ();}
		}
	}
}

