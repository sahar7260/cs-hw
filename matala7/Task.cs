using System;
using System.Collections.Generic;
using System.Text;

namespace matala7
{
    internal class Task
    {
        public int TaskID { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public int CompareTo(object obj)
        {
            
             Task other = (Task)obj;

            if (this.Priority < other.Priority)
                return -1;
            if (this.Priority > other.Priority)
                return 1;
            return 0;
        }
}
