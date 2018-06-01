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

            menu.InsererLigne(new MenuItem { Numero = 1, Libelle = "client" });
            menu.InsererLigne(new MenuItem { Numero = 2, Libelle = "voyage" });
            menu.InsererLigne(new MenuItem { Numero = 3, Libelle = "dossier" });


            menu.Afficher();
            int resultat = menu.Choisir();
            Console.ReadLine();

            switch (resultat)
            {
                case 1:
                    SousMenuClient();
                    break;
                case 2:
                    SousMenuVoyage();
                    break;
                case 3:
                    SousMenuDossier();
                    break;
            }
        }

        private static void SousMenuClient()
        {
            Menu sousMenu = new Menu();
            sousMenu.InsererLigne(new MenuItem { Numero = 1, Libelle = "Créer" });
            sousMenu.InsererLigne(new MenuItem { Numero = 2, Libelle = "Rechercher" });
            sousMenu.InsererLigne(new MenuItem { Numero = 3, Libelle = "Supprimer" });
            sousMenu.Afficher();
            int resultat = sousMenu.Choisir();
          


            switch (resultat)
            {
                case 1:
                    Console.WriteLine("Vous souhaitez créer un nouveau client");
                    break;
                case 2:
                    Console.WriteLine("Vous souhaitez rechercher un client");
                    break;
                case 3:
                    Console.WriteLine("Vous souhaitez supprimer un client");
                    break;
              
            }
           
        }

        private static void SousMenuVoyage()
        {
            Menu sousMenu = new Menu();
            sousMenu.InsererLigne(new MenuItem { Numero = 1, Libelle = "Destination" });
            sousMenu.InsererLigne(new MenuItem { Numero = 2, Libelle = "Compagnie" });
            sousMenu.Afficher();
            int resultat = sousMenu.Choisir();
    


            switch (resultat)
            {
                case 1:
                    Console.WriteLine("Vous souhaitez : voyages =>Destination");
                    break;
                case 2:
                    Console.WriteLine("Vous souhaitez : voyages =>Compagnie");
                    break;
            }

        }

        private static void SousMenuDossier()
        {
            Menu sousMenu = new Menu();
            sousMenu.InsererLigne(new MenuItem { Numero = 1, Libelle = "Créer" });
            sousMenu.InsererLigne(new MenuItem { Numero = 2, Libelle = "Rechercher" });
            sousMenu.InsererLigne(new MenuItem { Numero = 2, Libelle = "Spprimer" });
            sousMenu.Afficher();
            int resultat = sousMenu.Choisir();
          


            switch (resultat)
            {
                case 1:
                    Console.WriteLine("Vous souhaitez créer un nouveau dossier");
                    break;
                case 2:
                    Console.WriteLine("Vous souhaitez rechercher un dossier");
                    break;
                case 3:
                    Console.WriteLine("Vous souhaitez supprimer un dossier");
                    break;

            }
        }
    }
}
//fin de l'exercie, affichage de la méthode