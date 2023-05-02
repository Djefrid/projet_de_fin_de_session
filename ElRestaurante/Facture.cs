using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElRestaurante
{
    internal class Facture
    {
        public string Date { get; set; }
        public Client ClientF { get; set; }
        public Plat PlatF { get; set; }
        public double TPS { get; set; }
        public double TVQ { get; set; }


        public Facture(string date, Client clientF, Plat platF)
        {
            Date = date;
            ClientF = clientF;
            PlatF = platF;
            TPS = platF.PrixV * 0.05;
            TVQ = platF.PrixV * 0.1;
        }

        public double CalculMontantPlat()
        {

            double total = TPS + TVQ + PlatF.PrixV;
            return total;
        }

        public override string ToString()
        {
            string info = "----FACTURE---- \n";
            info += $"Date: {Date} \n Nom du client:{ClientF.NomC} \n Plat: {PlatF.NomP} \n Prix du plat: {PlatF.PrixV} \n TPS: {TPS} \n TVQ: {TVQ} \n Montant total: {CalculMontantPlat()} $";
            return info;
        }
    }
}
