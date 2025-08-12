// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

namespace StudentPerformanceAss
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("*-*-*-*-*- Welcome to the Student Performance Assessment System -*-*-*-*-*");
            int choice;
            List<Student> students = new List<Student>();
            List<Course> courses = new List<Course>();
            List<Result> results = new List<Result>();

            Student Will = new Student("Enow", "William", "FE25A050", 200, 17, 'M', "Computer Engineering");
            Student Jude = new Student("Mvondo", "Jude", "FE25A109", 200, 18, 'M', "Computer Engineering");
            Student Eric = new Student("Awa", "Eric", "FE22A163", 500, 20, 'M', "Computer Engineering");
            Student Milner = new Student("James", "Milner", "FE22A363", 500, 23, 'M', "Electrical & Electronics Engineering");
            Student Sane = new Student("Leroy", "Sane", "FE24A125", 300, 18, 'M', "Mechanical Engineering");
            students.Add(Will);
            students.Add(Jude);
            students.Add(Eric);
            students.Add(Milner);
            students.Add(Sane);

            Course AI_ML = new Course("CEF444", "Artificial Intelligence & Machine Learning", 4, "Dr. SOP Lionel");
            Course Analysis = new Course("CEF201", "Analysis", 3, "Dr. Ngao");
            Course LinearAlg = new Course("CEF205", "Linear Algebra", 4, "Dr. DOR Celestin");
            Course IP_MP = new Course("CEF440", "Internet Programming and Mobile Programming", 3, "Dr. NKEMENI Valery");
            Course DB = new Course("CEF437", "Advanced Databases & Administration", 3, "Dr. KAMDJOU HM");
            courses.Add(AI_ML);
            courses.Add(Analysis);
            courses.Add(LinearAlg);
            courses.Add(IP_MP);
            courses.Add(DB);
            try
            {
                do
                {
                    Console.WriteLine("What do you want to perform in the system ?");
                    Console.WriteLine("1. Enter a student into the system.");

                    Console.WriteLine("2. Enter a course into the system.");
                    Console.WriteLine("3. View the registered students.");
                    Console.WriteLine("4. View the courses in the system.");
                    Console.WriteLine("5. Record result for a student.");
                    Console.WriteLine("6. Assess the performance of a student.");
                    Console.WriteLine("7. View the average score for a course.");
                    Console.WriteLine("8. Exit.");
                    Console.WriteLine("");
                    Console.Write("Enter an operation to perforn from the above list: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter the student first name: ");
                            string FName = Console.ReadLine();
                            Console.Write("Enter the student last name: ");
                            string LName = Console.ReadLine();
                            Console.Write("Enter the student matricule: ");
                            string Matricule = Console.ReadLine();
                            Console.Write("Enter the student level: ");
                            int Level = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the student age (18+): ");
                            int Age = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the student gender ('M' or 'F'): ");
                            char Gender = Convert.ToChar(Console.ReadLine());
                            Console.Write("Enter the student major program: ");
                            string Program = Console.ReadLine();
                            Console.WriteLine("");

                            Student student = new Student(FName, LName, Matricule, Level, Age, Gender, Program);
                            students.Add(student);
                            break;

                        case 2:
                            Console.Write("Enter the course code: ");
                            string courseC = Console.ReadLine();
                            Console.Write("Enter the course name: ");
                            string courseN = Console.ReadLine();
                            Console.Write("Enter the credit value of the course: ");
                            int creditV = Convert.ToInt16(Console.ReadLine());
                            Console.Write("Enter the course instructor: ");
                            string instructor = Console.ReadLine();
                            Console.WriteLine("");

                            Course course = new Course(courseC, courseN, creditV, instructor);
                            courses.Add(course);
                            break;

                        case 3:
                            Console.WriteLine("The students that are registered in the system include: ");
                            for (int i = 0; i < students.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {students[i].GetFullName()} - {students[i].matricule}");
                            }
                            Console.WriteLine("");
                            break;

                        case 4:
                            Console.WriteLine("The courses that are registered in the system required: ");
                            for (int i = 0; i < courses.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {courses[i].CourseCode} - {courses[i].CourseName}");
                            }
                            Console.WriteLine("");
                            break;

                        case 5:
                            for (int i = 0; i < students.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {students[i].GetFullName()} - {students[i].matricule}");
                            }
                            Console.Write($"Select the student index from the list above (1 to {students.Count}): ");
                            int stud = Convert.ToInt32(Console.ReadLine());

                            for (int i = 0; i < courses.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {courses[i].CourseCode} - {courses[i].CourseName}");
                            }
                            Console.Write($"Select the index of the course (1 to {courses.Count}): ");
                            int cour = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter the score of the student: ");
                            double sco = Convert.ToDouble(Console.ReadLine());

                            Result result = new Result(students[stud - 1].matricule, courses[cour - 1].CourseCode, sco);
                            results.Add(result);

                            Console.WriteLine("");
                            break;

                        case 6:
                            for (int i = 0; i < results.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {results[i].Matricule}");
                            }
                            if( results.Count > 0)
                            {
                                Console.Write("Select the index of a student from the above list to assess its performence: ");
                                int ind = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine($"Has the student with matricule, {results[ind - 1].Matricule}: {results[ind - 1].IsPassed()}.");
                                Console.WriteLine($"The student's score corresponds to grade: {results[ind - 1].GetGradeLetter}.");
                                Console.WriteLine($"Remark: {results[ind - 1].Remark()}");
                                Console.WriteLine("");
                            }
                            break;

                        case 7:
                            if (results.Count != 0)
                            {
                                for (int i = 0; i < courses.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {courses[i].CourseCode} - {courses[i].CourseName}");
                                }
                                Console.Write("Select the index of the course you wish to view average score: ");

                                int inc = Convert.ToInt32(Console.ReadLine());
                                string courseid = results[inc - 1].CourseCode;
                                Console.WriteLine(CalculateCourseAverage(results, courseid));

                                for (int i = 0; i < courses.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {courses[i].CourseCode} - {courses[i].CourseName}");
                                }
                                Console.Write($"Select the index of the course to view average grade: ");
                                int cou = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine();
                                double averageMark = results.Average(r => r.Grade);
                            }
                            else
                            {
                                Console.WriteLine("No results registered yet, can't check a course average mark.");
                                Console.WriteLine("");
                                break;
                            }
                            break;

                        case 8:
                            Console.WriteLine("Exiting ...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice");
                            break;


                    }

                } while (choice != 8);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                throw;
            }
        }

        static double CalculateCourseAverage(List<Result> results, string courseId)
        {
            var courseResults = results.Where(r => r.CourseCode == courseId).ToList();

            if (courseResults.Count == 0)
                return 1;

            double sum = courseResults.Sum(r => r.Grade);
            return sum / courseResults.Count;
        }

    }
}