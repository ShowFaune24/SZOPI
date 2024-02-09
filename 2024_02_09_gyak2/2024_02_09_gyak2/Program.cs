using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_09_gyak2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Adja meg a feladat számát: ");
            int fel = Convert.ToInt32(Console.ReadLine());
            
            if(fel == 1)
            {
                //Kérjünk be két szöveget a billentyűzetről és írassuk ki a képernyőre az ABC-ben előbb levőt
                //majd alá az ABC-ben hátrébb levőt!
                Console.WriteLine("Kérjünk be két szöveget a billentyűzetről és írassuk ki a képernyőre az ABC-ben előbb levőt, majd alá az ABC-ben hátrébb levőt! \n");
                Console.Write("Adja meg az első szót: ");
                string sz1 = Console.ReadLine();    
                Console.Write("Adja meg a második szót: ");
                string sz2 = Console.ReadLine();

                int r = string.Compare(sz1, sz2);
                Console.WriteLine();
                if (r < 0)
                {
                    Console.WriteLine($"1.{sz1} \n2.{sz2}");
                }
                else if (r > 0)
                {
                    Console.WriteLine($"1.{sz2} \n2.{sz1}");
                }
                else
                {
                    Console.WriteLine("Ugyanaz a két szó");
                }
            }
            else if(fel == 2)
            {
                //Kérjünk be egy szöveget és egy karaktert, majd írjuk ki
                //hogy a szövegben hányszor fordul elő a megadott karakter!

                Console.WriteLine("Kérjünk be egy szöveget és egy karaktert, majd írjuk ki, hogy a szövegben hányszor fordul elő a megadott karakter! \n");
                Console.Write("Adja meg a szöveget: ");
                char[] ca = 
                string sz1 = Console.ReadLine().ToCharArray ;
                Console.Write("Adja meg a karaktert: ");
                char c1 = Convert.ToChar(Console.ReadLine());

                Console.WriteLine(sz1.C);

                


            }
            else
            {
                Console.WriteLine("Nem létező feladat");
            }


            Console.ReadKey();
        }
    }
}
