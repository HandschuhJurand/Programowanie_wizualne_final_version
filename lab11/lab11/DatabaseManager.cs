using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    public class DatabaseManager
    {
        private string connectionString = @"Data Source=Samples.db;Version=3";

        public DatabaseManager()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS Probki (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    SampleId TEXT UNIQUE NOT NULL,
                    Name TEXT NOT NULL,
                    Type TEXT NOT NULL,
                    CollectionDate TEXT NOT NULL,
                    Description TEXT
                )";
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Dodaj_probke(Probki sample)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = @"INSERT INTO Probki 
                (SampleId, Name, Type, CollectionDate, Description)
                VALUES (@SampleId, @Name, @Type, @CollectionDate, @Description)";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@SampleId", sample.SampleId);
                command.Parameters.AddWithValue("@Name", sample.Name);
                command.Parameters.AddWithValue("@Type", sample.Type.ToString());
                command.Parameters.AddWithValue("@CollectionDate", sample.CollectionDate.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@Description", sample.Description);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Błąd podczas dodawania próbki: " + ex.Message);
                }
            }
        }

        public List<Probki> Pobierz_probki()
        {
            var samples = new List<Probki>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT * FROM Probki";
                SQLiteCommand command = new SQLiteCommand(query, connection);

                try
                {
                    connection.Open();
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var sample = new Probki
                        {
                            SampleId = reader.GetString(1),
                            Name = reader.GetString(2),
                            Type = (SampleType)Enum.Parse(typeof(SampleType), reader.GetString(3)),
                            CollectionDate = DateTime.Parse(reader.GetString(4)),
                            Description = reader.GetString(5)
                        };
                        samples.Add(sample);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Błąd podczas pobierania próbek: " + ex.Message);
                }
            }
            return samples;
        }

        public void Zapisz_probki(List<Probki> lista)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                var del = new SQLiteCommand("DELETE FROM Probki", connection);
                del.ExecuteNonQuery();

                foreach (var sample in lista)
                {
                    var cmd = new SQLiteCommand(
                        "INSERT INTO Probki (SampleId, Name, Type, CollectionDate, Description) VALUES (@id, @name, @type, @date, @desc)", connection);
                    cmd.Parameters.AddWithValue("@id", sample.SampleId);
                    cmd.Parameters.AddWithValue("@name", sample.Name);
                    cmd.Parameters.AddWithValue("@type", sample.Type.ToString());
                    cmd.Parameters.AddWithValue("@date", sample.CollectionDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@desc", sample.Description);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
