using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputronComputing
{
    internal class TodoList : IDisplayable
    {
        private string[] Todos = new string[5];
        private int nextOpenIndex = 0;

        public void Add(string todo)
        {
            if (nextOpenIndex < Todos.Length)
            {
                Todos[nextOpenIndex] = todo;
                nextOpenIndex++;
            } else
            {
                Console.WriteLine("Todo list is full!");
            }
        }

        public void Display()
        {
            Console.WriteLine("Todos:");
            foreach(string todo in Todos)
            {
                if (!String.IsNullOrEmpty(todo))
                {
                    Console.WriteLine(todo);
                } else
                {
                    Console.WriteLine("[]");
                }
            }
        }

        public void Reset()
        {
            Todos = new string[5]; 
            nextOpenIndex = 0;
        }
    }
}
