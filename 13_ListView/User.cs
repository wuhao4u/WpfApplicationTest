using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13_ListView
{
    public class User
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Mail { get; set; }

        public override string ToString()
        {
            return String.Format("{0},{1},{2}", Name, Age, Mail);
        }
    }
}
