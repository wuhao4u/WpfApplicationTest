using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplicationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            PublisherClass mPub = new PublisherClass();
            SubscriberClass mSub = new SubscriberClass();
            SubscriberClass2 mSub2 = new SubscriberClass2();

            mPub.myEventHappened += mSub.OnEventHappened;
            mPub.myEventHappened += mSub2.OnEventHappened;
            mPub.DoWork();

            Console.Read();
        }
    }
}
