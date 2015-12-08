using System;

namespace DelegateSample
{
	class MainClass
	{
		/* 2. Declare a delegate, the delegate needs to match the signature of the method
		 * the parameters, the return type
		 */
		public delegate int addNumbersDelegate(int number1, int number2);
		public delegate void stringDelegate(string s);

		delegate void CountIt(int x);
		delegate int CountIt2(int x);

		// 1. We have a method
		public static int addNumbers(int number1, int number2)
		{
			return number1 + number2;
		}


		public static void stringFunction(string str)
		{
			Console.WriteLine (str);
		}

		public static void stringFunction2(string str)
		{
			Console.WriteLine ("another str func: {0}", str);
		}

		public static void Main (string[] args)
		{
			// 3. assign a method to the delegate
			addNumbersDelegate del = new addNumbersDelegate(addNumbers);
			int result = del (123, 456);
			Console.WriteLine (result);

            Console.WriteLine(new String('=', 20));
            Console.WriteLine("4. assign more than one methods to a delegate");
            // 4. assign more than one method to one delegate
            // Old Syntax
            // stringDelegate strDel = new stringDelegate (stringFunction);
            stringDelegate strDel = stringFunction;
            strDel += stringFunction2;

            strDel("Hello World");
            strDel(result.ToString());

            Console.WriteLine(new String('=', 20));
            Console.WriteLine("5. anonymous function with delegate");
            // 5. anonymous function with delegate
            CountIt anonymousDel = delegate(int x)
            {
                for (int i = x; i < x + 5; ++i)
                {
                    Console.WriteLine(i + 1);
                }
            };

            anonymousDel(10);


            Console.WriteLine(new String('=', 20));
            Console.WriteLine("6. Expression Lambda, lambda表达式");
            // 6. expression lambda
            CountIt2 lambdaDel = ((int x) => x + 5);
            int lambdaRes = lambdaDel(5);
            Console.WriteLine(lambdaRes);

            // 7. statement lambda
            Console.WriteLine(new String('=', 20));
            Console.WriteLine("7. Statement Lambda, lambda陈述式");
            CountIt2 sLambdaDel = (int x) =>
            {
                for (int j = 0; j < 5; ++j)
                {
                    Console.WriteLine(j);
                }
                return x + 5;
            };
            int sLambdaRes = sLambdaDel(6);
            Console.WriteLine("statement lambda: " + sLambdaRes);

            Console.WriteLine(new String('=', 20));
            Console.WriteLine("8. cash event demo");
            // 8. cash event demo
            Person person = new Person();
            person.cashEvent += OnCashEventHappened;
            person.cashEvent += () => Console.WriteLine("let's rob him."); ;

            person.AddCash(50);
            person.AddCash(50);

			Console.Read();
		}

		static void OnCashEventHappened(){
			Console.WriteLine ("this guy has 100 dollar!");
		}
	}
}
