using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythmiques
{
    class Program
    {
        static void Main(string[] args)
        {


        }
        private static int GereMenu(List<string> menu)
        {
            foreach (string ligne in menu)
            {
                Console.WriteLine(ligne);
            }
            int choix;
            choix = int.Parse(Console.ReadLine());
            return choix;
        }

    }
    class MenuItem
    {
        public int Numero { get; set; }
        public string Libelle { get; set; }

        private static int VerifierMenu(List<MenuItem> menu)
        {
            foreach (MenuItem ligne in menu)

            {
                Console.WriteLine($"{ligne.Numero}-{ligne.Libelle}");
            }
            int Choix;
            Choix = int.Parse(Console.ReadLine());

            foreach (MenuItem numero in menu)
            {
                if (Choix == numero.Numero)
                {
                    return Choix;
                }
            }
            Console.WriteLine("Erreur lors de la saisie");
            return -1;
        }
    }

}
