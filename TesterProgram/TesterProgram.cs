using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace TesterProgram
{
    class TesterProgram
    {
        static void Main(string[] args)
        {
            
            Student s1 = new Student();
            s1.FirstName = "Loyd";
            s1.LastName = "Christmas";
            Console.WriteLine(s1);

            Student s2 = new Student("Harry" ,"Dunne");
            Console.WriteLine(s2);
        }
    }
}
