using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPartie2
{
    internal class Plat
    {
        public string Name { get; set; }
        public int PrixAchat { get; set; }
        public int PrixVente { get; set; }
        public string Rarete { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Plat() { }
    }
}
