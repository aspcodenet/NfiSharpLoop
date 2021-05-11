using System;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;

namespace NfiSharpLoop
{
    class Program
    {


        static void Lab1While()
        {
            //Skapa ett program som skriver ut talen 0-10 på skärmen. Lös detta med en for-loop.
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            //int i = 0;
            //while (true)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //    if (i > 10)
            //        break;
            //}


        }

        static void Lab1()
        {
            //Skapa ett program som skriver ut talen 0-10 på skärmen. Lös detta med en for-loop.
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Lab2()
        {
            Console.WriteLine("Mata in start");
            int start = Convert.ToInt32(Console.ReadLine());

            //slut måste vara större än start
            int slut = 0;
            while (true)
            {
                Console.WriteLine("Mata in slut");
                slut = Convert.ToInt32(Console.ReadLine());
                if (slut > start)
                {
                    break;
                }
                Console.WriteLine($"MNen din dummer - större än {start} tack!");
            }


            //Skapa ett program som skriver ut talen 0-10 på skärmen. Lös detta med en for-loop.
            for (int i = start; i <= slut; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Lab2While()
        {
            Console.WriteLine("Mata in start");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mata in slut");
            int slut = Convert.ToInt32(Console.ReadLine());
            int i = start;
            while (i <= slut)
            {
                Console.WriteLine(i);
                i++;
            }
        }




        static void Main(string[] args)
        {
            for (int i = 1972; i < 2021; i+=10)
            {
                Console.WriteLine(i);
            }



            for (int i = -1123123; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Lab2();
            Lab1();
            Lab1While();
            Lab2While();
        }
    }
}
