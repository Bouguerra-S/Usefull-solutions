using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planning.Models
{
    internal class EventCategory:IComparable<EventCategory>
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private int priority;

		public int Priority
		{
			get { return priority; }
			set { priority = value; }
		}

		public int CompareTo(EventCategory? other)
		{
			if (this.priority>other.priority)
			{
				return 1;
			}
			else if (this.priority < other.priority) { return -1; }
			return 0;
		}
	}
}
