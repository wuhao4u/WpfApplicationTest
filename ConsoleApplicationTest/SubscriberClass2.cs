using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTest
{
    class SubscriberClass2
    {
        public void OnEventHappened(object sender, EventArgs e)
        {
            Console.WriteLine("received from subs 2");
        }
    }
}
