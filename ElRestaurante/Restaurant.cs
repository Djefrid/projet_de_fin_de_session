using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElRestaurante
{
    enum Statut
    {
        Open,
        Close
    }

    internal class Restaurant
    {
        public string NomR { get; set; }
        public Statut StatutR { get; set; }
        public int NbreReserv { get; set; }
        public List<Client> Clients { get; set; }
        public Menu MenuR { get; set; }
        public List<Facture> Factures { get; set; }
        public double RevenueTotal { get; set; }
        static Random rand = new Random();
        

        public Restaurant(string nomR, Statut statutR,int nbreR, Menu menuR)
        {
            NomR = nomR;
            StatutR = statutR;
            Clients = new List<Client>();
            InsererListeClient(Clients);
            MenuR = menuR;
           
        }

         public void InsererListeClient(List<Client> Cls)
         {

             for (int i = 0; i < NbreReserv; i++)
             {
                 Client client = new Client();
                 Cls.Add(client);
                
             }
           
         }

        public void ChangerStatutRestaurant()
        {
            if(StatutR == Statut.Open)
            {
                StatutR = Statut.Close;
                Console.WriteLine(" \n Fermeture du restaurant");
            }
            else
            {
                StatutR = Statut.Open;
                Console.WriteLine("\n Ouverture du restaurant");
            }
        }

        public void PasserCommande()
        {
            DateTime Ladate = DateTime.Now;
            string date = Convert.ToString(Ladate);
            for(int i = 0; i < NbreReserv; i++)
            {
                int nbre = rand.Next(1, 5);
                Factures[i] = new Facture(date, Clients[i], MenuR.Plats[nbre]);
            }
        }

        public void AfficherCommande()
        {
            RevenueTotal = 0;   
            Console.WriteLine("Liste des commandes: \n");
            for(int i = 0; i < NbreReserv; i++)
            {
                Console.WriteLine(Factures[i].ToString());
                RevenueTotal += Factures[i].CalculMontantPlat();
            }
            Console.WriteLine("Pour un montant total de: "+ RevenueTotal+" $");
        }

        public void ServirClients()
        {
            for (int i = 0; i < NbreReserv; i++)
            {
                Clients[i].StatutCl = StatutC.servi;
                
            }
        }

        public void LibererClient()
        {
            Clients.Clear();
        }

        public override string ToString()
        {
            string info = $"Nom restaurant: {NomR}\n Statut: {StatutR} \n Nombre de Reservation: {NbreReserv}"; 
            return info;
        }
    }
}
