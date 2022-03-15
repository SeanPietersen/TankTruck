using System;

namespace TankTruck.App
{
    class Program
    {
        static void Main(string[] args)
        {
            float radius = 120 / 2;
            float heightOfTriangle = radius - 40;
            double angleRadians = Math.Acos(radius / heightOfTriangle);
            double angle = (angleRadians * 180) / Math.PI;
        }
    }
}
