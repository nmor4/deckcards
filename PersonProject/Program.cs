using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Tom = new Student( "Tom",20, "A1234");

            Console.WriteLine(Tom.ToString());
        }
    }
}
