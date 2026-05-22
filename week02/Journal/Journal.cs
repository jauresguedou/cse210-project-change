using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Data.Sqlite;


public class Journal
{
  public List<Entry>  _entries = new List<Entry>();

  public  void AddEntry (Entry newEntry)
    {
        _entries.Add(newEntry);
    }
   public void DisplayAll()
    {
        foreach (Entry newEntry in _entries)
        { 
            Console.WriteLine($"{newEntry._date}:{newEntry._promptText}");
            Console.WriteLine($"{newEntry._enterText}");
            
        }
    } 

   public void SaveToFile (string file)
    {
        
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach(Entry newEntry in _entries)
            {
                outputFile.WriteLine($"{newEntry._date},{newEntry._promptText},{newEntry._enterText}");
                
            }
        }
    }
    public void LoadFromFile (string file)
    {
        _entries.Clear();
        string [] lines = System.IO.File.ReadAllLines(file);
        

        foreach (string line in lines)
        {
            Entry loadedEntry = new Entry();
            string [] parts = line.Split(',');
            if (parts.Length >= 3)
            {
            string _promptText = parts[1];
            string _enterText = parts[2];
            string _date = parts[0];
            Console.WriteLine($"{_date}:{_promptText}");
            Console.WriteLine($"{_enterText}");



            loadedEntry._promptText = parts[1];
            loadedEntry._enterText = parts[2];
            loadedEntry._date = parts[0];

              _entries.Add(loadedEntry);

            }

            else
            {
                Console.WriteLine("Invalid format line in file");
            }
        }
        DisplayAll();
    }

// As a proof of creativity,I created a SQLite Database to Save and Load the file
    public void CreateDatabase ()
    {
        string connectionString =  "Data Source = journal.db";

        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            string tableCommand = 
            @"
               CREATE TABLE IF NOT EXISTS Entries (
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 PromptText TEXT,
                 EntryText TEXT,
                 Date TEXT

               
               )

            ";

            var command = new SqliteCommand(tableCommand,connection);

            command.ExecuteNonQuery();
        }


       Console.WriteLine("Database created successfully!");

    }
// Here the user can save his file to the SQLite Database
    public void SaveToDatabase()
    {
      string connectionString = "Data Source = journal.db";

      using (var connection = new SqliteConnection (connectionString))
      {
          connection.Open();
          foreach (Entry  newEntry in _entries)
          {
            string insertCommand =
            @"

              INSERT INTO Entries
              (PromptText,EntryText,Date)

              VALUES
              (@prompt,@entry,@date);
            
            ";

            var command = new SqliteCommand(insertCommand,connection);



            command.Parameters.AddWithValue("@prompt", newEntry._promptText);
            command.Parameters.AddWithValue("@entry", newEntry._enterText);
            command.Parameters.AddWithValue("@date", newEntry._date);

            command.ExecuteNonQuery();
          }
      }  
      Console.WriteLine("Entries saved successfully!");
    }


// Still as a proof of creativity, the user can load his file from the SQLite Database
    public void LoadFromDatabase()
{
    _entries.Clear();

    string connectionString = "Data Source=journal.db";

    using (var connection = new SqliteConnection(connectionString))
    {
        connection.Open();

        string selectCommand =
        @"
        SELECT * FROM Entries
        ";

        var command = new SqliteCommand(selectCommand, connection);

        using (SqliteDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                Entry loadedEntry = new Entry();

                loadedEntry._promptText = reader.GetString(1);
                loadedEntry._enterText = reader.GetString(2);
                loadedEntry._date = reader.GetString(3);

                _entries.Add(loadedEntry);
            }
        }
    }

    Console.WriteLine("Entries loaded successfully!");
    DisplayAll ();
}
    
    
}