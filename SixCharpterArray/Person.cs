using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixCharpterArray
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this._firstName, this._lastName);
        }
    }

    public enum PersonCompareType
    {
        FirstName,
        LastName
    }

    public class PersonCompare:IComparer<Person>
    {
        private PersonCompareType _compareType;

        public PersonCompare(PersonCompareType compareType)
        {
            this._compareType = compareType;
        }

        public int Compare(Person x, Person y)
        {
            if (x == null && y == null)
            {
                return 0;
            }

            if (x == null)
            {
                return 1;
            }

            if (y == null)
            {
                return -1;
            }
            switch (this._compareType)
            {
                case PersonCompareType.FirstName:
                    {
                        return string.Compare(x.FirstName, y.FirstName);
                    }
                case PersonCompareType.LastName:
                    {
                        return string.Compare(x.LastName, y.LastName);
                    }
                default:
                    {
                        return 0;
                    }
            }
        }
    }
}
