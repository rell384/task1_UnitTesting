using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mycarFactory_test
{
    public class BMW_test
    {
        [Fact]
        public void IsStopped_velocity0_true()
        {
            // Arrange
            Toyota toyota = new Toyota();
            toyota.velocity = 0;

            // Act
            bool result = toyota.IsStopped();

            // Boolean Asserts
            Assert.True(result);
        }
        
        [Fact]
        public void IncreaseVelocity_valocity10Add30_40()
        {
            // Arrange
            BMW bmw = new BMW();
            bmw.velocity = 10;
            double AddedVelocitoy = 30;

            // Act
            bmw.IncreaseVelocity(AddedVelocitoy);

            // Equality Assert
            Assert.Equal(40, bmw.velocity);
            Assert.NotEqual(10, bmw.velocity);

            // Numeric Asserts
            Assert.False(bmw.velocity < 10);

            Assert.InRange(bmw.velocity, 20, 40);
        }

        [Fact]
        public void GetDirection_DirectionForward_Forward()
        {
            // Arrange
            BMW bmw = new BMW();
            bmw.drivingMode = DrivingMode.Forward;

            // Act
            string result = bmw.GetDirection();

            // string Asserts
            Assert.Equal(DrivingMode.Forward.ToString(), result);

            Assert.StartsWith("F", result);
            Assert.EndsWith("rd", result);

            Assert.Contains("wa", result);
            Assert.DoesNotContain("zx", result);

           
        }

        [Fact]
        public void GetMyCar_callFunction_SameCar()
        {
            // Arrange
            BMW bmw = new BMW();
            BMW b2 = new BMW();

            // Act
            Car car = bmw.GetMyCar();

            // Refrence Assert
            Assert.Same(bmw, car);
        }
    }
}
