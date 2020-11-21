using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagerV2
{
    public class GameRecord
    {
        public int id;
        public string name;
        public DateTime date;
        public string progress;
        public int score;

        public GameRecord()
        {

        }

        public GameRecord(int id)
        {
            this.id = id;
        }

        public GameRecord(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public GameRecord(int id, string name, DateTime date)
        {
            this.id = id;
            this.name = name;
            this.date = date;
        }

        public GameRecord(int id, string name, DateTime date, string progress)
        {
            this.id = id;
            this.name = name;
            this.date = date;
            this.progress = progress;
        }

        public GameRecord(int id, string name, DateTime date, string progress, int score)
        {
            this.id = id;
            this.name = name;
            this.date = date;
            this.progress = progress;
            this.score = score;
        }
    }
}
