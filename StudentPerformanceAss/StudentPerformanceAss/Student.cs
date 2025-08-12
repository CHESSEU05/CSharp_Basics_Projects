using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceAss
{
    internal class Student
    {
        public  string firstName {  get; set; }
        public  string lastName { get; set; }
        public string matricule { get; private set; }
        public int level { get; set; }
        public  int age { get; set; }
        public char gender { get; set; }
        public string program { get; set; }
        public List<Result> Results { get; private set;}
        
        public Student(string FName, string LName, string Mat, int Level, int Age, char Gender, string Program)
        {
            firstName = FName;
            lastName = LName;
            matricule = Mat;
            level = Level;
            age = Age;
            gender = Gender;
            program = Program;
            Results = new List<Result>();

        }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

    }
}
