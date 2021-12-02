using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {
        //frugal / fields;
        private string _firstName;
        private string _lastName;
        private string _id;
        private double _gpa;

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

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public double GPA
        {
            get { return _gpa; }
            set { _gpa = (value <= 0 && value <= 4 ? value : 0); }
        }
        //collect / constructors
        public Student() { }//empty Object(Default)
        public Student(string firstName, string lastName, string id, double gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            GPA = gpa;
        }//FQCTOR

        //money / methods
        public override string ToString()
        {
            return string.Format("{0} {1}\n" + "{3}\n" + "{4}", FirstName, LastName, ID, GPA);
        }
    }
}
