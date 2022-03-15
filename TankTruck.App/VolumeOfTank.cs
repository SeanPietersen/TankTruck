using System;

namespace TankTruck.App
{
    public class VolumeOfTank : IVolumeOfTank
    {
        public int TankVol(int h, int d, int vt)
        {
            double radius = (double) d / 2;
            double heightOfTriangle = radius - h;
            double angle = (Math.Acos(heightOfTriangle/ radius));

            double baseOfTriangle = 2 *  heightOfTriangle * Math.Tan(angle);

            double areaOfTriangle = 0.5 * baseOfTriangle * heightOfTriangle;

            double areaOfSector = radius * radius * angle;

            double areaOfFuel = areaOfSector - areaOfTriangle;

            double lengthOfCylinder = vt / (Math.PI * radius * radius);

            double volumeOfFuel = Math.Floor(areaOfFuel * lengthOfCylinder);

            return Convert.ToInt32(volumeOfFuel);
        }
    }
}
