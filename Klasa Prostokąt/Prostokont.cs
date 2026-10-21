using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Klasa_Prostokąt
{
    public class Prostokont
    {
        public int a;
        public int b;
        public Prostokont()
        {
            UstawBoki(10, 5);
        }
        public Prostokont(int bokA, int bokB)
        {
            UstawBoki(bokA, bokB);

        }
        public void UstawBoki(int bokA, int bokB)
        {
            a = bokA;
            b = bokB;
        }

    }
    public class Program
    {

        static void Main(string[] args)
        {
            Prostokont p1 = new Prostokont();
            Prostokont p2 = new Prostokont(20,8);
            Console.WriteLine("Bezargumentowy: ");
            Console.WriteLine("Bok A: " + p1.a);
                Console.WriteLine("Bok B: " + p1.b);
            Console.WriteLine("Z argumentami 20 i 8: ");
            Console.WriteLine("Bok A: " + p2.a);
            Console.WriteLine("Bok B: " + p2.b);

        }
    }
}
