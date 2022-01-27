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
        readonly SQLiteConnection connection = null;

        public DatabaseHandler()
        {
            connectionString = @"URI=file:"+dbName;
            connection = new SQLiteConnection(connectionString);
            connection.Open();
        }

        public DatabaseHandler(string datebaseName)
        {
            dbName = datebaseName;
            connectionString = @"URI=file:" + dbName;
            connection = new SQLiteConnection(connectionString);
            connection.Open();
        }

        ~DatabaseHandler()
        {
            connection.Close();
        }

        public void InitializeDB()
        {
            // If database doesn't exists create it and table for data
            string filename = dbName;
            using var cmd = new SQLiteCommand(connection);
            cmd.CommandText = "SELECT name FROM sqlite_schema WHERE type = 'table' AND name = 'games'";
            using SQLiteDataReader reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                using var cmd2 = new SQLiteCommand(connection);
                cmd2.CommandText = "CREATE TABLE games(id INTEGER PRIMARY KEY, name TEXT, date TEXT, progress TEXT, score INTEGER)";
                cmd2.ExecuteNonQuery();
            }
        }

        public void DropDB()
        {
            using var cmd = new SQLiteCommand(connection);
            cmd.CommandText = "DROP TABLE games;";
            cmd.ExecuteNonQuery();
        }

        public int ModifyByID(int id, GameRecord gameRecord)
        {
            using var cmd = new SQLiteCommand(connection)
            {
                CommandText = "UPDATE games SET name = @name, date = @date, progress = @progress, score = @score WHERE id = @id"
            };
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", gameRecord.name);
            cmd.Parameters.AddWithValue("@date", gameRecord.date);
            cmd.Parameters.AddWithValue("@progress", gameRecord.progress);
            cmd.Parameters.AddWithValue("@score", gameRecord.score);
            cmd.Prepare();

            int result = cmd.ExecuteNonQuery();

            return result;
        }

        public int Insert(string gameName, out int id)
        {
            using var cmd = new SQLiteCommand(connection)
            {
                CommandText = "SELECT MAX(id) FROM games"
            };

            var idobj = cmd.ExecuteScalar();
            id = 0;
            if (!DBNull.Value.Equals(idobj))
            {
                id = Convert.ToInt32(idobj) + 1;
            }

            cmd.CommandText = "INSERT INTO games(id, name, date, progress) VALUES(@id, @name, @date, @progress)";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", gameName);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.Parameters.AddWithValue("@progress", "In progress");
            cmd.Prepare();

            int result = cmd.ExecuteNonQuery();

            return result;
        }

        public GameRecord GetGameById(int id)
        {
            using var cmd = new SQLiteCommand(connection);
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

            return game;
        }

        public List<GameRecord> GetAllGames()
        {
            using var cmd = new SQLiteCommand(connection)
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

            return games;
        }

        public int DeleteByID(int id)
        {
            using var cmd = new SQLiteCommand(connection)
            {
                CommandText = "DELETE FROM games WHERE id = @id"
            };
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();

            int result = cmd.ExecuteNonQuery();

            return result;
        }
    }
}
