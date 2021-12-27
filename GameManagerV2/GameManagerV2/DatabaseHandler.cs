using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GameManagerV2
{
    public class DatabaseHandler
    {
        readonly string connectionString;
        readonly string dbName = @".\games.db";

        public DatabaseHandler()
        {
            connectionString = @"URI=file:"+dbName;
        }
        public void InitializeDB()
        {
            // If database doesn't exists create it and table for data
            string filename = dbName;
            if (!File.Exists(filename))
            {
                SQLiteConnection cnn;
                cnn = new SQLiteConnection(connectionString);
                cnn.Open();

                using var cmd = new SQLiteCommand(cnn);
                cmd.CommandText = "CREATE TABLE games(id INTEGER PRIMARY KEY, name TEXT, date TEXT, progress TEXT, score INTEGER)";
                cmd.ExecuteNonQuery();

                cnn.Close();
            }
        }

        public int Insert(string gameName, out int id)
        {
            SQLiteConnection cnn;
            cnn = new SQLiteConnection(connectionString);
            cnn.Open();

            using var cmd = new SQLiteCommand(cnn)
            {
                CommandText = "SELECT MAX(id) FROM games"
            };

            var idobj = cmd.ExecuteScalar();
            id = 0;
            if (!DBNull.Value.Equals(idobj))
            {
                id = Convert.ToInt32(idobj) + 1;
            }

            cmd.CommandText = "INSERT INTO games(id, name) VALUES(@id, @name)";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", gameName);
            cmd.Prepare();

            int result = cmd.ExecuteNonQuery();

            cnn.Close();

            return result;
        }

        public GameRecord GetGameById(int id)
        {
            SQLiteConnection cnn;
            cnn = new SQLiteConnection(connectionString);
            cnn.Open();

            using var cmd = new SQLiteCommand(cnn);
            cmd.CommandText = "SELECT id, name, datetime(date), progress, score FROM games WHERE id = "+id.ToString();
            using SQLiteDataReader gameobj = cmd.ExecuteReader();

            GameRecord game = new GameRecord();

            if (gameobj.Read())
            {
                game.id = gameobj.GetInt32(0);
                if (!gameobj.IsDBNull(1))
                    game.name = gameobj.GetString(1);
                if (!gameobj.IsDBNull(2))
                    game.date = gameobj.GetDateTime(2);
                if (!gameobj.IsDBNull(3))
                    game.progress = gameobj.GetString(3);
                if (!gameobj.IsDBNull(4))
                    game.score = gameobj.GetInt32(4);
            }
            else
            {
                game.id = -1;
            }

            cnn.Close();

            return game;
        }

        public List<GameRecord> GetAllGames()
        {
            SQLiteConnection cnn;
            cnn = new SQLiteConnection(connectionString);
            cnn.Open();

            using var cmd = new SQLiteCommand(cnn)
            {
                CommandText = "SELECT id, name, datetime(date), progress, score FROM games"
            };
            using SQLiteDataReader gamesobj = cmd.ExecuteReader();

            List<GameRecord> games = new List<GameRecord>();

            while (gamesobj.Read())
            {
                GameRecord game = new GameRecord();

                game.id = gamesobj.GetInt32(0);
                if (!gamesobj.IsDBNull(1))
                    game.name = gamesobj.GetString(1);
                if (!gamesobj.IsDBNull(2))
                    game.date = gamesobj.GetDateTime(2);
                if (!gamesobj.IsDBNull(3))
                    game.progress = gamesobj.GetString(3);
                if (!gamesobj.IsDBNull(4))
                    game.score = gamesobj.GetInt32(4);

                games.Add(game);
            }

            cnn.Close();

            return games;
        }

        public int DeleteByID(int id)
        {
            SQLiteConnection cnn;
            cnn = new SQLiteConnection(connectionString);
            cnn.Open();

            using var cmd = new SQLiteCommand(cnn)
            {
                CommandText = "DELETE FROM games WHERE id = @id"
            };
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();

            int result = cmd.ExecuteNonQuery();

            cnn.Close();

            return result;
        }
    }
}
