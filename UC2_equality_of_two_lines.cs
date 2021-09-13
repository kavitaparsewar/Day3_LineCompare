using System;
using System.Collections.Generic;
using System.Text;

namespace Day3_LineCompare
{
    class UC2_equality_of_two_lines
    {
        public static void equalityoftwolines()
        {
            Console.WriteLine("Enter Coordinates for First Line1 ");
            Console.WriteLine("Enter Coordinates for first point as X & Y");
            int pointX1L1 = Convert.ToInt32(Console.ReadLine());
            int pointY1L1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Coordinates for second point as X & Y");
            int pointX2L1 = Convert.ToInt32(Console.ReadLine());
            int pointY2L1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Coordinates for Second Line2 ");
            Console.WriteLine("Enter Coordinates for first point as a1 & b1");
            int pointa1L2 = Convert.ToInt32(Console.ReadLine());
            int pointb1L2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Coordinates for second point as a2 & b2");
            int pointa2L2 = Convert.ToInt32(Console.ReadLine());
            int pointb2L2 = Convert.ToInt32(Console.ReadLine());

            double lengthOfL1 = Math.Sqrt((Math.Pow((pointX2L1 - pointX1L1), 2) + Math.Pow((pointY2L1 - pointY1L1), 2)));
            Console.WriteLine("Length of Line1 as per given points is: " + lengthOfL1);
            string lengthOfLineOne = Convert.ToString(lengthOfL1);

            double lengthOfL2 = Math.Sqrt((Math.Pow((pointa2L2 - pointa1L2), 2) + Math.Pow((pointb2L2 - pointb1L2), 2)));
            Console.WriteLine("Length of Line2 as per provided points is: " + lengthOfL2);
            string lengthOfLineTwo = Convert.ToString(lengthOfL2);
            //converting data type of variable from double to String so that we can compare using EQUAL function

       
            if (lengthOfLineOne.Equals(lengthOfLineTwo))
                Console.WriteLine("Both lines are equal in length");
            else
                Console.WriteLine("lines are not equal in length");
        }

        }
}
