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
                Console.WriteLine("Une erreur est survenue lors de la lecture dui fichier: " + ex.Message);
            }
        }
        static void Main(string[] args)
        {
            InitialiserNom();
            Console.WriteLine("Entre le nombre de reservation: ");
            int nbre = Convert.ToInt32(Console.ReadLine());
            List<Client> Clients = new List<Client>();

            Console.WriteLine("Liste des clients");
            for (int i = 0; i < nbre; i++)
            {
                Console.WriteLine(Clients[i].ToString());
            }
            // faire gerer restaurant
        }
    }
}
