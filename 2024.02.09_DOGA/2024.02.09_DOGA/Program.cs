using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._02._09_DOGA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fel = 0;
            Console.Write("Adja meg a feladatot: ");
            fel = Convert.ToInt32(Console.ReadLine());

            if (fel == 1)
            {
                /*1.feladat: Kérjen be egy szöveget és egy karaktert, majd írja ki, hogy a szövegben hányszor fordul elő a megadott karakter!
                2.feladat: Kérjen be egy szöveget, és írja ki visszafelé! A fordított szöveg csak nagybetűből álljon!
                3.feladat: Kérjen be két szöveget a billentyűzetről és írassa ki a képernyőre az ABC-ben előbb levőt, majd alá az ABC-ben hátrébb levőt!
                4.feladat: Kérjen be egy szöveget és cserélje ki az összes szóközt a ? karakterre, majd az így kapott szöveget írja ki a képernyőre!
                5.feladat: Írjunk programot, amely egy adott értelmes szövegről eldönti, hogy több szóból áll-e!*/

                //1.feladat: Kérjen be egy szöveget és egy karaktert
                //majd írja ki, hogy a szövegben hányszor fordul elő a megadott karakter!

                Console.Write("Adja meg a szöveget: ");
                string sz1 = Console.ReadLine();
                Console.Write("Adja meg a karaktert");
                char c1 = Convert.ToChar(Console.ReadLine());
                int j = 0;
                for (int i = 0;i < sz1.Length; i++)
                {
                    bool b = (i == c1);
                    Console.WriteLine(i);
                    if (b)
                    {
                        j++;
                    }


                }
                Console.WriteLine(j);


            }
            else if (fel == 2)
            {
                //2.feladat: Kérjen be egy szöveget, és írja ki visszafelé! A fordított szöveg csak nagybetűből álljon!

                Console.Write("Adja meg a szöveget: ");
                string sz1 = Console.ReadLine();
                sz1 = sz1.ToUpper();
                
                for (int i = 0; i < sz1.Length; i++)
                {
                    

                    int e = sz1.Length - i;
                    
                    Console.Write(sz1[e-1]);
                }
                

            } else if (fel == 3)
            {
                //3.feladat: Kérjen be két szöveget a billentyűzetről és írassa ki a képernyőre az ABC-ben előbb levőt
                //majd alá az ABC-ben hátrébb levőt!

                Console.Write("Adja meg az első szöveget: ");
                string sz1 = Console.ReadLine();
                Console.Write("Adja meg a második szöveget: ");
                string sz2 = Console.ReadLine();

                int r = sz1.CompareTo(sz2);

                if (r < 0)
                {
                    Console.WriteLine($"1. {sz1}");
                    Console.WriteLine($"2. {sz2}");
                }
                else if (r > 0)
                {
                    Console.WriteLine($"1. {sz2}");
                    Console.WriteLine($"2. {sz1}");
                }
                else
                {
                    Console.WriteLine("Ugyanaz a két szöveg");
                }

            }
            else if (fel == 4)
            {
                //4.feladat: Kérjen be egy szöveget és cserélje ki az összes szóközt a ? karakterre
                //majd az így kapott szöveget írja ki a képernyőre!

                Console.Write("Adja meg a szöveget: ");
                string sz1 = Console.ReadLine();
                string sz2 = sz1.Replace(' ', '?');
                Console.WriteLine();
                Console.WriteLine(sz2);
            }
            else if (fel == 5)
            {
                //5.feladat: Írjunk programot, amely egy adott értelmes szövegről eldönti, hogy több szóból áll-e!*/
                Console.Write("Adja meg a szöveget: ");
                string sz1 = Console.ReadLine();

                bool b = sz1.Contains(' ');
                
                if (b)
                {
                    Console.WriteLine("Több szóból áll");
                }
                else
                {
                    Console.WriteLine("Nem áll több szóból");
                }
                
                
            }

            else
            {
                Console.WriteLine("Nincs ilyen feladat");
            }

            Console.ReadKey();


        }
    }
}
