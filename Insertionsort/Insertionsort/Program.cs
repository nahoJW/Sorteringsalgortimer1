using System;
using System.Diagnostics;
using System.Threading;

namespace Insertionsort
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int antalTal = 10; //antal tal
            int temp;//variabel för att lagra temporärt värde
            int[] array = new int[antalTal]; //lista med antal tal
            Random random = new Random(); //skapar en random variabel

            for (int i = 0; i < antalTal; i++)
            {
                array[i] = random.Next(antalTal * 2);
            }
            for (int ii = 1; ii < antalTal; ii++)
            {
                temp = array[ii]; //talet som  ska gemföras lagras i temp variablen
                int i1 = ii - 1;

                while (i1 >= 0 && array[i1] > temp)//talet gemförs med med tal som är lägre i listan, stannar om den träffar ett mindre tal eller om de tar slut
                {
                    array[i1 + 1] = array[i1];//större tal flyttas till höger
                    i1--; //går till nästa tal åt vänster
                }
                array[i1 + 1] = temp; //talelt som jämförts infogas i på rätt plats
            }

            foreach (int i2 in array)
                Console.WriteLine(i2 + " ");
            sw.Stop();
            TimeSpan elapsedTime = sw.Elapsed;
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}
