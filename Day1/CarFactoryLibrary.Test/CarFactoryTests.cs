using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary.Test
{
    public class CarFactoryTests
    {
        [Fact]
        public void NewCar_AskforAudi_Null()
        {
            // Act
            var result = CarFactory.NewCar(CarTypes.Audi);
            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void NewCar_AskforHonda_Exception()
        {
            // Assert
            Assert.Throws<NotImplementedException>(() =>
            {
                // Act
                Car? car = CarFactory.NewCar(CarTypes.Honda);
            });
        }
    }
}
