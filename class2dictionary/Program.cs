using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> students = new Dictionary<int, string>();

            students.Add(1, "Katie Harris");
            students.Add(2, "Adam Ackerman");
            students.Add(3, "Harry Smith");



            if (students.ContainsKey(1))
            {
                students[1] = "Some new value";
            }
            else
            {
                students.Add(1, "Some Value");
            }

            foreach (var key in students.Keys)
            {
                Console.WriteLine($"{students[key]} {key}");
            }


            










            Console.ReadKey();
        }
    }
}
