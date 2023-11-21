using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpN2
{
    class Carte
    {
        public int numero;
        public Carte(int n)
        {
            numero = n;
        }
    }
    class programme
    {
        static void Main(string[] args)
        {
            int[4] t1;
            Console.WriteLine("Veuillez donner l'ordre de 4 cartes : ");
            Console.WriteLine("1");
            t1[0] = Console.ReadLine();
            Console.WriteLine("2");
            t1[1] = Console.ReadLine();
            Console.WriteLine("3");
            t1[2] = Console.ReadLine();
            Console.WriteLine("4");
            t1[3] = Console.ReadLine();


            Carte c1 = new Carte(4);
            Carte c2 = new Carte(2);
            Carte c3 = new Carte(1);
            Carte c4 = new Carte(3);

            int t2[] = { c1.numero, c2.numero, c3.numero, c4.numero);
            bool sontIdentiques = true;
            do
            {
                for (int i = 0; i < t1.Length; i++)
                {
                    if (t1[i] != t2[i])
                    {
                        sontIdentiques = false;
                        break;
                    }
                }
                Random r = new Random();
                t2 = t2.orderBy(x => r.Next()).ToArray();
            } while (sontIdentiques = false);

        }
    }
}