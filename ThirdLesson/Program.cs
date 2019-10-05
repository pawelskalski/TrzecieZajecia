using System;
using System.Collections.Generic;
using System.Linq;
using static ThirdLesson.functions;

namespace ThirdLesson
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine(studentAverage(createGradesList()));
        }
    }
}