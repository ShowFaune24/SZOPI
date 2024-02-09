using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2023._01._09_gyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int fel = 0;
            Console.Write("Adja meg a feladat számát(1- ): ");
            fel = Convert.ToInt32(Console.ReadLine());

            if (fel == 1)
            {
                /*
             Írjunk programot, amely egy adott értelmes szövegről eldönti
             hogy több szóból áll-e!Határozzuk meg az S karaktersorozatban a magánhangzók számát!
             */
                Console.WriteLine("Írjunk programot, amely egy adott értelmes szövegről eldönti, hogy több szóból áll-e!Határozzuk meg az S karaktersorozatban a magánhangzók számát! \n");
                Console.Write("1.) feladat: Kérek egy szöveget: ");
                string sz1 = Console.ReadLine();

                int j1 = 0;
                while (j1 < sz1.Length && sz1[j1] != ' ')
                {
                    j1++;
                }
                bool tsz = j1 < sz1.Length;

                if (tsz)
                {
                    Console.WriteLine("Több szóból áll");
                }
                else
                {
                    Console.WriteLine("Nem áll több szóból");
                }
            }
            else if(fel == 2)
            {
                /*
                 2.) Határozzuk meg az S karaktersorozatban a magánhangzók számát
                 */

                Console.WriteLine("2.) feladat Határozzuk meg az S karaktersorozatban a magánhangzók számát! \n");
                Console.Write("Adja meg az S karakter sorozatot: ");

                string sz1 = Console.ReadLine().ToLower();
                
                //char[] mgh = new char[] { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű' };
                char[] mgh ="aáeéiíoóöőuúüű".ToCharArray();
                int db = 0;
                for (int i = 0; i < sz1.Length; i++) 
                {
                    for(int j = 0; j < mgh.Length; j++)
                    {
                        if (sz1[i] == mgh[j])
                        {
                            db++;
                        }
                    }
                }

                Console.WriteLine($"Magánhangzók száma: {db}");

            }
            else if (fel == 3) 
            {
                /*
                 * Az inputként beolvasott szövegben cserélje ki az összes szóközt a # karakterre
                 * majd az így kapott szöveget írja ki a képernyőre!
                */

                Console.WriteLine("Az inputként beolvasott szövegben cserélje ki az összes szóközt a # karakterre, majd az így kapott szöveget írja ki a képernyőre!\n");

                
                Console.Write("Adja meg a beolvasandó szöveget: ");
                string sz1 = Console.ReadLine();
                                
                                
                string ms = sz1.Replace(' ', '#');
                Console.WriteLine(ms);
            }
            else if (fel == 4)
            {
                /*
                 Határozzuk meg, hogy egy adott névsorban kiknek kezdődik „B” betűvel a neve!
                 */

                List<string> l = new List<string>() { "Anna", "Béla", "Karesz", "Balázs"};
                char test= 'B';
                for (int i = 0;i < l.Count;i++) 
                { 
                    if (l[i][0] == test /*nevek[i].StartsWith("B")*/)
                    {
                        Console.WriteLine($"A {l[i]} név {test} betűvel kezdődik");
                    }
                }


            }
            else if (fel == 5)
            {
                //Állapítsa meg, hogy az input szövegben szerepel-e legalább egy szám!

                Console.WriteLine("Állapítsa meg, hogy az input szövegben szerepel-e legalább egy szám! \n");
                Console.Write("Adja meg az input szöveget: ");
                string sz1 = Console.ReadLine();


                int j = 0;

                while (j < sz1.Length && ((int)sz1[j] >= 48 && (int)sz1[j] <57))
                {
                    j++;
                }
                
                bool sze = j < sz1.Length;
                if (sze)
                {
                    Console.WriteLine($"Szerepel benne!");
                }
                else
                {
                    Console.WriteLine("Nem szerepel benne!");
                }


            }
            else
            {
                Console.WriteLine("Nem létező feladat");
            }




            Console.ReadKey();
            
        }
    }
}
