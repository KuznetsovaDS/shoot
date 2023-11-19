using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shootingTime
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("You have 3 attempts to shoot! \n");
            Console.Write("You 1st shot, put x ");
            int firstX = int.Parse(Console.ReadLine());
            Console.Write("You 1st shot, put y ");
            int firstY = int.Parse(Console.ReadLine());
            Console.Write("You 2nd shot, put x ");
            int secondX = int.Parse(Console.ReadLine());
            Console.Write("You 2nd shot, put y ");
            int secondY = int.Parse(Console.ReadLine());
            Console.Write("You 3rd shot, put x ");
            int thirdX = int.Parse(Console.ReadLine());
            Console.Write("You 3rd shot, put y ");
            int thirdY = int.Parse(Console.ReadLine());
                       
            int point1;

            if (Math.Abs(firstX) <= 1 && Math.Abs(firstY) <= 1)
            {
                point1 = 10;
            }
            else if (Math.Abs(firstX) <= 2 && Math.Abs(firstY) <= 2)
            {
                point1 = 5;
            }
            else
            {
                point1 = 0;
            }

            int point2;

            if (Math.Abs(secondX) <= 1 && Math.Abs(secondY) <= 1)
            {
                point2 = 10;
            }
            else if (Math.Abs(secondX) <= 2 && Math.Abs(secondY) <= 2)
            {
                point2 = 5;
            }
            else
            {
                point2 = 0;
            }

            int point3;

            if (Math.Abs(thirdX) <= 1 && Math.Abs(thirdY) <= 1)
            {
                point3 = 10;
            }
            else if (Math.Abs(thirdX) <= 2 && Math.Abs(thirdY) <= 2)
            {
                point3 = 5;
            }
            else
            {
                point3 = 0;
            }
            int sum = point1 + point2 + point3;
            Console.WriteLine("Your result is " + sum);
        }
    }
}
