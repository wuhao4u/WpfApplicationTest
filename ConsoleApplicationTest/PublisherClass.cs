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
//        public event EventHandler myEventHappened;
        public event EventHandler<CoolEventArgs> myEventHappened;
        
        public void DoWork()
        {
            Console.WriteLine("doing work in the publisher");
            Thread.Sleep(3000);
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
