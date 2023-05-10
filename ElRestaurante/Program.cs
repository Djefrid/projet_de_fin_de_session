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
                Console.WriteLine("Une erreur est survenue lors de la lecture du fichier: " + ex.Message);
            }
        }

        static int VerifierNbre()
        {
            bool verif = true;
            int num = 0;
            while (verif)
            {
                try
                {
                    string nbre1 = Console.ReadLine();

                    if (!int.TryParse(nbre1, out num))
                    {
                        throw new Exception("Vous n'avez pas entrer un entier");
                    }
                    else
                    {
                        verif = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return num;
        }

        static void Main(string[] args)
        {
            InitialiserNom();

            Console.WriteLine(FiggleFonts.Standard.Render("\t \t Bienvenue  au CentVin*****"), Color.Yellow);
            bool tours = true;
            int nbreR = 0;
            Restaurant resto = new Restaurant("CentVin", Statut.Open,0);
            GererRestaurant Gestresto = new GererRestaurant(resto);
            while (tours)
            {
                Console.WriteLine("\n ---------- MENU ----------", Color.Green);
                Console.WriteLine("----------------------------", Color.Green);
                Console.WriteLine("1- Regarder statut restaurant");
                Console.WriteLine("2- Changer le statut du restaurant");
                Console.WriteLine("3- Réservation");
                Console.WriteLine("4- Afficher le menu du jour");
                Console.WriteLine("5- Changer le menu du jour");
                Console.WriteLine("6- Afficher commandes");
                Console.WriteLine("7- Servir Clients");
                Console.WriteLine("8- Acheter un nouveau plat");
                Console.WriteLine("9- Quitter");
                char choix = Console.ReadKey().KeyChar;
                Console.WriteLine();
                try
                {

                    while (choix != '1' && choix != '2' && choix != '3' && choix != '4' && choix != '5' && choix != '6' && choix != '7' && choix != '8' && choix != '9')
                    {

                        throw new Exception("\n #Choix invalide#");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                switch (choix)
                {
                    case '1':
                        Console.WriteLine("Le restaurant est: " + resto.StatutR);
                        break;
                    case '2':
                        resto.ChangerStatutRestaurant();
                        break;
                    case '3':
                        if(resto.StatutR == Statut.Open)
                        {
                            Console.WriteLine("Entrez le nombre de reservation: ");
                            nbreR = VerifierNbre();
                            resto.NbreReserv = nbreR;
                            Console.WriteLine("Voici  la liste des clients: \n");
                            resto.AfficherClient();
                        }
                        else
                        {
                            Console.WriteLine("\n Le restaurant est fermé donc nous ne pouvons pas faire de réservation :(", color:Color.Red);
                        }

                        break;
                    case '4':
                        Console.WriteLine(resto.MenuR.ToString());   
                        break;
                    case '5':
                        resto.MenuR.ChangerMenu();
                        Console.WriteLine("Voici le nouveau menu du jour: \n", color:Color.Yellow);
                        Console.WriteLine(resto.MenuR.ToString());
                            break;
                    case '6':
                        if (nbreR != 0)
                            resto.AfficherCommande();
                        else
                            Console.WriteLine("\n Nous n'avons pas de commande", color:Color.Red);
                        break;
                    case '7':
                        resto.ServirClients();
                        break;
                    case '8':
                        Gestresto.AfficherPlatEnVente();
                        break;
                }


                /*
                Console.WriteLine("Entre le nombre de reservation: ");
                int nbre = Convert.ToInt32(Console.ReadLine());
                List<Client> Clients = new List<Client>();

                Console.WriteLine("Liste des clients");

                for (int i = 0; i < nbre; i++)
                {
                    Client client = new Client();
                    Clients.Add(client);

                }
                for (int i = 0; i < nbre; i++)
                {
                    Console.WriteLine(Clients[i].ToString());
                }
                */




                /*   Console.WriteLine("Liste des ingredients");
                   string chemin = "json_ingredient.json";
                   List<Ingredient> listIngredientDispo = JsonFileLoader.ChargerFichier<List<Ingredient>>(chemin);
                   if (listIngredientDispo != null)
                   {
                       foreach (Ingredient ingredient in listIngredientDispo)
                       {
                           Console.WriteLine($"Nom: {ingredient.NomI}, Calories: {ingredient.Calorie}, Qualité: {ingredient.QualiteIng}, Prix: {ingredient.Prix}");
                       }
                   }

               */
                // faire gerer restaurant
            }
        }
    }
}

