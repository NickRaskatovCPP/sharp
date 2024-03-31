using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpppp
{
    class Program
    {
        static void Main(string[] args)
        {
            float result;
            int x, y;
            int timeInMinuets = 123765542;
            int hour;
            int minute;

            hour = timeInMinuets / 60;
            minute = timeInMinuets % 60;

            Console.WriteLine("hours: " + hour);
            Console.WriteLine("minuets: " + minute);
            Console.ReadKey();
        }
    }
}