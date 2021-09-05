using System;

namespace Veselov_V_O_oop_lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            CPoint cPoint = new CPoint();
            cPoint.setName("myName");
            cPoint.setRadiusA(8);
            cPoint.setRadiusB(5);
            cPoint.setDegree(60);
            cPoint.getSquare();
            cPoint.displayName();
            CGraphicsObject cGraphicsObject = new CPoint();
            cGraphicsObject.setName("name");
            cGraphicsObject.displayName();
            Console.ReadLine();
        }
    }
}
