using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElRestaurante
{
    internal class Menu
    {
        public List<Plat> Plats { get; set; }

        public Menu()
        {
            Plats = new List<Plat>(); // lors de l achat de mes plats dans gererRestaurant, je vais venir les inserer  ici
        }

        public void AjouterPlat(Plat plat)
        {
            Plats.Add(plat);
        }
        public void SupprimerPlat(Plat plat)
        {
            Plats.Remove(plat);
        }
        public override string ToString()
        {
            string info = $"---MENU--- ";
            for (int i = 0; i <Plats.Count(); i++)
            {
                info += $"{Plats[i].NomP} \n";
            }
            return info;
        }
    }
}
