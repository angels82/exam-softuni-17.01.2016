using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _555
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong initialwall = ulong.Parse(Console.ReadLine());
            
            string initialwallasstring = Convert.ToString((long)initialwall, 2).PadLeft(64, '0');
            uint numberofrepairkits = uint.Parse(Console.ReadLine());
            uint numberofattacks = uint.Parse(Console.ReadLine());
            string newstring = string.Empty;
            for (int k=1; k<=numberofattacks;k++)
            {
                newstring = string.Empty;
                int attackedbit = int.Parse(Console.ReadLine());
                attackedbit = 63 - attackedbit;

                for (int i=0;i<64;i++)
                {
                    if (i==attackedbit)
                    {
                        if (initialwallasstring[i] == '1') { newstring += '0'; }
                        else { newstring += '0'; }
                    }
                    else
                    {
                        newstring += initialwallasstring[i];
                    }
                    
                }
                initialwallasstring = newstring;

            }
            string[] newstring2 = new string[64];
            for (int i=63; i>0;i--)
            {
                if ((newstring[i] == newstring[i-1]) && (newstring[i]=='0') && (numberofrepairkits > 0))
                {
                    newstring2[i] = "1";
                    numberofrepairkits--;
                    if (numberofrepairkits > 0) { newstring2[i-1] = "1"; numberofrepairkits--; i--; }

                    if ((newstring[i] == newstring[i - 1]) && (newstring[i] == '0') && (numberofrepairkits > 0) && (newstring[i] == newstring[i - 2]))
                    {
                        newstring2[i-2] = "1";
                        numberofrepairkits--;
                        



                    }


                }
                else
                {
                    if (newstring[i] == '1') { newstring2[i] = "1"; }
                    else
                    { 
                    newstring2[i] = "0";
                    }
                }
            }
            string newstringlast = string.Empty;
            for (int i = 0; i<64; i++)
            {
                newstringlast += newstring2[i];
            }
            ulong newbitInt = Convert.ToUInt64(newstringlast, 2);
            Console.WriteLine(newbitInt);
        }
    }
}
