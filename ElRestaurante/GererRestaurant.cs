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
            LeRestaurant = resto;
            Employes = new List<Employe>();
            ListPlatEnVente = JsonFileLoader.ChargerFichier<List<Plat>>("json_stockPlats.json");
            InventaireIngs = new List<InventaireIng>();
            Initialiser();
        }
        public void Initialiser()
        {
            ListIngredientDispo = JsonFileLoader.ChargerFichier<List<Ingredient>>("json_ingredient.json");
            ListPlatDispo = JsonFileLoader.ChargerFichier<List<Plat>>("json_plat.json");
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
            Console.WriteLine(ListPlatEnVente[numP].ToString() +"viens d'être acheter :)", color:Color.Yellow);
        }

        public void EngagerEmploye(string nomE, RareteE rare, int eff)
        {
            Employe emp = new Employe(nomE, rare, eff);
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
            InventaireIng inv = new InventaireIng(ListIngredientDispo[nbre],qt); 
            InventaireIngs.Add(inv);

        }
    }
}
