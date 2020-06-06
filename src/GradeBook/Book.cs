using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book : NamedClass, IBook
    {
        List<double> grades = new List<double>();
        public delegate void Logger(string s);

        public Book(string name = "Default") : base(name)
        {
        }

        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
                Logger log = MessageLogger;
                log("Grade Added Succcessfully : " + grade);
            }
            else
            {
                throw new ArgumentException("Grade should be between 0 and 100, including said numbers.");
            }
        }

        public double getHighestGrade()
        {
            double highestGrade = 0;
            if (grades.Count > 0)
            {
                grades.ForEach(grade =>
                {
                    if (highestGrade < grade)
                    {
                        highestGrade = grade;
                    }
                });
                return highestGrade;
            }
            else
            {
                Console.WriteLine("Empty grade list.");
                return 0;
            }
        }

        public double getLowestGrade()
        {
            double lowestGrade = 100;
            if (grades.Count > 0)
            {
                grades.ForEach(grade =>
                {
                    if (lowestGrade > grade)
                    {
                        lowestGrade = grade;
                    }
                });
                return lowestGrade;
            }
            else
            {
                Console.WriteLine("Empty grade list.");
                return 0;
            }
        }

        public double getAverageGrade()
        {
            double avg = 0.0;
            if (grades.Count > 0)
            {
                grades.ForEach(grade =>
                {
                    avg += grade;
                });
                return avg = avg / grades.Count;
            }
            else
            {
                Console.WriteLine("Empty grade list.");
                return 0;
            }
        }

        public int numberOfGrades()
        {
            return grades.Count;
        }

        private void MessageLogger(string s)
        {
            Console.WriteLine(s);
        }
    }
}
