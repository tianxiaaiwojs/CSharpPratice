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


        }
    }
}
