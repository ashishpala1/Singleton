using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        { 
            Single s1 = Single.Instance();
            Single s2 = Single.Instance();

            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }
            Console.ReadKey();
        }
    }


    public class Single
    {
        static Single single;

        private Single()
        {
            
        }

        public static Single Instance()
        {
            if(single == null)
            {
                single = new Single();
            }

            return single;
        }
    }
}
