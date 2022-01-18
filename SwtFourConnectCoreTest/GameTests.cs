using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwtFourConnectCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwtFourConnectCoreTest
{
    [TestClass]
    public class GameTests
    {

        [TestMethod]
        public void CreateGameWithNPlayer()
        {
            IList<IPlayer> playerList = new List<IPlayer>
            {
            new PlayerDummy(),
            new PlayerDummy()
            };

            Game game = new Game(playerList);
            Assert.AreEqual(2, game.Players.Count);
        }
    }

    public class PlayerDummy : IPlayer
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Color Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IList<IChip> Chips => throw new NotImplementedException();

        public void DropChip()
        {
            throw new NotImplementedException();
        }
    }

}
