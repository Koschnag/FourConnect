namespace SwtFourConnectCore
{
    public interface IBoard
    {
        void DropChip(int colNumber);
        bool CheckWin(IPlayer player);
        void Reset();
    }

    public class Board : IBoard
    {
        public bool CheckWin(IPlayer player)
        {
            throw new NotImplementedException();
        }

        public void DropChip(int colNumber)
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }


}