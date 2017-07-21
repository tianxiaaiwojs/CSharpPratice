using SixCharpterArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPratice
{
    class Program
    {
        static void Main(string[] args)
        {
            var createArrayInstance = new CreateArray();
            createArrayInstance.SortPerson();
            Console.WriteLine();
            createArrayInstance.EnumerateHelloWorld();
            Console.ReadLine();
        }
    }
}
