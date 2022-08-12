using System;
using System.IO;
using System.Data.SQLite;

namespace BddSqLite
{
    class Program
    {
        static void Main(string[] args)
        {
            string bddpath = "C:\\Users\\herma\\Desktop\\Learning\\C#\\bdd.sqlite";
            if (!File.Exists(bddpath)) CreateBDD();
            
            /*AddData("Makiese", "Herman");
            AddData("Victoria", "Gogotova");*/
            
            // ReadAllData();
            
            // creation de la bdd
            void CreateBDD()
            {
                SQLiteConnection.CreateFile(bddpath);
                SQLiteConnection con = new SQLiteConnection("Data Source=C:\\Users\\herma\\Desktop\\Learning\\C#\\bdd.sqlite;Version=3;");
                con.Open();

                string sql = "create table clients (nom varchar(20), prenom varchar(20))";

                SQLiteCommand command = new SQLiteCommand(sql, con);
                command.ExecuteNonQuery();
                
                con.Close();
            }
            
            // ajouter des donnees dans la table clients
            void AddData(string n, string p)
            {
                SQLiteConnection con = new SQLiteConnection("Data Source=C:\\Users\\herma\\Desktop\\Learning\\C#\\bdd.sqlite;Version=3;");
                con.Open();

                string sql = "INSERT INTO clients(nom, prenom) VALUES ('" + n + "','" + p + "')";
                SQLiteCommand command = new SQLiteCommand(sql, con);
                command.ExecuteNonQuery();
                
                con.Close();
            }
            
            // Lire la table
            void ReadAllData()
            {
                SQLiteConnection con = new SQLiteConnection("Data Source=C:\\Users\\herma\\Desktop\\Learning\\C#\\bdd.sqlite;Version=3;");
                con.Open();

                string sql = "SELECT * FROM clients";
                SQLiteCommand command = new SQLiteCommand(sql, con);
                SQLiteDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine($"Nom: {dr.GetString(0)}  Prenom: {dr.GetString(1)}");
                    
                }
            }

            void ConnectionToDataBase()
            {
                
            }
            
            // la classe environnement
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            Console.WriteLine(Environment.MachineName);
            Console.WriteLine(Environment.OSVersion);
            Console.WriteLine(Environment.Is64BitOperatingSystem);
            Console.WriteLine(Environment.UserName);
            Console.WriteLine(Environment.UserInteractive);
            Console.WriteLine(Environment.TickCount);
        }

        
    }
}