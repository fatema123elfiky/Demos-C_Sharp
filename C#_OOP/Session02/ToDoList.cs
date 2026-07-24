using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02
{
    internal class ToDoList
    {
        private string[] tasks;
        private int count = 0;


        public ToDoList(int size)
        {
            tasks = new string[size];
        }


        public string GetTask(int idx)
        {
            if (tasks != null && idx >= 0 && idx < tasks.Length)
                return tasks[idx];
            return "Not found";
        }

        public void AddTask(string task, int idx)
        {
            if(tasks != null && idx >= 0 && idx < tasks.Length)
                this.tasks[idx] = task; 
            
        }


        // indexer
        // return         parameters
        public string this[int idx]
        {
            get {

                if (tasks != null && idx >= 0 && idx < tasks.Length)
                    return tasks[idx];
                return "Not found";
            }
            set {
                if (tasks != null && idx >= 0 && idx < tasks.Length)
                    this.tasks[idx] = value;
            }
        }


        public int this[string task]
        {
            get {

                if (tasks != null)
                {
                    for (int i = 0; i < tasks.Length; i++)
                    {
                        if (tasks[i] == task)
                            return i;
                    }
                }

                return -1;
            
            
            }
        }
    }
}
