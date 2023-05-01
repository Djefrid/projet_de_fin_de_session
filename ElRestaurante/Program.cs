using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElRestaurante
{
    internal class Program
    {
        static void InitialiserNom()
        {
            try
            {
                Factory.RemplirListe();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur est survenue lors de la lecture dui fichier: "+ex.Message);
            }
        }
        static void Main(string[] args)
        {
            InitialiserNom();
        }
    }
}
