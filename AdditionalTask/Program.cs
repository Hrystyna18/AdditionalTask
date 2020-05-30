using AdditionalTask;
using System;
using System.Linq;

namespace AdditionaTask
{
    class Program
    {
        static void Main()
        {
            Picture picture = new Picture();
            picture.arrClasses.Add(new Equilateral(10, 5, 15));
            picture.arrClasses.Add(new Equilateral(8, 2, 13));
            picture.arrClasses.Add(new Isosceles(15, 5, 14));
            picture.arrClasses.Add(new Isosceles(9, 8, 2));
            picture.arrClasses.Add(new Rectangular(20, 30, 15));
            picture.arrClasses.Add(new Rectangular(24, 36, 19));

            foreach (var p in picture.arrClasses)
                Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}