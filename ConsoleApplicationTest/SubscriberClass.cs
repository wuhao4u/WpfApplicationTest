using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTest
{
    class SubscriberClass
    {
        public void OnEventHappened(object sender, CoolEventArgs e)
        {
            Console.WriteLine("hello from subs {0}", e.WaitTime);
        }
    }
}
