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
            //creation de la liste MenuItem
            List<MenuItem> list = new List<MenuItem>
            {
                new MenuItem { Numero =1, Libelle= "menu 1"},
                new MenuItem { Numero =2, Libelle= "menu 2"},
                new MenuItem { Numero =3, Libelle= "menu 3"},
                new MenuItem { Numero =4, Libelle= "menu 4"},

            };

            int resultat = GereMenu(list);
            Console.ReadLine();
            Console.ReadKey();

        }
        /// <summary>
        /// Affiche un menu et le choix de l'utilisateur
        /// </summary>
        /// <param name="menu">la liste des choix possibles</param>
        /// <returns>le choix de l'utilisateur</returns>
        private static int GereMenu(List<MenuItem> menu)
        {
            //Afficher les elements du menu
            foreach (MenuItem ligne in menu)
            {
                Console.WriteLine(ligne);
            }
            //recuperation du choix de l'utilisateur
            int choix;
            choix = int.Parse(Console.ReadLine());
            return choix;
        }


    }
    /// <summary>
    /// Reprépsente une ligne d'un menu
    /// </summary>
    class MenuItem
    {
        public int Numero { get; set; }
        public string Libelle { get; set; }

        private static int VerifierMenu(List<MenuItem> menu)
        {
            //test du choix par rapport aux elements du menu
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
            //return menu.SingleOrDefault(x=>x.Numero==Choix) != null ? choix : -1;
        }
    }
    class Menu
    {



    }


}
