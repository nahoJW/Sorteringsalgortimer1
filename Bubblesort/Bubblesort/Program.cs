using System;
using System.Diagnostics;
using System.Threading;

namespace Bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Random random = new Random(); //skapar en random variabel
            int temp; //plats att temporärt hålla ett tal
            int antalTal = 100000; //antal tal som ska köras
            int[] tal = new int[antalTal]; //array som skapar lika många arrayer som antal tal

            for (int i = 0; i < antalTal; i++) //loop som körs lika många gånger som antal tal
            {
                int randomTal = random.Next(0, antalTal + 1);//sägger att talen som kan randomisas är mellan 0 och mångden tal
                tal[i] = randomTal; // sägger att talet som randomisas sätts in i arrayen
            }

            for (int ii = 0; ii <= tal.Length - 2; ii++)
            {
                for (int i = 0; i <= tal.Length - 2; i++)
                {
                    if (tal[i] > tal[i + 1]) //om talet som testas är större än talet efter så händer något
                    {
                        temp = tal[i + 1]; //andra talet lagas i temp
                        tal[i + 1] = tal[i]; // det andra talet bytts ut till det första 
                        tal[i] = temp;// det första talet får värdet från det andra
                    }
                }
            }

            foreach (int element in tal)
                Console.Write(element + ", ");// skriver ut talen i arrayen
            sw.Stop();
            TimeSpan elapsedTime = sw.Elapsed;
            Console.WriteLine("RunTime " + elapsedTime);

        }
    }
}