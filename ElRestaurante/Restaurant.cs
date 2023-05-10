using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Figgle;
using Console = Colorful.Console;

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


        public Restaurant(string nomR, Statut statutR, int nbreR)
        {
            NomR = nomR;
            StatutR = statutR;
            Clients = new List<Client>();
            NbreReserv = nbreR;
            MenuR = new Menu();
            Factures = new List<Facture>(); 

        }

        public void InsererListeClient(List<Client> Cls)
        {

            for (int i = 0; i < NbreReserv; i++)
            {
                Client client = new Client();
                Cls.Add(client);

            }

        }

        public void AfficherClient()
        {
            InsererListeClient(Clients);
            for (int i = 0; i < NbreReserv; i++)
            {
                Console.WriteLine(Clients[i].ToString());
                int nbre = rand.Next(1, 4);
                Factures.Add( new Facture(Clients[i], MenuR.Plats[nbre]));
            }
        }


        public void AfficherClientEtFacture()
        {
            InsererListeClient(Clients);
            for (int i = 0; i < NbreReserv; i++)
            {
                Console.WriteLine(Clients[i].ToString());
            }
        }

        public void ChangerStatutRestaurant()
        {
            if (StatutR == Statut.Open)
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



        public void AfficherCommande()
        {
            RevenueTotal = 0;
            Console.WriteLine("Liste des commandes: \n");
            for (int i = 0; i < NbreReserv; i++)
            {
                Console.WriteLine(Factures[i].ToString());
                RevenueTotal += Factures[i].CalculMontantPlat();
            }
            Console.WriteLine("Pour un montant total de: " + RevenueTotal + " $");
        }

        public void ServirClients()
        {
            for (int i = 0; i < NbreReserv; i++)
            {
                Clients[i].StatutCl = StatutC.servi;
                Console.WriteLine(Clients[i].NomC+" a été servi ;)", color:Color.Yellow);
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
