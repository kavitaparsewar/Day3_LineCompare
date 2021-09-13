using System;
using System.Collections.Generic;
using System.Text;

namespace Day3_LineCompare
{
    class UC1_Calculate_length
    {
        public static void CalculateLength()
        {
            int X1, X2, Y1, Y2;

            Console.WriteLine("Enter Coordinates for first point X1 & Y1");
            X1 = Convert.ToInt32(Console.ReadLine());
            Y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Coordinates for second point X2 & Y2");
            X2 = Convert.ToInt32(Console.ReadLine());
            Y2 = Convert.ToInt32(Console.ReadLine());

            double lengthOfLine =Math.Sqrt((Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2)));

            Console.WriteLine("Length of Line as per given points : " + lengthOfLine );
        }
    }
}
