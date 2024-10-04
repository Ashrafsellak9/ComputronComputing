using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputronComputing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TodoList td1 = new TodoList();
            td1.Add("Eat");
            td1.Add("Sleep");
            td1.Add("Code");
            PasswordManager pm = new PasswordManager("ashraf@2003", true);
            Console.WriteLine("Initial display:");
            td1.Display();
            pm.Display();
            td1.Reset();
            pm.Reset();
            Console.WriteLine("\n After reset:");
            td1.Display();
            pm.Display();
        }
    }
}
