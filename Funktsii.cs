using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
                        foreach (int item in LapsedList2)
                        {
                            Console.Write(item);
                        }
                        lengthlapsed2 += lengthlapsed;
                    }
                    foreach (int item in LapsedList2)
                    {
                        Console.Write(item);
                    }
                    ustalja = LapsedList2[step-1];
                    LapsedList.RemoveAt(ustalja);
                    Console.WriteLine(" i deleate {0}", ustalja);
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
    }
}
