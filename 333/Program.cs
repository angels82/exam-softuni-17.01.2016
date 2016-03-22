using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _333
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char dot = '.';
            char sign = '#';
            string row = new string(dot, n) + new string(sign, n) + new string(dot, n);
            Console.WriteLine(row);
            int outerdots = n - 2;
            int innerdots = 0;
            for (int i = 1; i <=n/2;i++)
            {
                row = new string(dot, outerdots) + new string(sign, 2) + new string(dot, innerdots) +
                    new string(sign, 1) + new string(dot, n - 2) + new string(sign, 1) + new string(dot, innerdots) +
                    new string(sign, 2) + new string(dot, outerdots);
                Console.WriteLine(row);
                outerdots -= 2;
                innerdots += 2;
            }
            
            for (int i = 1; i <= n / 2; i++)
                {
                outerdots += 2;
                innerdots -= 2;
                row = new string(dot, outerdots) + new string(sign, 2) + new string(dot, innerdots) +
                    new string(sign, 1) + new string(dot, n - 2) + new string(sign, 1) + new string(dot, innerdots) +
                    new string(sign, 2) + new string(dot, outerdots);
                Console.WriteLine(row);
                
            }
            row = new string(dot, n) + new string(sign, n) + new string(dot, n);
            Console.WriteLine(row);
        }
    }
}
