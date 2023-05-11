using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPartie2
{
    internal class Program
    {
        static void InitialiserNom()
        {
            try
            {
                FabriqueNom.RemplirListe();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Uneerreur est survenue lors de la lecture de fichier : {ex.Message}");
            }
        }

        static void Main(string[] args)
        {
            
            string nvnom = FabriqueNom.FabriquerNom();
            Console.WriteLine(nvnom);
        }
    }
}
