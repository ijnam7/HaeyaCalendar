using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace HaeyaCalendar
{
    internal class ToDo
    {
        public ObjectId id { get; set; }
        public string date { get; set; }
        public string name { get; set; }
        public int time { get; set; }

        public ToDo(DateTime date, string name, int time)
        {
            this.date = date.ToString("d");
            this.name = name;
            this.time = time;
        }
    }
}
