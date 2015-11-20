using System;

namespace GenericSample
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			var book = new Book{Isbn = }
			var number = new Nullable<int>(5);
			Console.WriteLine (number.HasValue);
			Console.WriteLine (number.GetValueOrDefault());
		}
	}
}
