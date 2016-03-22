using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _222
{
    class Program
    {
        static void Main(string[] args)
        {
            long reservedbeers = int.Parse(Console.ReadLine());
            string shipment = Console.ReadLine();
            string[] shipmentasarray = shipment.Split(' ');
            long numberofbeerssupplied = 0;
            long multiplier = 1;
            long needmorebeers = 0;
           

            while (shipment != "Exam Over")
            {
                if (shipmentasarray[1] == "beers") { multiplier = 1; }
                if (shipmentasarray[1] == "cases") { multiplier = 24; }
                if (shipmentasarray[1] == "sixpacks") { multiplier = 6; }

                numberofbeerssupplied += long.Parse(shipmentasarray[0]) * multiplier;
                shipment = Console.ReadLine();
                shipmentasarray = shipment.Split(' ');

            }
            if (numberofbeerssupplied >= 100) { numberofbeerssupplied = numberofbeerssupplied - numberofbeerssupplied / 100; }
            if (numberofbeerssupplied < reservedbeers)
            {
                needmorebeers = reservedbeers - numberofbeerssupplied;
               
                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", needmorebeers / 24, (needmorebeers % 24) / 6, (needmorebeers % 24) % 6);
            }
            else
            {
                if (numberofbeerssupplied > reservedbeers)
                { 
                needmorebeers = numberofbeerssupplied - reservedbeers;
               
                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", needmorebeers / 24, (needmorebeers % 24) / 6, (needmorebeers % 24) % 6);
                }
                else
                {
                    Console.WriteLine("Cheers! Beer left: 0 cases, 0 sixpacks and 0 beers.");

                }
            }
        }
    }
}
