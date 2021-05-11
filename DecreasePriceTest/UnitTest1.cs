using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using JackMalone_S00199917;

namespace DecreasePriceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Game game = new Game();
            game.Price = 100m;
            decimal expectadPrice = 50m;

            //Act
            game.DecreasePrice(50m);

            //Assert
            Assert.AreEqual(expectadPrice, game.Price);
        }
    }
}
