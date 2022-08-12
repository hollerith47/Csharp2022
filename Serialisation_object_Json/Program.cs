using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Serialisation_object_Json
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\herma\\Desktop\\Learning\\C#\\data.json";
            string pathList = "C:\\Users\\herma\\Desktop\\Learning\\C#\\dataList.json";
            Client c1 = new Client("Makiese", "Herman");
            Client c2 = new Client("Hmak", "Herman");
            Client c3 = new Client("Hollerith", "Hm47");

            List<Client> listeClient = new List<Client>();
           /* listeClient.Add(c1);
            listeClient.Add(c2);
            listeClient.Add(c3); */

            // serialisation
            /* string jsonString = JsonSerializer.Serialize(c1) ;
            File.WriteAllText(path, jsonString);*/
            
            // serialisation liste
            /*
            string jsonString = JsonSerializer.Serialize(listeClient);
            File.WriteAllText(pathList, jsonString); */

            // Deserialisation
            /*string jsonString = File.ReadAllText(path);
            Client c4 = JsonSerializer.Deserialize<Client>(jsonString);
            c4.Information();*/
            
            // deserialisationList
            string jsonString = File.ReadAllText(pathList);
            listeClient = JsonSerializer.Deserialize<List<Client>>(jsonString);

            foreach (Client c in listeClient)
            {
                c.Information();
            }

        }
    }
}