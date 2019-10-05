using System;
using System.Collections.Generic;
using System.Linq;

namespace ThirdLesson
{
    class Program
    {
        static float studentAverage(List<int> grades)
        {
            float average;
            average = (float) grades.Sum() / (float) grades.Count;
            return average;
        }

        static void Main(string[] args)
        {
            List<int> grades = new List<int>();
            int grade = 0;
            while (grade != -1)
            {
                try
                {
                    grade = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine(studentAverage(grades));
        }
    }
}