using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary.Test
{
    public class CarStoreTests
    {
        [Fact]
        public void AddCars_AddMultipleCars_ListContainsObjects()
        {
            // Arrange
            CarStore carStore = new CarStore();
            Toyota toyota = new Toyota() { velocity = 10, drivingMode = DrivingMode.Forward };
            BMW bmw = new BMW() { velocity = 10, drivingMode = DrivingMode.Forward };

            List<Car> newCars = new List<Car> { toyota, bmw };


            // Act
            carStore.AddCars(newCars);

            // Assert
            Assert.Contains<Car>(toyota, carStore.cars);  
            Assert.Contains<Car>(bmw, carStore.cars);     

            // Using Assert.Collection
            Assert.Collection(carStore.cars,
                car => Assert.Equal(toyota, car),
                car => Assert.Equal(bmw, car)
            );
        }

    }
}
