using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndivTesting
{

    enum Names
    {
        Stratos, Kostas, Vasilis, Dimitris, Aris
    }
    enum LastNames
    {
        Vasilopoulos, Anagnostou, Kokkinos, Kitrinos, Mauros
    }
    class Student
    {
        private Course _course;



        public string firstName { get; set; }
        public string lastName { get; set; }
        public string dateOfBirth { get; set; }
        public int tuitionFees { get; set; }


        public List<Assignment> StudentGettingAssignment = new List<Assignment>();

        public void IsAttending(Course course)
        {
            _course = course;
            Console.WriteLine($"Student: {firstName} {lastName} is attending {_course.Title}");
        }


        public override string ToString()
        {
            return this.firstName + " " + lastName;


        }

    }
}
