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
        
        // le constructeur de classe Carte :
        public Carte(int n)
        {
            numero = n;
        }
    }
    class programme
    {
        static void Main(string[] args)
        {
            // remarque : on a prend le nombre quatre Cartes comme exemple : 
            // la déclaration d'un tableau t1 où on va stocker la suite des cartes que l'utilisateur a nous donnée : 
            int[4] t1;
            do{
                Console.WriteLine("Veuillez donner le nombre de chaque carte de 1 à 4 selon l'ordre que vous voulez :");
                for(i=0;i<4;i++){
                    Console.Write(i+1") ");
                    t1[i] = Console.ReadLine();
                }
            }while(t1[i]<0 || t1[i]>4 || t[i] == t[i+1]);
            
            // la déclaration de qautre objets :
            Carte c1 = new Carte(4);
            Carte c2 = new Carte(2);
            Carte c3 = new Carte(1);
            Carte c4 = new Carte(3);


            // le stock des quatre cartes à trier dans un nouveau tableau t2 :
            int t2[] = { c1.numero, c2.numero, c3.numero, c4.numero);

            // la déclaration d'une variable booléen qui va nous aider à arrêter le boucle et afficher le résultat :
            bool sontIdentiques = true;
            // on va faire la comparaison des cartes selon leurs nombres avec un boucle :
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
                // l'utilisation de la classe Random pour mixer les cartes aléatoirement :
                Random r = new Random();
                t2 = t2.orderBy(x => r.Next()).ToArray();
            } while (sontIdentiques = false);
               // on va faire ce traitement (cette comparaison) tant que la variable sonIdentiques est faux
            Console.log("la suite de cartes est : ")
                foreach (int j in t2)
        {
            Console.WriteLine(j);
        }
        }
    }
}
