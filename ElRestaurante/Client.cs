using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElRestaurante
{
    public enum Temperament
    {
        gentil,
        poli,
        colerique,
        severe
    }
    internal class Client
    {
        public string NomC { get; set; }
        public Temperament Tempt { get; set; }
        static Random rand = new Random();

        public Client()
        {
            int rnd = rand.Next(1,4);
            NomC = Factory.FabriquerNom();
            Tempt = (Temperament)rnd;
        }

        public override string ToString()
        {
            string info = $"Nom: {NomC}, Tempérament: {Tempt}"; 
            return info;
        }


    }
}
