using System;
using System.Collections.Generic;
using System.Linq;

namespace ThirdLesson
{
    public class functions
    {
        public static List<double> createGradesList()
        {
            List<double> grades = new List<double>();
            double grade = 0;
            while (grade != -1)
            {
                try
                {
                    grade = Convert.ToDouble(Console.ReadLine());
                    grade = Convert.ToDouble(grade.ToString("0.00")); //2dp Number
                    
                    if (grade > 6)
                    {
                        Console.WriteLine("Ocena nie moze byc wyzsza niz 6");
                        continue;
                    }

                    if (grade < 1 && grade != -1)
                    {
                        Console.WriteLine("Ocena nie może być mniejsza niż 1");
                        continue;
                    }

                    if (grade != -1)
                    {
                        grades.Add(grade);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("To nie jest liczba");
                    continue;
                }
            }

            return grades;
        }

        public static float studentAverage(List<double> grades)
        {
            float average;
            average = (float) grades.Sum() / (float) grades.Count;
            return average;
        }


    }
}