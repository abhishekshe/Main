﻿
using System;

namespace LineComparisonProblem
{
    class Program
    {
        //variable declaration
        public static int x1, x2, y1, y2;
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter value for coordinate \"x1\" ");
                x1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter value for coordinate \"y1\" ");
                y1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter value for coordinate \"x2\" ");
                x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter value for coordinate \"y2\" ");
                y2 = Convert.ToInt32(Console.ReadLine());
                //object for created for class FindingLength
                FindingLength obj = new FindingLength();
                obj.LineLength(x1, y1, x2, y2, i);
            }
            CheckEquality obj1 = new CheckEquality();
            obj1.ComputeEquals();


        }
    }
    public class FindingLength
    {
        public void LineLength(int x1, int y1, int x2, int y2, int i)
        {
            //calculating formula for finding length
            double sqrt = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            string val = Convert.ToString(Math.Round(sqrt, 2));
            Console.WriteLine("length of line is:" + val);
            InitializeArray.Data(val, i);


        }
    }
    public class CheckEquality
    {
        public void ComputeEquals()
        {

            if (InitializeArray.values[0].Equals(InitializeArray.values[1]) == true)

            {
                Console.WriteLine(" Both line are same");
            }
            else
            {
                Console.WriteLine("both line is different");
                string comparing = ((InitializeArray.values[0]).CompareTo(InitializeArray.values[1]) > 0) ? "Line 1 is greater than line 2" : "Line 2 is greater than line 1";
                Console.WriteLine(comparing);
            }
        }
    }

    public static class InitializeArray
    {
        public static string[] values = new string[2];
        public static void Data(string val, int index)
        {
            values[index] = val;
        }

    }



}
