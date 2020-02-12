using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Loop
{
    class Program
    {
        static void Main(string[] args)
        {

           
            int br = 50;

            //standardna while petlja
            //while(br < 11)
            //{
            //    Console.WriteLine($"Brojevi koji su manji od 11: {++br}");
            //}

            //do while petlja prvo puca pa pita ko je, uradiće svoj blok operacija bar jednom
            // a zatim će pitati da li je uslov uredu, ako jeste onda će nastaviti dalje
            //do
            //{
            //    Console.WriteLine($"Brojevi koji su manji od 11: {++br}");
            //} while (broj < 10);

            //kada je inkrement sam nije bitan da li je sufiks ili postfiks 
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Prvi broj u nizu od 0 do 10 je {i}");
            //}


            //ista stvar ne radi ako je postfiksni inkrementator dok na sufiksni radi 
            //for (int i = 0; i < 100; i=++i *2)
            //{
            //    Console.WriteLine($"Prvi broj u nizu od 0 do 10 je {i}");
            //}


            //Console.WriteLine("Unesite prvi broj:");
            //int broj = int.Parse(Console.ReadLine());
            //for (int i = 0; i < broj; i++)
            //{
            //    Console.WriteLine($"Prvi broj u nizu od 0 do {broj} je {i}");
            //}


            //while petlja sa uslovom i break, kao i continue
            br = 0;
            while (br < 100)
            {
                br++;
                if (br < 10)
                {
                    //ovo bi vrtelo brojač do 10 a onda išlo dalje
                    continue;
                }
                if (br % 2 <= 0)
                {
                Console.WriteLine($"Parni brojevi do 100 su: {br}");
                }
                if(br == 75)
                {
                    //ovo bi zaustavilo izvršenje na 75
                    Console.WriteLine("STOP NA 75!");
                    break;
                }
            }

            //foreach je petlja uglavnom za rad sa nizovima

            Console.ReadKey();
           
        }
    }
}
