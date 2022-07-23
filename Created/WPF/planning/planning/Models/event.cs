using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planning.Models
{
    internal class Event:IComparable<Event>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime startTime { get;set; }

        public DateTime endTime { get;set; }

        public EventCategory Category { get; set; }

        public bool recurrent { get; set; } 
        public bool liberty { get; set; }

        public int CompareTo(Event? other)
        {
            if (startTime>other.startTime)
            {
                return 1;
            }
            else if (startTime < other.startTime)
            {
                return -1;
            }
            return 0;
        }
    }
}
