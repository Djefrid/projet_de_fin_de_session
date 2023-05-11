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
    internal class GererRestaurant
    {
        public Restaurant LeRestaurant { get; set; }
        public Menu LeMenu { get; set; }
        public List<Employe> Employes { get; set; }
        public List<Ingredient> ListIngredientDispo { get; set;}
        public List<Plat> ListPlatDispo { get; set; }
        public List<Plat> ListPlatEnVente { get; set; }
        public List<InventaireIng> InventaireIngs { get; set; }

        public GererRestaurant(Restaurant resto) // completer le constructeur after la finalisation du menu et des ingredients
        {
            LeMenu = new Menu();
            LeRestaurant = resto;
            Employes = new List<Employe>();
            Employes.Add(new Employe("Eric fortin", RareteE.moyenne, 6));
            Employes.Add(new Employe("Yan boily", RareteE.eleve, 10));
            Employes.Add(new Employe("Jaber laffy", RareteE.basse, 3));
            Employes.Add(new Employe("Sonia gagnon", RareteE.eleve, 10));
            ListPlatEnVente = JsonFileLoader.ChargerFichier<List<Plat>>("json_stockPlats.json");
            InventaireIngs = new List<InventaireIng>();
            Initialiser();
        }
        public void Initialiser()
        {
            ListIngredientDispo = JsonFileLoader.ChargerFichier<List<Ingredient>>("json_ingredient.json");
            ListPlatDispo = JsonFileLoader.ChargerFichier<List<Plat>>("json_plat.json");
        }

        public void AfficherListeEmploye()
        {
            foreach(Employe employe in Employes)
            {
                Console.WriteLine(employe.ToString(), color: Color.Yellow);
            }
        }
        public void AjouterPlatMenu(string nomplat)
        {
            bool find = false;
            for(int i =0; i<ListPlatDispo.Count; i++)
            {
                if (ListPlatDispo[i].NomP == nomplat)
                {
                    LeMenu.Plats.Add(ListPlatDispo[i]); 
                    find = true;
                }

            }
            if (!find)
            {
                Console.WriteLine("Désolé nous n'avons pas encore acheter ce plat", color: Color.Red);
            }
            else 
            {
                Console.WriteLine("Le plat vient d'être ajouter au menu :)", color: Color.Green);
            }

        }
        public void SupprimerPlat(string nomPlat)
        {
            for (int i = 0; i < LeMenu.Plats.Count; i++)
            {
                if (LeMenu.Plats[i].NomP == nomPlat)
                {
                    LeMenu.Plats.Remove(LeMenu.Plats[i]);
                }
                else
                {
                    Console.WriteLine("Ce plat n'est pas dans le menu", color: Color.Red);
                }
            }
        }
        public double CalculerPrixAchatTotal()
        {
            double total = 0;
            foreach (InventaireIng prix in InventaireIngs)
            {
                total += prix.PrixAchat;
            }
            return total;
        }
        public void AfficherPlatEnVente()
        {
            for(int i = 0; i < ListPlatEnVente.Count; i++)
            {
                Console.WriteLine((i+1)+"- "+ListPlatEnVente[i].ToString());
            }
        }
        public void AchatPlat(int numP)
        {
            ListPlatDispo.Add(ListPlatEnVente[numP]);
            Console.WriteLine(ListPlatEnVente[numP].ToString() +"\n viens d'être acheter :)", color:Color.Yellow);
        }

        public void AfficherIngredientAcheter()
        {
            foreach (InventaireIng inv in InventaireIngs)
            {
                Console.WriteLine(inv.ToString(),color: Color.Yellow);
            }
        }

        public void EngagerEmploye()
        {
            
            Console.WriteLine("Entre le nom de l'employé: ");
            string nomE = Console.ReadLine();
            Console.WriteLine("Entre la rarete de l'employé: (0 pour basse, 1 pour moyenne et 2 pour faible)");
            int rare = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre l'effet  de l'employé: ");
            int eff = Convert.ToInt32(Console.ReadLine());
            Employe emp = new Employe(nomE, (RareteE)rare, eff);
            Employes.Add(emp);  
        }

        public void AcheterIngredient()
        {
            for(int i =0; i< ListIngredientDispo.Count; i++)
            {
                Console.WriteLine(1+i +"-  "+ListIngredientDispo[i].ToString());
            }        
            int nbre = 1;
            int qt = 0;
            bool verif = true;
            bool verif2 = true;
            while (verif)
            {
                try
                {
                    Console.WriteLine("Entrez le numero de l'ingredient: ");
                    string num = Console.ReadLine();
                    if (!int.TryParse(num, out nbre))
                    {
                        throw new Exception("Vous n'avez pas entrez un entier");
                    }
                    else if(int.TryParse(num, out nbre) && (nbre > ListIngredientDispo.Count || nbre <1))
                    {
                        throw new Exception("Le numero de l' ingredient  n'est pas correct");
                    }
                    else
                    {
                        verif = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Une exception s'est produite : " + ex.Message);
                }

            }
        
            while (verif2)
            {
                try
                {
                    Console.WriteLine("Entrez la quantité à acheter: ");
                    string qte = Console.ReadLine();
                    if (!int.TryParse(qte, out qt))
                    {
                        throw new Exception("Vous n'avez pas entrez un entier");
                    }
                    else
                    {
                        verif2 = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Une exception s'est produite : " + ex.Message);
                }

            }
            InventaireIng inv = new InventaireIng(ListIngredientDispo[nbre-1],qt); 
            InventaireIngs.Add(inv);

        }
    }
}
