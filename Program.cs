using System.ComponentModel;

namespace TombokSzamokkal
{
    internal class Program
    {
        static Random r = new Random();
        static int[] tomb = new int[15];
        static void Feltoltes()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(-20, 21);

            }
            foreach (int item in tomb)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }


        static void Osszegzes()
        {
            int osszeg = 0;
            foreach (int item in tomb)
            {
                osszeg += item;
            }
            Console.WriteLine($"A számok összege: {osszeg}");
        }

        static void MegszamlalasTetele()
        {
            int db = 0;
            foreach (int item in tomb)
            {
                if (item > 0)
                {
                    db++;
                }
            }
            Console.WriteLine($"A negatív számok száma: {db}");
        }

        static void Eldontes()
        {
            int i =0;
            while (i < tomb.Length && tomb[i] !=0)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine("Van 0 a tömben");
            }
            else
            {
                Console.WriteLine("Nincs 0 a tömbben");
            }


        }

        static void KeresesTetel()
        {
            int KeresettSzam = 0; //nézzük meg, hogy van e benne 0, ha van akk hanyadik index
            int i = 0;
            while (i < tomb.Length && tomb[i] != KeresettSzam)
            {
                i++;
            }
            if(i<tomb.Length)
            {
                Console.WriteLine($"A keresett szám az {i}. indexen van");
            }
            else
            {
                Console.WriteLine("A keresett szám nincs a tömbben");
            }
        }

        static void KivalasztasTetel()
        {
            tomb[8] = 10;
            int i = 0;
            while (tomb[i] !=10 )
            {
                i++;
            }
            Console.WriteLine($"A keresett szám az {i+1}. helyen van");


        }

        static void Main(string[] args)
        {
            Feltoltes();
            Osszegzes();
            MegszamlalasTetele();
            Eldontes();
            KeresesTetel();
            KivalasztasTetel();
        }
    }
}
