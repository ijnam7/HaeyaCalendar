using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaeyaCalendar
{
    internal class ToDo
    {
        public DateTime deadline { get; set; }
        public string name { get; set; }
        public int workingHours { get; set; }
        public bool complete { get; set; }
        public bool star { get; set; }

        public ToDo(DateTime deadline, string name)
        {
            this.deadline = deadline;
            this.name = name;
            this.workingHours = 0;
            this.complete = false;
            this.star = false;
        }
    }
}
