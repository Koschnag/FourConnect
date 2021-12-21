using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwtFourConnectCore;
using SwtFourConnectCore.Factory;
using System.Collections.Generic;
using System.Drawing;

namespace SwtFourConnectCoreTest
{
    [TestClass]
    public class PlayerTests
    {

        [TestMethod]
        public void CreatePlayer()
        {
            var color = Color.Yellow;
            var Chips = new List<IChip>
                                        {
                                            new Chip(color),
                                            new Chip(color),
                                            new Chip(color)
                                        };

            IPlayerFactory factory = new PlayerFactory();
            var sut = factory.CreatePlayer("Dummy", color, Chips);

            Assert.AreEqual("Dummy", sut.Name);
            Assert.AreEqual(Color.Yellow, sut.Color);
            Assert.AreEqual(3, sut.Chips.Count);
        }


        [TestMethod]
        public void PlayerDropChip()
        {
            var color = Color.Yellow;
            var Chips = new List<IChip>
                                        {
                                            new Chip(color),
                                            new Chip(color),
                                            new Chip(color)
                                        };

            IPlayerFactory factory = new PlayerFactory();
            var sut = factory.CreatePlayer("Dummy", color, Chips);
            sut.DropChip();
            Assert.AreEqual(2, sut.Chips.Count);
        }

    }
}