using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw8
{
    class Program
    {
        static void Main(string[] args)
        {
            RangeOfArray test = new RangeOfArray(-7,5);

            test.InitArray();
            //test.ShowArray();

            Console.WriteLine(test[0]);
        }
    }
}
