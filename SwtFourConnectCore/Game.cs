namespace SwtFourConnectCore
{
    public class Game : IGame
    {
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
        void Start();
        void Stop();
    }
}