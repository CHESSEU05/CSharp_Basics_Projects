using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceAss
{
    internal class Result
    {
        public string Matricule;
        public string CourseCode;
        public double Grade;

        public Result(string mat, string course, double grade)
        {
            Matricule = mat;
            CourseCode = course;
            Grade = grade;
        }

        public bool IsPassed()
        {
            if (Grade >= 50)
                return true;
            else 
                return false;
        }

        public string GetGradeLetter()
        {
            if (Grade >= 80 && Grade <= 100)
                return "A";
            else if (Grade >= 70 && Grade <= 79)
                return "B+";
            else if (Grade >= 70 && Grade <= 79)
                return "B";
            else if (Grade >= 60 && Grade <= 69)
                return "C+";
            else if (Grade >= 56 && Grade <= 59)
                return "C";
            else if (Grade >= 50 && Grade <= 55)
                return "D+";
            else if (Grade >= 45 && Grade <= 49)
                return "D";
            else
                return "F";
        }

        public string Remark()
        {
            if (Grade >= 75 && Grade <= 100)
                return "Very Good. Keep up !!!";
            else if (Grade >= 60 && Grade <= 74)
                return "Good. Can do better !!!";
            else if (Grade >= 55 && Grade <= 59)
                return "Fair...";
            else if (Grade >= 50 && Grade <= 54)
                return "Average. More efforts needed";
            else
                return "Poor. Needs special attentions.";
        }

    }
}
