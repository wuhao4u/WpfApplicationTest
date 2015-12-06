using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplicationTest
{
    class PublisherClass
    {
		// 1. define a delegate
		// 2. define an event based on the delegate
		// 3. Raise the event

		// Old way
		public delegate void VideoEncodedEventHandler(object source, EventArgs args);
		public event VideoEncodedEventHandler VideoEncoded;

        // this is a delegate (EventHandler is a simplified delegate)
        public event EventHandler myEventHappenedWithNoArgs;
        public event EventHandler<CoolEventArgs> myEventHappened;
        
        public void DoWork()
        {
            Console.WriteLine("doing work in the publisher");
            Thread.Sleep(3000);

			// raise the event
            OnEventHappened(3000);
        }
        protected virtual void OnEventHappened(int time)
        {
            if(myEventHappened != null)
            {
//                myEventHappened(this, EventArgs.Empty);
                myEventHappened(this, new CoolEventArgs { WaitTime = time });
            }
        }
    }
}
