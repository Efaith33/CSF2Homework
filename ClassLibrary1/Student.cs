using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {
        //frugal / fields
        private string _firstName;
        private string _lastName;

        //people / properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        //collect / constructors
        public Student() { }//empty Object(Default)
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //money / methods
        public override string ToString()
        {
            return string.Format("{0} {1}" , FirstName, LastName);
        }
    }
}
