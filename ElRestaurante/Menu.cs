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

        public Menu()        {
            Plats = new List<Plat>();
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
