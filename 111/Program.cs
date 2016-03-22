using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _111
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amountofcakesdesired = decimal.Parse(Console.ReadLine());
            decimal kgfloursneeded = decimal.Parse(Console.ReadLine());
            decimal kgflouravailable = decimal.Parse(Console.ReadLine());
            ulong kgtrouffleavailable = ulong.Parse(Console.ReadLine());
            ulong proceof1truffle = ulong.Parse(Console.ReadLine());
            decimal numberofcakescanbemade = (decimal) kgflouravailable / kgfloursneeded;
            if (numberofcakescanbemade >= amountofcakesdesired)
            {
                decimal trufflescost = kgtrouffleavailable * proceof1truffle;
                decimal cakeprice = trufflescost / amountofcakesdesired * 1.25M;
                Console.WriteLine("All products available, price of a cake: {0:F2}", cakeprice);
            }
            else
            {
                decimal kgneeded = amountofcakesdesired * kgfloursneeded - kgflouravailable;
                Console.WriteLine("Can make only {0:F0} cakes, need {1:F2} kg more flour", Math.Floor(kgflouravailable / kgfloursneeded), kgneeded);
            }

        }
    }
}
