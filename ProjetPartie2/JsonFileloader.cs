using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProjetPartie2
{
    internal class JsonFileloader
    {
        public T CharherFichier<T>(string filename)
        {
			try
			{
				using (StreamReader source = new StreamReader(filename)) 
				{
					string Json = source.ReadToEnd();
					return JsonConvert.DeserializeObject<T>(Json);
				}
			}
			catch (Exception ex)
			{
                Console.WriteLine("Erreur lors du chargement du fichier JSON : " + ex.Message);
				return default(T);
            }
        }
    }
}
