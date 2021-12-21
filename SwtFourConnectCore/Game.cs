namespace SwtFourConnectCore
{
    public class Game : IGame
    {
        public Game(IList<IPlayer> players)
        {
            Players = players;
        }

        public IList<IPlayer> Players { get; set; }
        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
    public interface IGame
    {
        IList<IPlayer> Players { get; set; }
        void Start();
        void Stop();
    }
}