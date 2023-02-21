using System;
using static System.Net.Mime.MediaTypeNames;



namespace LAbor1_OOP_
{
    class Rectangle
    {
        public int x, y;

        public double Perimeter(double a, double b)
        {
            double per = (a + b) * 2;
            return per;
        }
        public double Area(double a, double b)
        {
            double area = a * b;
            return area;
        }
    }


    class Program
    {
       static void Main(string[] args)
        {
            Rectangle A = new Rectangle();
            Console.WriteLine("Enter the first coordinate of the first vertex - ");
            Int32.TryParse(Console.ReadLine(), out A.x);
            Console.WriteLine("Enter the second coordinate of the first vertex - ");
            Int32.TryParse(Console.ReadLine(), out A.y);
            Rectangle B = new Rectangle();
            Console.WriteLine("Enter the first coordinate of the second vertex - ");
            Int32.TryParse(Console.ReadLine(), out B.x);
            Console.WriteLine("Enter the second coordinate of the second vertex - ");
            Int32.TryParse(Console.ReadLine(), out B.y);
            Rectangle C = new Rectangle();
            Console.WriteLine("Enter the first coordinate of the third vertex - ");
            Int32.TryParse(Console.ReadLine(), out C.x);
            Console.WriteLine("Enter the second coordinate of the third vertex - ");
            Int32.TryParse(Console.ReadLine(), out C.y);
            Rectangle D = new Rectangle();
            Console.WriteLine("Enter the first coordinate of the fourth vertex - ");
            Int32.TryParse(Console.ReadLine(), out D.x);
            Console.WriteLine("Enter the second coordinate of the fourth vertex - ");
            Int32.TryParse(Console.ReadLine(), out D.y);


            Console.WriteLine("*****************************************");

            double AB = Math.Sqrt((B.x - A.x) * (B.x - A.x) + (B.y - A.y) * (B.y - A.y));
            double BC = Math.Sqrt((C.x - B.x) * (C.x - B.x) + (C.y - B.y) * (C.y - B.y));
            double CD = Math.Sqrt((D.x - C.x) * (D.x - C.x) + (D.y - C.y) * (D.y - C.y));
            double AD = Math.Sqrt((D.x - A.x) * (D.x - A.x) + (D.y - A.y) * (D.y - A.y));
            Console.WriteLine("AB = " + AB);
            Console.WriteLine("BC = " + BC);
            Console.WriteLine("CD = " + CD);
            Console.WriteLine("AD = " + AD);
            Console.WriteLine("*****************************************");

            if ((AB != CD))
            {
                Console.WriteLine("The resulting figure is not a rectangle");
                return;
            }
            double cosABxBC = ((B.x - A.x)* (C.x - B.x) + (B.y - A.y)* (C.y - B.y))/ (AB * BC);
            if (cosABxBC != 0)
            {
                Console.WriteLine("The resulting figure is not a rectangle");
                return;
            }
            else
            {
                Console.WriteLine("Congratulations!!! It`s a rectangle");
            }

            double area = A.Area(AB, BC);
            double per = A.Perimeter(AB, BC);
            Console.WriteLine("The perimeter of this rectangle is equal - " + per);
            Console.WriteLine("The perimeter of this rectangle is equal - " + area);
            return;
        }
    }
}