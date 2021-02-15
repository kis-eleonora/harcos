using System;

namespace harcos2
{
    class Harcos_Program
    {
        static void harc1()
        {
            int round = 1;
            int j2elet = 70;
            int j1elet = 60;
            int hit1 = 0;
            int hit2 = 0;
            int zero_hit1 = 0;
            int zero_hit2 = 0;
            Random rnd = new Random();

            while (round <= 10 & j1elet > 0 & j2elet > 0)
            {
                Console.WriteLine("---- {0}. kör ----", round);

                Console.WriteLine("Támadás!");
                Console.ReadLine();

                int j1utes = rnd.Next(6, 9);
                hit1 = rnd.Next(1, 101);
                if (hit1 <= 30)
                {
                    j1utes = j1utes * 2;
                }
                else
                {
                    j1utes = j1utes;
                }

                zero_hit1 = rnd.Next(1, 101);
                if (zero_hit1 <= 20)
                {
                    j1utes = 0;
                }
                else
                {
                    j1utes = j1utes;
                }


                Console.WriteLine("{0} pontot sebeztél.", j1utes);
                j2elet = j2elet - j1utes;
                if (j2elet <= 0)
                {
                    Console.WriteLine("Az ellenség elbukott!");
                    break;
                }
                else
                {
                    Console.WriteLine("Az ellenségnek {0} élete maradt.", j2elet);
                }

                int j2utes = rnd.Next(5, 8);
                hit2 = rnd.Next(1, 101);
                if (hit2 <= 30)
                {
                    j2utes = j2utes * 2;
                }
                else
                {
                    j2utes = j2utes;
                }

                zero_hit2 = rnd.Next(1, 101);
                if (zero_hit2 <= 20)
                {
                    j2utes = 0;
                }
                else
                {
                    j2utes = j2utes;
                }

                Console.WriteLine("Az ellenség támad: {0} pontot sebzett.", j2utes);
                j1elet = j1elet - j2utes;
                if (j1elet <= 0)
                {
                    Console.WriteLine("Sajnos elbuktál...");
                    break;
                }
                else
                {
                    Console.WriteLine("{0} életed maradt.", j1elet);
                }
                round++;
            }

            if (j2elet <= 0)
            {
                Console.WriteLine("Éljen! Győzött az igazság!");
            }
            else if (j1elet <= 0)
            {
                Console.WriteLine("Sötétségbe borult a Föld. A gonosz győzedelmeskedett...");
            }
            else
            {
                Console.WriteLine("Nem sikerült halálos sebet ejteni.");
            }

        }

        static void harc2()
        {
            int round = 1;
            int j2elet = 70;
            int j1elet = 60;
            int hit1 = 0;
            int hit2 = 0;
            int zero_hit1 = 0;
            int zero_hit2 = 0;
            Random rnd = new Random();

            while (round <= 10 & j1elet > 0 & j2elet > 0)
            {
                Console.WriteLine("---- {0}. kör ----", round);

                int j2utes = rnd.Next(5, 8);
                hit2 = rnd.Next(1, 101);
                if (hit2 <= 30)
                {
                    j2utes = j2utes * 2;
                }
                else
                {
                    j2utes = j2utes;
                }

                zero_hit2 = rnd.Next(1, 101);
                if (zero_hit2 <= 20)
                {
                    j2utes = 0;
                }
                else
                {
                    j2utes = j2utes;
                }

                Console.WriteLine("Az ellenség támad: {0} pontot sebzett.", j2utes);
                j1elet = j1elet - j2utes;
                if (j1elet <= 0)
                {
                    Console.WriteLine("Sajnos elbuktál...");
                    break;
                }
                else
                {
                    Console.WriteLine("{0} életed maradt.", j1elet);
                }

                Console.WriteLine("Támadás!");
                Console.ReadLine();
                int j1utes = rnd.Next(6, 9);
                hit1 = rnd.Next(1, 101);
                if (hit1 <= 30)
                {
                    j1utes = j1utes * 2;
                }
                else
                {
                    j1utes = j1utes;
                }

                zero_hit1 = rnd.Next(1, 101);
                if (zero_hit1 <= 20)
                {
                    j1utes = 0;
                }
                else
                {
                    j1utes = j1utes;
                }


                Console.WriteLine("{0} pontot sebeztél.", j1utes);
                j2elet = j2elet - j1utes;
                if (j2elet <= 0)
                {
                    Console.WriteLine("Az ellenség elbukott!");
                    break;
                }
                else
                {
                    Console.WriteLine("Az ellenségnek {0} élete maradt.", j2elet);
                }
                round++;

            }

            if (j2elet <= 0)
            {
                Console.WriteLine("Éljen! Győzött az igazság!");
            }
            else if (j1elet <= 0)
            {
                Console.WriteLine("Sötétségbe borult a Föld. A gonosz győzedelmeskedett...");
            }
            else
            {
                Console.WriteLine("Nem sikerült halálos sebet ejteni.");
            }

            
        }

        static void dobas()
        {
            Console.WriteLine("Kezdődjön a játék, lássuk, ki kezdi a támadást!");
            int j1 = 0;
            int j2 = 0;
            Random rnd = new Random();


            while (j1 == j2)
            {
                j1 = rnd.Next(1, 101);
                j2 = rnd.Next(1, 101);
            }
            if (j1 > j2)
            {
                Console.WriteLine("{0} a dobásod, {1} az ellenség dobása. Te kezded a harcot.", j1, j2);
                harc1();
            }
            else if (j2 > j1)
            {
                Console.WriteLine("{0} a dobásod, {1} az ellenség dobása. Az ellenség kezdi a harcot.", j1, j2);
                harc2();
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Győzd le a gonosz ellenséget 10 kör alatt. Az ellenségnek 70 élete van, neked csak 60, de erősebbet is tudsz ütni.");
            Console.WriteLine("Támadáshoz üss 'enter'-t!");
            

            dobas();


            Console.WriteLine("---- Vége a játéknak ----");
            Console.WriteLine("Szeretnél újra játszani? Üss 'i'-t, ha igen, üss 'n'-t, ha nem:");
            string again = Console.ReadLine();

            while (again != "i" & again != "n")
            {
                Console.WriteLine("Adj meg egy érvényes választ! Szeretnél újra játszani? Üss 'i'-t, ha igen, üss 'n'-t, ha nem:");
                again = Console.ReadLine();
            }

                if (again == "n")
                {
                    Console.WriteLine("Köszönöm a játékot! Gyere máskor is!");

                }
                else if (again == "i")
                {
                    dobas();
                }
            
        }
    }
}
