using System;

namespace Pr1
{
    class Task2:ITask
    {
        public void TaskX()
        {
            DetermineTypeOfTriangle(first_side: 3, second_side: 4, third_side: 5);
            Console.WriteLine(CountPerimeter(first_side: 3, second_side: 4, third_side: 5));
            Console.WriteLine(CountSquare(first_side: 3, second_side: 4, third_side: 5));
        }
        static private bool TriangleExist(double first_side, double second_side, double third_side)
        {
            //correct data input
            if(first_side > 0 && second_side > 0 && third_side > 0)
            {
                //correct input sides of triangle 
                if (first_side + second_side > third_side &&
                first_side + third_side > second_side &&
                second_side + third_side > first_side)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }

        static public void DetermineTypeOfTriangle(double first_side, double second_side, double third_side) 
        {
            
            if (TriangleExist(first_side, second_side, third_side))
            {
                if (first_side == second_side && first_side == third_side)
                {
                    Console.WriteLine("The triangle is equilateral!");//рівносторонній
                }
                else if (first_side == second_side || first_side == third_side || second_side == third_side)
                {
                    Console.WriteLine("The triangle is isosceles!");//рівнобедренний
                }                
                else
                {
                    Console.WriteLine("The triangle have all sides of different lengths!");//різносторонній 
                }
            }
            else
            {
                Console.WriteLine("Incorrect data input or this triangle desn't exist ");
            }
        }

        static public double CountPerimeter(double first_side, double second_side, double third_side)
        {
            if (TriangleExist(first_side, second_side, third_side))
            {
                return first_side + second_side + third_side;
            }
            else
            {
                Console.WriteLine("Incorrect data input or this triangle desn't exist ");
                return -1;
            }
           
        }

        static public double CountSquare(double first_side, double second_side, double third_side)
        {
            if (TriangleExist(first_side, second_side, third_side))
            {
                double p = CountPerimeter(first_side, second_side, third_side) / 2;
                return Math.Sqrt(p * (p - first_side) * (p - second_side) * (p - third_side));
            }
            else
            {
                Console.WriteLine("Incorrect data input or this triangle desn't exist ");
                return -1;
            }
            
        }
    }
}
