using Newtonsoft.Json;
using System;
using System.IO;

namespace ElRestaurante
{
    public static class JsonFileLoader
    {
        public static T ChargerFichier<T>(string nomFichier)
        {
            try
            {
                using (StreamReader reader = new StreamReader(nomFichier))
                {
                    string json = reader.ReadToEnd();
                    return JsonConvert.DeserializeObject<T>(json);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors du chargement du fichier JSON: " + ex.Message);
                return default(T);
            }
        }
    }
}
