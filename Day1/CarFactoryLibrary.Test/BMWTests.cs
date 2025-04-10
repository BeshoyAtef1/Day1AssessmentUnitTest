using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary.Test
{
    public class BMWTests
    {
        [Fact]
        public void IsStopped_CarVelocity0_TRUE()
        {
            // Arrange
            BMW bmw = new BMW() { velocity = 0, drivingMode = DrivingMode.Stopped };
            // Act
            bool Result = bmw.IsStopped();
            // Assert
            Assert.True(Result);
        }

        [Fact]
        public void IncreaseVelocity_IncreaseVelocity20_20Forward()
        {
            // Arrange
            Car car = new Toyota();
            // Act
            car.IncreaseVelocity(20);
            // Assert
            Assert.Equal(20, car.velocity);
            Assert.Equal(DrivingMode.Forward, car.drivingMode);
        }

        [Fact]
        public void GetDirection_DiectionForward_Backward()
        {
            // Arrange
            BMW bmw = new BMW() { velocity = 5, drivingMode = DrivingMode.Backward };
            // Act
            string Result = bmw.GetDirection();
            //Assert
            Assert.StartsWith("Ba", Result);
   
        }
        [Fact]
        public void TimeToCoverDistance_Velocity10Distance10_Time1()
        {
            // Arrange
            BMW bmw = new BMW() { velocity = 10, drivingMode = DrivingMode.Forward };
            // Act
            double Result = bmw.TimeToCoverDistance(10);
            // Numeric Assert
            Assert.InRange(Result, 0, 2);
            Assert.True(Result <= 2); 
        }

        [Fact]
        public void GetMyCar_AskForCopy_NotSameRefrence()
        {
            // Arrange
            BMW bmw = new BMW() { velocity = 0, drivingMode = DrivingMode.Stopped };
            // Act
            Car newRef = bmw.GetMyCar();
            // Assert
            Assert.NotSame(bmw, newRef);             // ريفرنس مختلف
            Assert.Equal(bmw, newRef);               // نفس القيم
        }

    }
}
