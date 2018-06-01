using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorythmiques.MenuPreso;

namespace Algorythmiques
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            menu.InsererLigne(new MenuItem { Numero = 1, Libelle = "menu 1" });
            menu.InsererLigne(new MenuItem { Numero = 2, Libelle = "menu 2" });
            menu.InsererLigne(new MenuItem { Numero = 3, Libelle = "menu 3" });
            menu.InsererLigne(new MenuItem { Numero = 3, Libelle = "menu 3Bis" });

            int resultat = menu.Choisir();
            Console.WriteLine(resultat);
            Console.ReadLine();
        }
    }
}
//fin de l'exercie, affichage de la méthode