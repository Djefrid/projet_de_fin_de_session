using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPartie2
{
    internal class Menu
    {
        List<Plat> Plats {  get; set; }

        public Menu() { }

        public void AddPlat(Plat plat) 
        {
            if (plat != null)
                Plats.Add(plat);
            else
                Console.WriteLine("Valuer null");
        }

        public void RemovePlat(Plat plat)
        {
            if (plat != null)
                Plats.Remove(plat);
            else
                Console.WriteLine("Valuer null");
        }
    }
}
