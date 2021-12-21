using System.Drawing;

namespace SwtFourConnectCore.Factory
{
    public interface IPlayerFactory
    {
        IPlayer CreatePlayer(string name, Color color,IList<IChip> chips);
    }

    public class PlayerFactory : IPlayerFactory
    {
        public IPlayer CreatePlayer(string name, Color color, IList<IChip> chips)
        {
            return new Player(name, color, chips);
        }
    }

}
