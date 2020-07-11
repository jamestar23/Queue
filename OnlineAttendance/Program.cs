using System;
using System.Collections.Generic;

namespace OnlineAttendance
{
    class Program
    {
        static void Main(string[] args)
        {

		}
    }

    public delegate void AlertHandler(object sender, Attendance e);

    public class Attendance : EventArgs
    {
        public string name { get; set; }

		List<string> bannedList = new List<string> { 
			"Jack",
			"Steven",
			"Mathew" };

		public void Attendee(string nameA)
        {
            if (bannedList.Contains(nameA))
            {
                
            }
        }
        
    }
   


}
