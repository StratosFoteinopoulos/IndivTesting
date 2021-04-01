using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IndivTesting


{
    class Program
    {


        static void Main(string[] args)
        {
            List<Course> CoursesLibrary = new List<Course>();
            List<Assignment> AssignmentList = new List<Assignment>();
            Random rad = new Random();
            int radcourses;
            string randomcNames;
            List<Course> Cname = new List<Course>();



            // 
            //
            //
            //   NOW ADD COURSES
            //
            //
            //
            //
            //


            Console.WriteLine("Good Day Principal!\nWhat do you want to do today?");
            Console.WriteLine("");
            Console.WriteLine("May i propose to Start with Courses?\n");
            string coursetitle = "";
            Console.WriteLine("\nPlease Press enter to coninue");
            Console.ReadKey();
            Console.Clear();
            //coursetitle = "";
            AddingCourses(CoursesLibrary, rad, out radcourses, out randomcNames, coursetitle, AssignmentList);
           


            MainMenu(CoursesLibrary, rad, AssignmentList);


        }




        private static void MainMenu(List<Course> CoursesLibrary, Random rad, List<Assignment> AssignmentList)
        {

            Console.WriteLine("What do you want to do now?");
            Console.WriteLine("1. Add Students");
            Console.WriteLine("2. Add Trainers");
            Console.WriteLine("3. Add Courses");
            Console.WriteLine("4. Add Assignments");
            Console.WriteLine("5. See inputs");
            switch (Console.ReadLine())
            {
                case "1":
                    AddingStudents(CoursesLibrary, rad, AssignmentList);
                    break;
                case "2":
                    AddingTrainers(CoursesLibrary, rad, AssignmentList);
                    break;
                case "3":

                    int radcourses;
                    string randomcNames;
                    string coursetitle = "";
                    AddingCourses(CoursesLibrary, rad, out radcourses, out randomcNames, coursetitle, AssignmentList);
                    break;
                case "4":
                    Console.WriteLine("Choose Course to add Assignment");
                    int assigncounter = 1;
                    if (CoursesLibrary.Count > 0)
                    {


                        foreach (var item in CoursesLibrary)
                        {
                            Console.WriteLine(assigncounter + ". " + item.ToString());
                            assigncounter++;
                        }
                        switch (Console.ReadLine())
                        {

                            case "1":
                                {

                                    for (int i = 0; i < 2; i++)
                                    {
                                        Assignment assignment = new Assignment();
                                        Console.WriteLine("Enter the Title of the assignment");
                                        assignment.title = Console.ReadLine();
                                        Console.WriteLine("Enter the Sub Date");
                                        bool a = true;
                                        while (a == true)
                                        {
                                            try
                                            {
                                                assignment.subDateTime = DateTime.Parse(Console.ReadLine());
                                                a = false;
                                            }
                                            catch
                                            {
                                                Console.WriteLine("This is not a valid Date,try again");

                                            }
                                        }
                                        CoursesLibrary[0].AssignmentList.Add(assignment);


                                        if (CoursesLibrary[0].Cname.Count > 0)
                                        {
                                            for (int j = 0; j < CoursesLibrary[0].Cname.Count; j++)
                                            {
                                                CoursesLibrary[0].Cname[j].StudentGettingAssignment.Add(assignment);
                                            }

                                        }

                                        //AddingAssignmentToEachStudent(CoursesLibrary, AssignmentList);

                                    }




                                    break;
                                }
                            case "2":
                                {
                                    for (int i = 0; i < 2; i++)
                                    {
                                        Assignment assignment = new Assignment();
                                        Console.WriteLine("Enter the Title of the assignment");
                                        assignment.title = Console.ReadLine();
                                        Console.WriteLine("Enter the Sub Date");
                                        bool a = true;
                                        while (a == true)
                                        {
                                            try
                                            {
                                                assignment.subDateTime = DateTime.Parse(Console.ReadLine());
                                                a = false;
                                            }
                                            catch
                                            {
                                                Console.WriteLine("This is not a valid Date,try again");

                                            }
                                        }
                                        CoursesLibrary[1].AssignmentList.Add(assignment);
                                        if (CoursesLibrary[1].Cname.Count > 0)
                                        {
                                            for (int j = 0; j < CoursesLibrary[1].Cname.Count; j++)
                                            {
                                                CoursesLibrary[1].Cname[j].StudentGettingAssignment.Add(assignment);
                                            }

                                        }
                                        // AddingAssignmentToEachStudent(CoursesLibrary, AssignmentList);
                                    }
                                    break;
                                }
                            case "3":
                                {
                                    for (int i = 0; i < 2; i++)
                                    {
                                        Assignment assignment = new Assignment();
                                        Console.WriteLine("Enter the Title of the assignment");
                                        assignment.title = Console.ReadLine();
                                        Console.WriteLine("Enter the Sub Date");
                                        bool a = true;
                                        while (a == true)
                                        {
                                            try
                                            {
                                                assignment.subDateTime = DateTime.Parse(Console.ReadLine());
                                                a = false;
                                            }
                                            catch
                                            {
                                                Console.WriteLine("This is not a valid Date,try again");

                                            }
                                        }
                                        CoursesLibrary[2].AssignmentList.Add(assignment);
                                        if (CoursesLibrary[2].Cname.Count > 0)
                                        {
                                            for (int j = 0; j < CoursesLibrary[2].Cname.Count; j++)
                                            {
                                                CoursesLibrary[2].Cname[j].StudentGettingAssignment.Add(assignment);
                                            }

                                        }
                                        // AddingAssignmentToEachStudent(CoursesLibrary, AssignmentList);
                                    }
                                }
                                break;
                            case "4":
                                {
                                    for (int i = 0; i < 2; i++)
                                    {
                                        Assignment assignment = new Assignment();
                                        Console.WriteLine("Enter the Title of the assignment");
                                        assignment.title = Console.ReadLine();
                                        Console.WriteLine("Enter the Sub Date");
                                        bool a = true;
                                        while (a == true)
                                        {
                                            try
                                            {
                                                assignment.subDateTime = DateTime.Parse(Console.ReadLine());
                                                a = false;
                                            }
                                            catch
                                            {
                                                Console.WriteLine("This is not a valid Date,try again");

                                            }
                                        }
                                        CoursesLibrary[3].AssignmentList.Add(assignment);
                                        if (CoursesLibrary[3].Cname.Count > 0)
                                        {
                                            for (int j = 0; j < CoursesLibrary[3].Cname.Count; j++)
                                            {
                                                CoursesLibrary[3].Cname[j].StudentGettingAssignment.Add(assignment);
                                            }

                                        }
                                        // AddingAssignmentToEachStudent(CoursesLibrary, AssignmentList);
                                    }
                                }
                                break;
                            case "5":
                                {
                                    
                                    for (int i = 0; i < 2; i++)
                                    {
                                        Assignment assignment = new Assignment();
                                        Console.WriteLine("Enter the Title of the assignment");
                                        assignment.title = Console.ReadLine();
                                        Console.WriteLine("Enter the Sub Date");
                                        bool a = true;
                                        while (a == true)
                                        {
                                            try
                                            {
                                                assignment.subDateTime = DateTime.Parse(Console.ReadLine());
                                                a = false;
                                            }
                                            catch
                                            {
                                                Console.WriteLine("This is not a valid Date,try again");

                                            }
                                        }
                                        CoursesLibrary[4].AssignmentList.Add(assignment);
                                        if (CoursesLibrary[4].Cname.Count > 0)
                                        {
                                            for (int j = 0; j < CoursesLibrary[4].Cname.Count; j++)
                                            {
                                                CoursesLibrary[4].Cname[j].StudentGettingAssignment.Add(assignment);
                                            }

                                        }
                                        // AddingAssignmentToEachStudent(CoursesLibrary, AssignmentList);
                                    }

                                    break;
                                }
                            case "6":
                                {
                                    for (int i = 0; i < 2; i++)
                                    {
                                        Assignment assignment = new Assignment();
                                        Console.WriteLine("Enter the Title of the assignment");
                                        assignment.title = Console.ReadLine();
                                        Console.WriteLine("Enter the Sub Date");
                                        bool a = true;
                                        while (a == true)
                                        {
                                            try
                                            {
                                                assignment.subDateTime = DateTime.Parse(Console.ReadLine());
                                                a = false;
                                            }
                                            catch
                                            {
                                                Console.WriteLine("This is not a valid Date,try again");

                                            }
                                        }
                                        CoursesLibrary[5].AssignmentList.Add(assignment);
                                        if (CoursesLibrary[5].Cname.Count > 0)
                                        {
                                            for (int j = 0; j < CoursesLibrary[5].Cname.Count; j++)
                                            {
                                                CoursesLibrary[5].Cname[j].StudentGettingAssignment.Add(assignment);
                                            }

                                        }
                                        // AddingAssignmentToEachStudent(CoursesLibrary, AssignmentList);
                                    }
                                    break;
                                }
                            case "7":
                                {
                                    for (int i = 0; i < 2; i++)
                                    {
                                        Assignment assignment = new Assignment();
                                        Console.WriteLine("Enter the Title of the assignment");
                                        assignment.title = Console.ReadLine();
                                        Console.WriteLine("Enter the Sub Date");
                                        bool a = true;
                                        while (a == true)
                                        {
                                            try
                                            {
                                                assignment.subDateTime = DateTime.Parse(Console.ReadLine());
                                                a = false;
                                            }
                                            catch
                                            {
                                                Console.WriteLine("This is not a valid Date,try again");

                                            }
                                        }
                                        CoursesLibrary[6].AssignmentList.Add(assignment);
                                        if (CoursesLibrary[6].Cname.Count > 0)
                                        {
                                            for (int j = 0; j < CoursesLibrary[6].Cname.Count; j++)
                                            {
                                                CoursesLibrary[6].Cname[j].StudentGettingAssignment.Add(assignment);
                                            }

                                        }
                                        // AddingAssignmentToEachStudent(CoursesLibrary, AssignmentList);
                                    }
                                }
                                break;
                            case "8":
                                {
                                    for (int i = 0; i < 2; i++)
                                    {
                                        Assignment assignment = new Assignment();
                                        Console.WriteLine("Enter the Title of the assignment");
                                        assignment.title = Console.ReadLine();
                                        Console.WriteLine("Enter the Sub Date");
                                        bool a = true;
                                        while (a == true)
                                        {
                                            try
                                            {
                                                assignment.subDateTime = DateTime.Parse(Console.ReadLine());
                                                a = false;
                                            }
                                            catch
                                            {
                                                Console.WriteLine("This is not a valid Date,try again");

                                            }
                                        }
                                        CoursesLibrary[7].AssignmentList.Add(assignment);
                                        if (CoursesLibrary[7].Cname.Count > 0)
                                        {
                                            for (int j = 0; j < CoursesLibrary[7].Cname.Count; j++)
                                            {
                                                CoursesLibrary[7].Cname[j].StudentGettingAssignment.Add(assignment);
                                            }

                                        }
                                        //AddingAssignmentToEachStudent(CoursesLibrary, AssignmentList);
                                    }

                                }
                                break;




                        }

                    }
                    if (CoursesLibrary.Count == 0)
                    {
                        Console.WriteLine("There are no Courses to Begin With. Please Add some Courses First!");
                    }
                    rad = ReturnToMainMenu(CoursesLibrary, AssignmentList);
                   // DoneMenu(CoursesLibrary, AssignmentList);
                    break;
                case "5":
                    Console.Clear();
                    DoneMenu(CoursesLibrary, AssignmentList);
                    break;
            }
        }

        //private static void AddingAssignmentToEachStudent(List<Course> CoursesLibrary,List<Assignment>AssignmentList)
        //{
        //    for (int k = 0; k < CoursesLibrary.Count; k++)
        //    {
        //        if (CoursesLibrary[k].Cname.Count > 0)
        //        {
        //            for (int j = 0; j < CoursesLibrary[k].Cname.Count; j++)
        //            {
        //                CoursesLibrary[k].Cname[k].StudentGettingAssignment.Add(assignmentent);
        //             }

        //        }
        //    }
        //}


        private static List<Course> AddingCourses(List<Course> CoursesLibrary, Random rad, out int radcourses, out string randomcNames, string coursetitle, List<Assignment> AssignmentList)
        {
            radcourses = 0;
            randomcNames = "";
            coursetitle = "";

            Console.WriteLine("Do you want to enter yourself the Courses?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            switch (Console.ReadLine())
            {
                case "1":

                    while (coursetitle != "exit"||coursetitle!="EXIT"||coursetitle!="Exit")
                    {
                        Console.Clear();
                        Console.WriteLine("Enter Course Title OR Type EXIT to exit");
                        coursetitle = Console.ReadLine();
                        //coursetitle.ToUpper();
                        if (coursetitle == "exit")
                        {
                            break;
                        }

                        Course course = new Course(coursetitle);
                        CoursesLibrary.Add(course);
                        Console.WriteLine($"*\n*\n*\nNew Course {coursetitle} added");
                        Console.ReadKey();

                    }
                    break;
                // break;
                case "2":
                    int coursecount = 1;
                    Console.Clear();
                    Console.WriteLine("Adding 4 New Courses\nPlease Wait.");
                    bool v = true;
                   
                        
                            int Adelay = 2000;
                            Thread.Sleep(Adelay);
                            Console.WriteLine("Done");
                        while (v == true)
                        {
                            try { 
                            //Console.WriteLine("\nPress enter to continue");
                            //Console.ReadKey();
                            for (int i = 0; i < 4; i++)
                            {
                                radcourses = rad.Next(Enum.GetValues(typeof(CourseNames)).Length);
                                randomcNames = Enum.GetName(typeof(CourseNames), radcourses);
                                Course course = new Course(randomcNames);


                                foreach (var item in CoursesLibrary)
                                {
                                    while (course.Title == item.Title)
                                    {
                                        radcourses = rad.Next(Enum.GetValues(typeof(CourseNames)).Length);
                                        randomcNames = Enum.GetName(typeof(CourseNames), radcourses);
                                    }
                                }
                                CoursesLibrary.Add(course);
                            }
                            Console.WriteLine("All Courses added are :");

                            foreach (var item in CoursesLibrary)
                            {
                                Console.Write(coursecount + ". ");
                                Console.WriteLine(item.Title);
                                coursecount++;
                            }
                            v = false;
                        }
                        catch
                        {
                            Console.WriteLine("Something went wrong...Please Try again");
                        }
                    }
                    //Console.WriteLine("Returning to Main Menu\nPress Enter to continue");
                    //Console.ReadKey();
                    //Console.Clear();

                    //   break;





                    break;


            }

            rad = ReturnToMainMenu(CoursesLibrary, AssignmentList);
            return CoursesLibrary;

        }

        private static void AddingTrainers(List<Course> CoursesLibrary, Random rad, List<Assignment> AssignmentList)
        {
            string TrainerName;
            string TrainerLastName;
            int trainerNamerad;
            int trainerLstNamerad;
            int[] countingTrainers = new int[CoursesLibrary.Count]; ;

            Console.WriteLine("Now we Hire Trainers");

            for (int i = 0; i < CoursesLibrary.Count; i++)
            {


                Console.WriteLine($"Do you want to enter yourself the Trainers for {CoursesLibrary[i].ToString()}?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Type exit to close\nPress enter to continue");


                        while (Console.ReadLine() != "exit" && countingTrainers[i] <= 2)
                        {
                            Console.Clear();
                            Trainer trainer = new Trainer();
                            Console.WriteLine("Type Traines's Name");
                            trainer.firstName = Console.ReadLine();
                            Console.WriteLine("Type Trainers's Last Name");
                            trainer.lastName = Console.ReadLine();
                            CoursesLibrary[i].TrainerAddToCourse(trainer);
                            countingTrainers[i]++;
                            Console.WriteLine("Type exit to close\nPress enter to continue");

                        }
                        Console.Clear();
                        Console.WriteLine("You have entered " + countingTrainers[i] + " new Trainers");
                        foreach (var item in CoursesLibrary[i].TrainerList)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case "2":
                        Console.WriteLine($"Adding 2 new Trainers for {CoursesLibrary[i].ToString()} .\nPlease Wait");
                        int Adelay = 2000;
                        Thread.Sleep(Adelay);
                        Console.WriteLine("Done");
                        //Console.WriteLine("Type Yes or End");

                        //string answer = Console.ReadLine();
                        //while (answer != "Yes" && answer != "End")
                        //{
                        //    Console.WriteLine("Invalid Input");
                        //    answer = Console.ReadLine();
                        //}
                        for (int j = 0; j < 2; j++)
                        {
                            RandomGenerateTrainers(rad, out trainerNamerad, out trainerLstNamerad, out TrainerName, out TrainerLastName);
                            Trainer trainer = new Trainer();
                            trainer.firstName = TrainerName;
                            trainer.lastName = TrainerLastName;



                            foreach (var item in CoursesLibrary[i].TrainerList)
                            {
                                while (trainer.firstName == item.firstName || trainer.lastName == item.lastName)
                                {
                                    RandomGenerateTrainers(rad, out trainerNamerad, out trainerLstNamerad, out TrainerName, out TrainerLastName);
                                    trainer.firstName = TrainerName;
                                    trainer.lastName = TrainerLastName;
                                }
                            }




                            CoursesLibrary[i].TrainerAddToCourse(trainer);
                            countingTrainers[i]++;

                        }
                        Console.WriteLine("You have entered " + countingTrainers[i] + " new Trainers");
                        Console.WriteLine(CoursesLibrary[i].ToString() + "\n");
                        foreach (var item in CoursesLibrary[i].TrainerList)
                        {

                            Console.WriteLine(item.ToString());
                        }
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();

                        break;


                }


            }
            if (CoursesLibrary.Count == 0)
            {
                Console.WriteLine("There are no Courses to Begin With. Please Add some Courses First!");
            }
            rad = ReturnToMainMenu(CoursesLibrary, AssignmentList);
           // MainMenu(CoursesLibrary, rad, AssignmentList);
        }

        private static void AddingStudents(List<Course> CoursesLibrary, Random rad, List<Assignment> AssignmentList)
        {
            int enames;
            int elasts;
            string nam;
            string elast;
            int[] countingstudents=new int[CoursesLibrary.Count];

            Console.WriteLine("Now you have to proceed with Students");
            for (int i = 0; i < CoursesLibrary.Count; i++)
            {


                Console.WriteLine($"Do you want to enter yourself the students for {CoursesLibrary[i].ToString()}?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Type exit to close\nPress enter to continue");


                        while (Console.ReadLine() != "exit")
                        {
                            Console.Clear();
                            Student student = new Student();
                            Console.WriteLine("Type Student's Name");
                            student.firstName = Console.ReadLine();
                            Console.WriteLine("Type Student's Last Name");
                            student.lastName = Console.ReadLine();
                            // for (int b = 0; b < CoursesLibrary.Count; b++)
                            // {
                            if (CoursesLibrary[i].AssignmentList.Count > 0)
                            {

                                for (int x = 0; x < CoursesLibrary[i].AssignmentList.Count; x++)
                                {
                                    student.StudentGettingAssignment.Add(CoursesLibrary[i].AssignmentList[x]);

                                }

                            }
                            
                            //  }

                            CoursesLibrary[i].AddToCourse(student);
                            countingstudents[i]++;

                            Console.WriteLine("Type exit to close\nPress enter to continue");

                        }
                        Console.Clear();
                        Console.WriteLine("You have entered " + countingstudents[i] + " new student/s");
                        foreach (var item in CoursesLibrary[i].Cname)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("Adding 10 new students.\nPlease wait");
                        int Adelay = 2000;
                        Thread.Sleep(Adelay);
                        Console.WriteLine("Done");

                        //Console.WriteLine("Type Yes or End");

                        //string answer = Console.ReadLine();
                        //while (answer != "Yes" && answer != "End")
                        //{
                        //    Console.WriteLine("Invalid Input");
                        //    answer = Console.ReadLine();
                        //}
                        for (int j = 0; j < 10; j++)
                        {
                            enames = rad.Next(Enum.GetValues(typeof(Names)).Length);
                            nam = Enum.GetName(typeof(Names), enames);
                            elasts = rad.Next(Enum.GetValues(typeof(LastNames)).Length);
                            elast = Enum.GetName(typeof(LastNames), elasts);
                            Student student = new Student();
                            student.firstName = nam;
                            student.lastName = elast;


                            foreach (var item in CoursesLibrary[i].Cname)
                            {
                                while (student.firstName == item.firstName || student.lastName == item.lastName)
                                {
                                    enames = rad.Next(Enum.GetValues(typeof(Names)).Length);
                                    nam = Enum.GetName(typeof(Names), enames);
                                    elasts = rad.Next(Enum.GetValues(typeof(LastNames)).Length);
                                    elast = Enum.GetName(typeof(LastNames), elasts);
                                    student.firstName = nam;
                                    student.lastName = elast;
                                }
                            }

                            // for (int b = 0; b < CoursesLibrary.Count; b++)
                            // {
                            if (CoursesLibrary[i].AssignmentList.Count > 0)
                            {

                                for (int x = 0; x < CoursesLibrary[i].AssignmentList.Count; x++)
                                {
                                    student.StudentGettingAssignment.Add(CoursesLibrary[i].AssignmentList[x]);

                                }

                            }
                           

                            // }


                            CoursesLibrary[i].AddToCourse(student);
                            countingstudents[i]++;

                        }
                        Console.WriteLine("You have entered " + countingstudents[i] + " new student/s");
                        Console.WriteLine("Course :"+ CoursesLibrary[i].ToString() + "\n");
                        foreach (var item in CoursesLibrary[i].Cname)
                        {

                            Console.WriteLine(item.ToString());
                        }
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                }


            }
            if (CoursesLibrary.Count==0)
            {
                Console.WriteLine("There are no Courses to Begin With. Please Add some Courses First!");
            }
            rad = ReturnToMainMenu(CoursesLibrary, AssignmentList);
        }

        private static void DoneMenu(List<Course> CoursesLibrary, List<Assignment> AssignmentList)
        {
            Console.WriteLine("Here you can see a list of");
            Console.WriteLine("1. Every Student");
            Console.WriteLine("2. Every student per Course");
            Console.WriteLine("3. Every Trainer");
            Console.WriteLine("4. Every Course");
            Console.WriteLine("5. Every Assignment per Course");
            Console.WriteLine("6. Every Assignment per Student");
            Console.WriteLine("7. Give Date");
            Console.WriteLine("8. Exit");
            int newcounter = 1;
            switch (Console.ReadLine())
            {

                case "1":
                    Console.Clear();
                    for (int i = 0; i < CoursesLibrary.Count; i++)
                    {
                        foreach (var item in CoursesLibrary[i].Cname)
                        {
                            Console.WriteLine(item.ToString());
                        }


                    }
                    Random rad = ReturnToMainMenu(CoursesLibrary, AssignmentList);
                    break;
                case "2":
                    Console.Clear();
                    ShowCoursesAndStudents(CoursesLibrary, newcounter, AssignmentList);
                    break;

                case "3":
                    Console.Clear();
                    {
                        for (int i = 0; i < CoursesLibrary.Count; i++)
                        {


                            foreach (var item in CoursesLibrary[i].TrainerList)
                            {
                                Console.WriteLine(item.ToString());
                            }
                        }
                    }
                    rad = ReturnToMainMenu(CoursesLibrary, AssignmentList);
                    break;
                case "4":
                    Console.Clear();
                    foreach (var item in CoursesLibrary)
                    {
                        Console.WriteLine(item.ToString());
                    }

                    rad = ReturnToMainMenu(CoursesLibrary, AssignmentList);
                    break;
                case "5":
                    Console.Clear();
                    for (int i = 0; i < CoursesLibrary.Count; i++)
                    {
                        Console.WriteLine(CoursesLibrary[i].ToString());
                        for (int j = 0; j < CoursesLibrary[i].AssignmentList.Count; j++)
                        {
                            Console.WriteLine(CoursesLibrary[i].AssignmentList[j].ToString());
                        }

                    }
                    DoneMenu(CoursesLibrary, AssignmentList);

                    break;
                case "6":
                    Console.Clear();
                    for (int i = 0; i < CoursesLibrary.Count; i++)
                    {
                        if (CoursesLibrary[i].AssignmentList.Count>0)
                        {


                            Console.WriteLine("For Course " + CoursesLibrary[i].ToString().ToUpper());
                            Console.WriteLine("\n");

                            for (int j = 0; j < CoursesLibrary[i].Cname.Count; j++)
                            {
                                Console.WriteLine("Student : " + CoursesLibrary[i].Cname[j].ToString());
                                for (int k = 0; k < CoursesLibrary[i].Cname[j].StudentGettingAssignment.Count; k++)
                                {
                                    Console.WriteLine(CoursesLibrary[i].Cname[j].StudentGettingAssignment[k].ToString());
                                }
                                Console.WriteLine("\n");
                            }
                            Console.WriteLine("\n");
                        }

                    }
                    //
                    /////////////////////////////////////////////
                    //PROSPAUW                         \\\\/////
                    //              /// /           ///     ///
                    //
                    //

                    break;
                case "7":


                   
                    Console.Clear();
                    Console.WriteLine("Give a date to see which students have to file an assignment");
                    // DateTime dt=DateTime.Parse(Console.ReadLine());
                    DateTime dt = new DateTime();
                    bool a = true;
                    while (a == true)
                    {
                        try
                        {
                             dt = DateTime.Parse(Console.ReadLine());
                            a = false;
                            
                        }
                        catch
                        {
                            Console.WriteLine("This is not a valid Date,try again");

                        }
                    }
                   


                   

                    if (dt.DayOfWeek == DayOfWeek.Monday)
                    {
                        DateTime dt2 = dt.AddDays(4);
                        for (int i = 0; i < CoursesLibrary.Count; i++)
                        {
                            for (int j = 0; j < CoursesLibrary[i].AssignmentList.Count; j++)
                            {
                                if (CoursesLibrary[i].AssignmentList[j].subDateTime < dt2 && CoursesLibrary[i].AssignmentList[j].subDateTime > dt)
                                {
                                    Console.WriteLine($"The assignment is named  {CoursesLibrary[i].AssignmentList[j].ToString().ToUpper()}");
                                    for (int l = 0; l < CoursesLibrary[i].Cname.Count; l++)
                                    {
                                        Console.WriteLine(CoursesLibrary[i].Cname[l].ToString() + " has to File an assignment this week");
                                       
                                    }
                                }
                            }

                        }


                    }
                    else if (dt.DayOfWeek == DayOfWeek.Tuesday)
                    {
                        DateTime dt2 = dt.AddDays(-1);
                        DateTime dt3 = dt.AddDays(+3);
                        for (int i = 0; i < CoursesLibrary.Count; i++)
                        {
                            for (int j = 0; j < CoursesLibrary[i].AssignmentList.Count; j++)
                            {
                                if (CoursesLibrary[i].AssignmentList[j].subDateTime < dt3 && CoursesLibrary[i].AssignmentList[j].subDateTime > dt2)
                                {
                                    Console.WriteLine($"The assignment is named  {CoursesLibrary[i].AssignmentList[j].ToString().ToUpper()}");
                                    for (int l = 0; l < CoursesLibrary[i].Cname.Count; l++)
                                    {
                                        Console.WriteLine(CoursesLibrary[i].Cname[l].ToString() + " has to File an assignment this week");
                                        
                                    }
                                }
                            }

                        }

                    }
                    else if (dt.DayOfWeek == DayOfWeek.Wednesday)
                    {
                        DateTime dt2 = dt.AddDays(-2);
                        DateTime dt3 = dt.AddDays(+2);
                        for (int i = 0; i < CoursesLibrary.Count; i++)
                        {
                            for (int j = 0; j < CoursesLibrary[i].AssignmentList.Count; j++)
                            {
                                if (CoursesLibrary[i].AssignmentList[j].subDateTime < dt3 && CoursesLibrary[i].AssignmentList[j].subDateTime > dt2)
                                {
                                    Console.WriteLine($"The assignment is named  {CoursesLibrary[i].AssignmentList[j].ToString().ToUpper()}");
                                    for (int l = 0; l < CoursesLibrary[i].Cname.Count; l++)
                                    {
                                        Console.WriteLine(CoursesLibrary[i].Cname[l].ToString() + " has to File an assignment this week");
                                       
                                    }
                                }
                            }

                        }
                    }
                    else if (dt.DayOfWeek == DayOfWeek.Thursday)
                    {
                        DateTime dt2 = dt.AddDays(-3);
                        DateTime dt3 = dt.AddDays(+1);
                        for (int i = 0; i < CoursesLibrary.Count; i++)
                        {
                            for (int j = 0; j < CoursesLibrary[i].AssignmentList.Count; j++)
                            {
                                if (CoursesLibrary[i].AssignmentList[j].subDateTime < dt3 && CoursesLibrary[i].AssignmentList[j].subDateTime > dt2)
                                {
                                    Console.WriteLine($"The assignment is named  {CoursesLibrary[i].AssignmentList[j].ToString().ToUpper()}");
                                    for (int l = 0; l < CoursesLibrary[i].Cname.Count; l++)
                                    {
                                        Console.WriteLine(CoursesLibrary[i].Cname[l].ToString() + " has to File an assignment this week");
                                       
                                    }
                                }
                            }

                        }
                    }
                    else if (dt.DayOfWeek == DayOfWeek.Friday)
                    {
                        DateTime dt2 = dt.AddDays(-4);
                        DateTime dt3 = dt;
                        for (int i = 0; i < CoursesLibrary.Count; i++)
                        {
                            for (int j = 0; j < CoursesLibrary[i].AssignmentList.Count; j++)
                            {
                                if (CoursesLibrary[i].AssignmentList[j].subDateTime < dt3 && CoursesLibrary[i].AssignmentList[j].subDateTime > dt2)
                                {
                                    Console.WriteLine($"The assignment is named  {CoursesLibrary[i].AssignmentList[j].ToString().ToUpper()}");
                                    for (int l = 0; l < CoursesLibrary[i].Cname.Count; l++)
                                    {
                                        Console.WriteLine(CoursesLibrary[i].Cname[l].ToString() + " has to File an assignment this week");
                                       
                                    }
                                }
                            }

                        }
                    }
                    else if (dt.DayOfWeek == DayOfWeek.Saturday)
                    {
                        DateTime dt2 = dt.AddDays(-5);
                        DateTime dt3 = dt.AddDays(-1);
                        for (int i = 0; i < CoursesLibrary.Count; i++)
                        {
                            for (int j = 0; j < CoursesLibrary[i].AssignmentList.Count; j++)
                            {
                                if (CoursesLibrary[i].AssignmentList[j].subDateTime < dt3 && CoursesLibrary[i].AssignmentList[j].subDateTime > dt2)
                                {
                                    Console.WriteLine($"The assignment is named  {CoursesLibrary[i].AssignmentList[j].ToString().ToUpper()}");
                                    for (int l = 0; l < CoursesLibrary[i].Cname.Count; l++)
                                    {
                                        Console.WriteLine(CoursesLibrary[i].Cname[l].ToString() + " has to File an assignment this week");
                                       
                                    }
                                }
                            }

                        }
                    }
                    else if (dt.DayOfWeek == DayOfWeek.Sunday)
                    {
                        DateTime dt2 = dt.AddDays(-6);
                        DateTime dt3 = dt.AddDays(-2);
                        for (int i = 0; i < CoursesLibrary.Count; i++)
                        {
                            for (int j = 0; j < CoursesLibrary[i].AssignmentList.Count; j++)
                            {
                                if (CoursesLibrary[i].AssignmentList[j].subDateTime < dt3 && CoursesLibrary[i].AssignmentList[j].subDateTime > dt2)
                                {
                                    Console.WriteLine($"The assignment is named  {CoursesLibrary[i].AssignmentList[j].ToString().ToUpper()}");
                                    for (int l = 0; l < CoursesLibrary[i].Cname.Count; l++)
                                    {
                                        
                                        Console.WriteLine(CoursesLibrary[i].Cname[l].ToString() + " has to File an assignment this week");
                                       
                                    }
                                }
                            }

                        }
                    }
                    Console.Clear();
                    break;
                case "8":
                    Console.Clear();
                    rad = ReturnToMainMenu(CoursesLibrary, AssignmentList);
                    break;
            }


        }

        private static void ShowCoursesAndStudents(List<Course> CoursesLibrary, int newcounter, List<Assignment> AssignmentList)
        {
            Console.WriteLine("Choose Course");
            foreach (var item in CoursesLibrary)
            {
                Console.WriteLine(newcounter + ". " + item.ToString());
                newcounter++;
            }


            switch (Console.ReadLine())
            {
                case "1":

                    foreach (var item in CoursesLibrary[0].Cname)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.ReadKey();
                    Console.Clear();
                    DoneMenu(CoursesLibrary, AssignmentList);
                    break;
                case "2":
                    foreach (var item in CoursesLibrary[1].Cname)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.ReadKey();
                    Console.Clear();
                    DoneMenu(CoursesLibrary, AssignmentList);
                    break;
                case "3":
                    foreach (var item in CoursesLibrary[2].Cname)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.ReadKey();
                    Console.Clear();
                    DoneMenu(CoursesLibrary, AssignmentList);
                    break;
                case "4":

                    foreach (var item in CoursesLibrary[3].Cname)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.ReadKey();
                    Console.Clear();
                    DoneMenu(CoursesLibrary, AssignmentList);
                    break;

            }

        }

        private static Random ReturnToMainMenu(List<Course> CoursesLibrary, List<Assignment> AssignmentList)
        {
            
            Random rad = new Random();
            Console.WriteLine("Returning to Main Menu\nPress Enter");
            Console.ReadKey();
            Console.Clear();
            MainMenu(CoursesLibrary, rad, AssignmentList);
            return rad;
        }

        private static void RandomGenerate(Random rad, out int enames, out int elasts, out string nam, out string elast)
        {
            enames = rad.Next(Enum.GetValues(typeof(Names)).Length);
            nam = Enum.GetName(typeof(Names), enames);
            elasts = rad.Next(Enum.GetValues(typeof(LastNames)).Length);
            elast = Enum.GetName(typeof(LastNames), elasts);
        }
        private static void RandomGenerateTrainers(Random rad, out int trainerNamerad, out int trainerLstNamerad, out string TrainerName, out string TrainerLastName)
        {
            trainerNamerad = rad.Next(Enum.GetValues(typeof(TrainerNames)).Length);
            TrainerName = Enum.GetName(typeof(TrainerNames), trainerNamerad);
            trainerLstNamerad = rad.Next(Enum.GetValues(typeof(TrainerLastNames)).Length);
            TrainerLastName = Enum.GetName(typeof(TrainerLastNames), trainerLstNamerad);
        }




    }
}


