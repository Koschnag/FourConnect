using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwtFourConnectCore.Factory
{
    public interface IGameFactory
    {
        Game CreateGame(IList<IPlayer> players);
    }

    public class GameFactory : IGameFactory
    {
        public Game CreateGame(IList<IPlayer> players)
        {
            return new Game(players);
        }
    }
}
