using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace A01SzklevanMilán
{
    class Program
    {
        static int[] adatok = new int[1000];
        static void Beolvasas()
        {
            StreamReader sr = new StreamReader("adatok.dat");
            string[] atmeneti = sr.ReadLine().Split();
            //int i = 0;
            //while (!sr.EndOfStream)
            //{
            //    adatok[i] = int.Parse(atmeneti[i]);
            //    Console.WriteLine(adatok);
            //}
            int s = 0;
            for (int i = 0; i < adatok.Length; i++)
            {
                adatok[i] = int.Parse(atmeneti[i]);
                Console.WriteLine(adatok[i]);
            }
            sr.Close();
        }

        static void Maximumertek()
        {
            int max = adatok[0];
            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[i] > max)
                {
                    max = adatok[i];
                }
            }
            Console.WriteLine("A maximum: {0}",max);
        }
        static void Egyediek()
        {
            int db = 0;
            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[i] % 5 == 0 && adatok[i] % 7 == 0)
                {
                    db++;
                }
            }
            Console.WriteLine("5 és 7 oszthatóak száma: {0}", db);
        }
        static void Main(string[] args)
        {
           Beolvasas();
           Maximumertek();
            Egyediek();
            Console.ReadKey();
        }
    }
}
