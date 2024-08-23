using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Asssessed_Exercise_3_Task_C
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            
            Menu();
            Console.ReadLine();
        }
        public static string divider = "====================================================================================================================";
        public static void Menu()
        {
            // Menu for User to CHoose Option for activities
            Console.WriteLine(divider);
            Console.WriteLine("\nActivity Planner\n");
            Console.WriteLine("Enter a list activities and the most amount of activities that can be done in that day will be displayed");
            Console.WriteLine("Press 1 to Enter Activities");
            Console.WriteLine("Press 2 to use Pre-Made List");
            string input = Console.ReadLine();

            if (input == "1")
            {
                AddActivities();
            }
            else if(input == "2")
            {
                PreMadeActivities();
            }
            else Menu();
        }

        public static void PreMadeActivities()
        {
            // Pre Inserts Activities into an array
            Activity A1 = new Activity(1, "12.00", "12.15");
            Activity A2 = new Activity(2, "15.00", "15.45");
            Activity A3 = new Activity(3, "12.30", "16.00");
            Activity A4 = new Activity(4, "13.45", "15.00");
            Activity A5 = new Activity(5, "12.00", "12.45");
            Activity A6 = new Activity(6, "12.30", "13.30");
            Activity A7 = new Activity(7, "13.00", "14.30");

            Activity[] preMadeActivities = { A1, A2, A3, A4, A5, A6, A7 };

            Console.WriteLine(divider);

            Console.WriteLine("\nList of Activities\n");
            for (int i = 0; i < Convert.ToInt32(preMadeActivities.Length); i++)
            {
                Console.WriteLine(preMadeActivities[i].ToString()); // Outputs all activites in Array
            }
            SelectionSort(preMadeActivities);   // Sorts array

            string[] ST = { preMadeActivities[0].StartTime, preMadeActivities[1].StartTime, preMadeActivities[2].StartTime, preMadeActivities[3].StartTime,
            preMadeActivities[4].StartTime, preMadeActivities[5].StartTime, preMadeActivities[6].StartTime};
            string[] FT = { preMadeActivities[0].FinishTime, preMadeActivities[1].FinishTime, preMadeActivities[2].FinishTime, preMadeActivities[3].FinishTime,
            preMadeActivities[4].FinishTime, preMadeActivities[5].FinishTime, preMadeActivities[6].FinishTime};

            ActivitySelection(preMadeActivities, ST, FT);       // Calls function to dispaly chosen outputs
        }

        public static void AddActivities()
        {
            // Lets the user enter an amount of activies of their choice into an array
            Console.WriteLine(divider);
            Console.WriteLine("\nActivity List");
            string listSize;
            do
            {
                Console.WriteLine("\nEnter the Size of List");
                listSize = Console.ReadLine();                  // If list size is digit the accept

            }   while (!Regex.IsMatch(listSize, @"^\d+$"));

            Activity[] activities = new Activity[Convert.ToInt32(listSize)];

            string ID = "";
            string start = "";
            string finish = "";

            for (int i = 0; i < Convert.ToInt32(listSize); i++)
            {
                Console.WriteLine(divider);
                do
                {
                    Console.WriteLine(" \nEnter Activiy ID: (Integer)");
                    ID = Console.ReadLine();

                }   while (!Regex.IsMatch(ID, @"^\d+$"));

                do
                {
                    Console.WriteLine("\nEnter Start Time: (XX.XX)");
                    start = Console.ReadLine();
                }   while (!Regex.IsMatch(start, @"[0-9]{2}[.][0-9]{2}"));      // Gets all Activities Info, with times in specific format

                do
                {
                    Console.WriteLine("\nEnter Finish Time: (XX.XX)");
                    finish = Console.ReadLine();
                }   while (!Regex.IsMatch(finish, @"[0-9]{2}[.][0-9]{2}"));
                
                
                Activity newAcitivity = new Activity(Convert.ToInt32(ID), start, finish);
                activities[i] = newAcitivity;
                Console.WriteLine(divider);
            }

            Console.WriteLine("\nList of Activities\n");
            for (int i = 0; i < Convert.ToInt32(listSize); i++)
            {
                Console.WriteLine(activities[i].ToString());
            }

            SelectionSort(activities);  // Sorts array

            string[] ST = new string[activities.Length];
            string[] FT = new string[activities.Length];

            for (int i = 0; i < Convert.ToInt32(listSize); i++)
            {
                ST[i] = activities[i].StartTime;
                FT[i] = activities[i].FinishTime;
            }
            ActivitySelection(activities, ST, FT);  // Calls function to dispaly chosen outputs
        }



        public static void ActivitySelection(Activity[] activities, string[] startTimes, string[] finishTimes)
        {
            List<Activity> selectedActivities = new List<Activity>();       // list of selected activities; initially empty 

            int index = 0;                                                 
            selectedActivities.Add(activities[index]);                      //select the activity that finishes first 

            for(int i = 0; i < activities.Length; i++)                  // for all remaining activities 
            {
                if(startTimes[i].CompareTo(finishTimes[index]) >= 0)
                {
                    selectedActivities.Add(activities[i]);          // adds to new array
                    index = i;
                }                                                           // select new activity
            }

            Console.WriteLine("\nList of Most Activities Chosen\n");

            for(int i = 0; i < selectedActivities.Count ; ++i)
            {
                Console.WriteLine(selectedActivities[i].ToString());        // Displays chosen activities
            }

            Console.WriteLine("\n" + divider);

            Menu();
        }

        static public void SelectionSort<T>(T[] list) where T : IComparable
        {
            for (int i = 0; i < list.Length; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[j].CompareTo(list[smallest]) < 0)
                    {
                        smallest = j;
                    }
                }
                swap(ref list[i], ref list[smallest]);
            }
        }
        static public void swap<T>(ref T x, ref T y) where T : IComparable
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}
