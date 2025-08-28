using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckWeight
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Write your current weight: " );
            double currentweight = double.Parse(Console.ReadLine());

            Console.Write("Write your goal weight: ");
            double goalweight = double.Parse(Console.ReadLine());

            double FinalMark = (currentweight) - (goalweight);
            Console.WriteLine($"Weight to lose {FinalMark}Kgs");

        }
    }
}
