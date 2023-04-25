using Cshrpkontroltoo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Funktsii
{
    public class Funktsii1
    {
        public static void do1task(int[] array1)
        {
            Random rnd = new Random();
            
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(0, 50);
                
            }
            int max = array1[0];
            int min = array1[0];
            for (int i = 0; i <= array1.Length - 1; i++)
            {
                if (array1[i] > max)
                {
                    max = array1[i];
                }
            
                if (array1[i] < min)
                {
                    min = array1[i];
                }
            }
            foreach (int item in array1)
            {
                Console.Write("{0} ",item);
            }

            Console.WriteLine(max);
            Console.WriteLine(min);
            int result = max - min;
            Console.WriteLine("{0} - {1} = {2}",max,min,result);
        }
        public static void do2task(int[] array1)
        {
            int rightcounter = 0;
            Random rnd = new Random();
            Console.Write("Array is: ");
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(0, 250);
            }
            foreach (int item in array1)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine(" ");
            for (int i = 0; i < array1.Length; i++)
            {
                rightcounter = 0;
                for (int j = 0; j < array1.Length; j++)
                {
                    if (0 < array1[i] && array1[i] < 125)
                    {
                        rightcounter += 1;
                    }
                }
                Console.WriteLine("if M[i] = {0}, in (0 < M[i] < 125) {1} numbers", array1[i],rightcounter);
                
            }  
        }
        public static void do3task()
        {
            Random rnd = new Random();
            Console.WriteLine("How many children play?");
            try
            {
                int ustalja = 0;
                List<int> LapsedList = new List<int>();
                List<int> LapsedList2 = LapsedList.ToList();
                int howmany = int.Parse(Console.ReadLine());
                Console.Write("Childrens: ");
                for (int i = 0; i < howmany; i++)
                {
                    LapsedList.Add(i);
                }
                foreach (int item in LapsedList)
                {
                    Console.Write("{0} ", item);
                }
                int step = rnd.Next(1, 5);
                Console.WriteLine("step: {0}", step);
                int lengthlapsed = LapsedList.Count;
                int lengthlapsed2 = 0;


                while (lengthlapsed>1)
                {
                    lengthlapsed -= 1;
                    lengthlapsed2 = lengthlapsed;
                    for (int i = 0; i < lengthlapsed+1; i++)
                    {
                        LapsedList[i] = i;
                    }
                    LapsedList2= LapsedList ;
                    
                    while (step>lengthlapsed2)
                    {
                        LapsedList2 = LapsedList.Concat(LapsedList2).ToList();
                        
                        lengthlapsed2 += lengthlapsed;
                    }
             
                    ustalja = LapsedList2[step-1];
                    LapsedList.RemoveAt(ustalja);
                    Console.WriteLine(" i deleate {0}", ustalja);
                    step += (step-1);
                    
                }
                foreach (int item in LapsedList)
                {
                    Console.WriteLine("last is "+item);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Viga!");
            }
        }
        public static void domytask(List<Parni> esimine)
        {
            Random rnd = new Random();
            Parni inimene1 = new Parni();
            inimene1.Nimi = "Mati";
            inimene1.Perenimi = "Andreev";
            inimene1.Vanus = rnd.Next(0, 93);
            Parni inimene2 = new Parni();
            inimene2.Nimi = "Andrey";
            inimene2.Perenimi = "Ivanov";
            inimene2.Vanus = rnd.Next(0, 93);
            Parni inimene3 = new Parni();
            inimene3.Nimi = "Garik";
            inimene3.Perenimi = "Georgjev";
            inimene3.Vanus = rnd.Next(0, 93);
            Parni inimene4 = new Parni();
            inimene4.Nimi = "Dilan";
            inimene4.Perenimi = "Ignatjev";
            inimene4.Vanus = rnd.Next(0, 93);
            Parni inimene5 = new Parni();
            inimene5.Nimi = "Maksim";
            inimene5.Perenimi = "Voronov";
            inimene5.Vanus = rnd.Next(0, 93);
            esimine.Add(inimene1);
            esimine.Add(inimene2);
            esimine.Add(inimene3);
            esimine.Add(inimene4);
            esimine.Add(inimene5);
            foreach (Parni item in esimine)
            {
                Console.WriteLine(item.Nimi+" "+item.Perenimi+" "+item.Vanus);
            }
            Console.WriteLine("Now only even age");
            foreach (Parni item in esimine)
            {
                if (item.Vanus%2==0)
                {
                    Console.WriteLine(item.Nimi + " " + item.Perenimi + " " + item.Vanus);
                }
            }
        }
        public static void domaksimtask(List<string> esimine)
        {
            foreach (string item in esimine)
            {
                Console.WriteLine(item);
            }
        }
    }
}
