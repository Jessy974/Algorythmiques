using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorythmiques;

namespace Algorythmiques.MenuPreso
{
   public class MenuItem
    {
        public int Numero { get; set; }
        public string Libelle { get; set; }
        
        
    }

    class Menu
    {
        public static void InsererLigne (MenuItem ligne)
              
            {
            List<MenuItem> liste = new List<MenuItem>();

            foreach (MenuItem numero in liste )
            {
                if (numero.Numero == ligne.Numero)

                {
                    return;
                }
               
            }
        }
        public void Afficher()
        {
            List<MenuItem> liste = new List<MenuItem>();

            {
                new MenuItem { Numero = 1, Libelle = "menu 1" };
                new MenuItem { Numero = 2, Libelle = "menu 2" };
                new MenuItem { Numero = 3, Libelle = "menu 3" };
                new MenuItem { Numero = 4, Libelle = "menu 4" };

            };

            
            foreach (MenuItem ligne in liste)
            {
                Console.WriteLine(ligne);
            }
        }

        public int Choisir()
        {
            int choix;
            choix = int.Parse(Console.ReadLine());
            return choix;
        }
    }
}
