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
        public DateTime date { get; set; }
        public string name { get; set; }
        public int time { get; set; }

        public ToDo(string name)
        {
            this.date = DateTime.Today;
            this.name = name;
            this.time = 0;
        }
    }
}
