using Funktsii;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Cshrpkontroltoo
{
    public class Cshrpkontroltoo
    {
        public static void Main(string[] args)
        {
            Funktsii1 Funktsii1 = new Funktsii1();
            while (true) 
            {
                Console.WriteLine("Choose task\nPrint 1-U1\nPrint 2-U2\nPrint 3-U3\nPrint 4 - My task\nElse-Break");
                string choosetask=Console.ReadLine();
                if (choosetask=="1")
                {
                    int[] nums = new int[] { 1, 4, 7, 8,15,9,12,1234};
                    Funktsii1.do1task(nums);
                }
                else if (choosetask == "2")
                {
                    int[] M = new int[] { 1, 4, 7, 8, 15, 9 };
                    Funktsii1.do2task(M);
                }
                else if (choosetask == "3")
                {
                    Funktsii1.do3task();
                }
                else if (choosetask == "4")
                {
                    List<Parni> iniminedic = new List<Parni>();
                    Funktsii1.domytask(iniminedic);
                }
                else if (choosetask == "5")
                {
                    List<string> stringlist = new List<string> { "tere", "minu", "niimi", "on", "artur", "ma", "olen", "kolm","aastat","vana" };
                    Funktsii1.domaksimtask(stringlist);
                }
                else
                {
                    break;
                }
            }
            
        }
    }
}