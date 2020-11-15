using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//OPTIMIZACIJA
//algoritem lahko napišemo tudi brez uporabe polj (polja so lahko potratna)
//stevilka, ki jo dobis kot ostanek vrednosti pri deljenju s 10 - tako da lahko tam namestno if uporabis kar a % 10 -> odpade ena spremenjivka in pogoj
//spremenljivke - bolj opisljive (ne samo i, j in vnos)

namespace Magični_pravokotnik
{
    class Program
    {
        static void NapolniPolje(int[,] polje)
        {
            //oblikujemo magični pravokotnik
            for (int vrstica = 0; vrstica < polje.GetLength(0); vrstica++)
            {
                for (int stolpec = 0; stolpec < polje.GetLength(0); stolpec++)
                {
                    if (vrstica > stolpec)
                        polje[vrstica, stolpec] = (vrstica + 1) % 10;
                    else
                        polje[vrstica, stolpec] = (stolpec + 1) % 10;
                }
            }
        }

        static void Izris(int[,] polje)
        {
            NapolniPolje(polje);
            for (int vrstica = 0; vrstica < polje.GetLength(0); vrstica++)
            {
                for (int stolpec = 0; stolpec < polje.GetLength(1); stolpec++)
                {
                    Console.Write(polje[vrstica, stolpec] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int velikostLika = -1;
            do
            {
                try
                {
                    Console.Write("Vpiši velikost med 1 in 40: ");
                    velikostLika = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Napaka.");
                }

                if (velikostLika >= 1 && velikostLika <= 40)
                {
                    int[,] p = new int[velikostLika, velikostLika];
                    Izris(p);
                }
                else if (velikostLika == 0)
                    Console.WriteLine("Konec programa.");
                else
                    Console.WriteLine("Vrednost vnosa ni v obsegu parametrov. Zahtevan je ponovni vnos ali vpis 0 za izhod.");
                Console.WriteLine();
            } while ((velikostLika < 1 || velikostLika > 40) && velikostLika != 0);

            Console.ReadKey(true);
        }
    }
}
