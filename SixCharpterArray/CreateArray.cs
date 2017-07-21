using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixCharpterArray
{
    public class CreateArray
    {
        public void CreateInstance()
        {
            Array intArray = Array.CreateInstance(typeof(int), 5);
            

            int[] intArrayCopy = (int[])intArray;
            int[] lengths = {2,3};
            int[] lowerBound = {1,10};
            var multipleDim = Array.CreateInstance(typeof(int),lengths,lowerBound);
            multipleDim.SetValue(1, 1, 11);
            Console.WriteLine(multipleDim.GetValue(1, 11));

            string[] names = new string[] { 
                "Su Yi","Si Yu", "Bei Bei", "Praveen","Ron", "Win"
            };

            Array.Sort(names);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }

        public void SortPerson()
        {
            Person[] persons = new Person[]{
                new Person("SU Yi", "Thai"),
                new Person("Si Yu", "Fan"),
                new Person("Bei Bei", "Zhu"),
                new Person("Ron","Wijiaya")
            };

            Array.Sort(persons, new PersonCompare(PersonCompareType.FirstName));
            foreach (var item in persons)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
            Array.Sort(persons, new PersonCompare(PersonCompareType.LastName));
            foreach (var item in persons)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void EnumerateHelloWorld()
        {
            var helloWorld = new HelloWorldCollection();
            foreach (var item in helloWorld)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class HelloWorldCollection
    {
        public IEnumerator<string> GetEnumerator()
        {
            yield return "Hello";
            yield return "world";
        }
    }
}
