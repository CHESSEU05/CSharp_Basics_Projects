using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceAss
{
    internal class Course
    {
        public string CourseCode { get; private set; }
        public string CourseName { get; set; }
        public int CreditValue {  get; set; }
        public string Instructor { get; set; }

        public Course(string courseC, string courseN, int creditV, string instructor )
        {
            CourseCode = courseC;
            CourseName = courseN;
            CreditValue = creditV;
            Instructor = instructor;
            
        }

        public string GetcourseSummary()
        {
            return $"{CourseCode} - {CourseName}";
        }

        // GetCourseSummary

    }
}
