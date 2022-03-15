using System;
using TankTruck.App;
using Xunit;

namespace TankTruck.Test
{
    public class VolumeOfTankTest
    {
        [Theory]
        [InlineData(40, 120, 3500, 1021)]
        [InlineData(5, 7, 3848, 2940)]        
        [InlineData(2, 7, 3848, 907)]

        public void VolTankTest(int h, int d, int vt, int expected)
        {
            //Arrange
            IVolumeOfTank volume = new VolumeOfTank();

            //Act
            var actual = volume.TankVol(h, d, vt);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
