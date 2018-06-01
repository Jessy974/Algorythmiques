using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorythmiques;

namespace Algorythmiques.MenuPreso
{
    /// <summary>
    /// Représente une ligne d'un menu
    /// </summary>
   public class MenuItem
    {
        public int Numero { get; set; }
        public string Libelle { get; set; }
    }
    /// <summary>
    /// Création de la classe Menu avec les méthods et la 
    /// </summary>
    class Menu
    {
        private List<MenuItem> lignes;

        public Menu()
        {
            lignes = new List<MenuItem>();
        }
        /// <summary>
        /// Insère un MenuItem dans le menu.
        /// 
        /// </summary>
        /// <param name="item"> element à insérer dans le menu</param>
        /// <exception cref="ArgumentException">si le numéro de l'item est déjà présent dans le menu</exception>
        public void InsererLigne(MenuItem ligne)

        {
            /*foreach (MenuItem numero in lignes)
            {
                if (numero.Numero == ligne.Numero)
                    
                {
                   throw new ArgumentException
                        ($"le numéro{ligne.Numero}existe déjà dans le menu");
                }
               
            }*/
            if (lignes.Exists(x => x.Numero == ligne.Numero))
            {
                throw new ArgumentException
                    ($"Le numéro {ligne.Numero} existe déjà dans le menu");
            }
            lignes.Add(ligne);

        }
        /// <summary>
        /// Afficher les elements du menu
        /// </summary>
        public void Afficher()
        {
            Console.Clear();

            foreach (MenuItem ligne in lignes)
            {
                Console.WriteLine($"{ligne.Numero} {ligne.Libelle}");
            }
        }

        public int Choisir()
        {
            //récupération de la saisie
            Console.WriteLine("Saisir un choix");
            int choix;
            choix = int.Parse(Console.ReadLine());


            //test du choix par rapport aux elements du menu
            foreach (MenuItem ligne in lignes)

            {
                Console.WriteLine($"{ligne.Numero}-{ligne.Libelle}");
            }
            int Choix;
            Choix = int.Parse(Console.ReadLine());

            foreach (MenuItem numero in lignes)
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
    /// <summary>
    /// création d'une classe sous menu ayant les mêmes items
    /// </summary>
    class SousMenu
    {
        private List<SousMenu> sousMenus;

        public SousMenu()
        {
           sousMenus  = new List<SousMenu>();
        }
    }
        
    public class Dossier
    {
        public void AfficherMenuDossier()
        {
          
        }
    }
    public class Voyage
    {
        public void AfficherMenuVoyage()
        {
            

        }
    }
    public class Client
    {
        public void AfficherMenuClient()
        {
          
        }

    }
}
