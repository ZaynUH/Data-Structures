using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssessed_Exercise_3_Task_C
{
    internal class Activity : IComparable
    {
        private int Id;
        private string startingTime;
        private string finishTime;

        public Activity(int id, string ST, string FT)
        {
            Id = id;
            startingTime = ST;
            finishTime = FT;
        }

        public int ID
        {
            set { this.Id = value; }
            get { return this.Id; }
        }

        public string StartTime
        {
            set { this.startingTime = value; }
            get { return this.startingTime; }
        }

        public string FinishTime
        { 
            set { this.finishTime = value; }
            get { return this.finishTime; }
        }

        public int CompareTo(object obj)
        {
            Activity other = obj as Activity;
            return this.FinishTime.CompareTo(other.FinishTime);     //Comapres Activities with each others finish time
        }
        public new string ToString()
        {
            return "ID: " + this.Id + " Start Time: " + this.startingTime + " Finish Time: " + this.finishTime;
        }
    }
}
