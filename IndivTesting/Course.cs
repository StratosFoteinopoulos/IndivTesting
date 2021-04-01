using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndivTesting
{
    enum CourseNames
    {
        Biology, Agricaltures, Economics, Math, Science, Mech, C, Java, Python, Html, Php
    }
    class Course
    {



        private string title;
        public string Title { get { return title; } set { title = value; } }
        public string stream { get; set; }
        public string type { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }

        public List<Student> Cname = new List<Student>();
        public List<Trainer> TrainerList = new List<Trainer>();
        public List<Assignment> AssignmentList = new List<Assignment>();



        public void AddToCourse(Student student)
        {
            Cname.Add(student);
        }

        public void TrainerAddToCourse(Trainer trainer)
        {
            TrainerList.Add(trainer);
        }

        public Course(string title)

        {
            this.title = title;
        }

        public override string ToString()
        {
            return this.Title;


        }
    }
}
