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
        static Random rnd = new Random();   
        public Menu()
        {
            List<Plat> list = JsonFileLoader.ChargerFichier<List<Plat>>("json_plat.json");
            Plats = new List<Plat>();
            for(int i=0 ; i < (list.Count )/2; i++)
            {
                
                Plats.Add(list[i]);
            }
            
        }


        public void ChangerMenu()
        {
            List<Plat> list = JsonFileLoader.ChargerFichier<List<Plat>>("json_plat.json");
            Plats = new List<Plat>();
            for (int i = ((list.Count)/2)-1; i < list.Count; i++)
            {

                Plats.Add(list[i]);
            }
        }
        public override string ToString()
        {
            string info = $"---MENU DU JOUR--- \n";
            for (int i = 0; i < Plats.Count(); i++)
            {
                info += $"# {Plats[i].NomP} \n";
            }
            return info;
        }
    }
}
