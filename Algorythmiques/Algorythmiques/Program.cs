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
}
