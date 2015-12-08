using System;

namespace DelegateSample
{
	public class Person
	{
//		private EventHandler MyEventHandler();
		public delegate void MyEventHandler();
		public event MyEventHandler cashEvent;

		private int cash;
		public int Cash{ 
			get{ return cash;} 
			set{ 
				cash = value;
				if (cash >= 100 && cashEvent != null)
				{
					cashEvent();
				}
			}
		}
		public void AddCash(int amount)
		{
			Cash += amount;
		}

		public Person ()
		{
			cash = 0;
		}
	}
}

