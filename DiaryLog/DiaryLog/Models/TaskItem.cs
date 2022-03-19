using System;
using System.Collections.Generic;

namespace DiaryLog.Models
{
    public class TaskItem
    {

        private Dictionary<string, int> priorityDict = new Dictionary<string, int>(){
            { "No priority", 0},
            { "Low", 1},
            { "Medium", 2},
            { "High", 3},
            { "Very high", 4 }
        };

        public string Id { get; set; }
        public string Text { get; set; }
        public string Priority { 
            set 
            {
                if (!priorityDict.ContainsKey(value))
                    Console.WriteLine("Такого пиоритета нет");
                else
                    Priority = value;
            }
            get { return Priority; } 
        }

        public DateTime Deadline { get; set; }
        public string Description { get; set; }
    }
}