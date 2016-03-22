using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _444
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dailyexpenses = int.Parse(Console.ReadLine());
            decimal totalexpenses = 0;
            string input = Console.ReadLine();
            string[] inputarray = input.Split(' ');
            int hours = int.Parse(inputarray[0]);
            string path = inputarray[1];
            int price = int.Parse(inputarray[2]);
            string newpath = string.Empty;
            int countH = 0;
            decimal moneygained = 0M;
            decimal totalmoney = 0M;
            decimal countdays = 0M;
            decimal avgearningsperday = 0M;

            while (input!= "Season Over")
            {
                countH = 0;
                moneygained = 0;
                hours = int.Parse(inputarray[0]);
                path = inputarray[1];
                price = int.Parse(inputarray[2]);
                countdays++;
                if (hours <= path.Length)
                {
                    for (int i = 0; i< hours;i++)
                    {
                        if (path[i] == 'H') { countH++; }
                        

                    }
                    moneygained += countH * price;
                }
                else
                {
                    while (path.Length<hours)
                    { path += path; }
                    countH = 0;
                    moneygained = 0;
                    for (int i = 0; i < hours; i++)
                    {
                        
                        if (path[i] == 'H') { countH++; }
                        
                    }
                    moneygained += countH * price;
                }

                totalmoney += moneygained;
                avgearningsperday = totalmoney / countdays;


                input = Console.ReadLine();
                inputarray = input.Split(' ');
                totalexpenses += dailyexpenses;
            }
            if (avgearningsperday >= dailyexpenses)
            {
                Console.WriteLine("Times are good. Extra money per day: {0:f2}.", avgearningsperday - dailyexpenses );

            }
            else
            {
                Console.WriteLine("We are in the red. Money needed: {0:f0}.",  totalexpenses - totalmoney);

            }

        }
    }
}
