using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magični_pravokotnik
{
    class Program
    {
        static void NapolniPolje(int[,] polje)
        {
            //najprej napolnimo vsako vrstico od 1 - stevilo            
            for (int i = 0; i < polje.GetLength(0); i++)
            {
                int stevilo = 1; //vsako vrstica se začne z 1                

                for (int j = 0; j < polje.GetLength(1); j++)
                {
                    if (stevilo > 9) //ko število preseže 9, ponovno začnemo z nič
                        stevilo = 0;

                    polje[i, j] = stevilo;
                    stevilo++;
                }
            }
            
            //nato oblikujemo magični pravokotnik
            int st_obl = 0; //koliko je drugačnih v trenutni vrsti glede na prejšnjo

            int dodatek = 0;
            
            for (int i = 0; i < polje.GetLength(0); i++)
            {
                dodatek = polje[i,i]; //diagonala
                for (int j = 0; j < st_obl; j++)
                {
                    polje[i, j] = dodatek;
                }
                st_obl++;                
            }
        }

        static void Izris(int[,] polje)
        {
            for (int i = 0; i < polje.GetLength(0); i++)
            {
                for (int j = 0; j < polje.GetLength(1); j++)
                {
                    Console.Write(polje[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int vnos = -1;
            do
            {
                try
                {
                    Console.Write("Vpiši število med 1 in 40: ");
                    vnos = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Napaka.");
                }

                if (vnos >= 1 && vnos <= 40)
                {
                    int[,] p = new int[vnos, vnos]; //velikost polja je vnešeno število na kvadrat
                    NapolniPolje(p);
                    Izris(p);
                }
                else if (vnos == 0)
                    Console.WriteLine("Konec programa.");
                else
                    Console.WriteLine("Vrednost vnosa ni v obsegu parametrov. Zahtevan je ponovni vnos ali vpis 0 za izhod.");
                Console.WriteLine();
            } while ((vnos < 1 || vnos > 40) && vnos != 0);

            Console.ReadKey(true);
        }
    }
}
