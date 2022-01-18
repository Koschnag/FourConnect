namespace SwtFourConnectCore
{
    public interface IBoard
    {
        void DropChip(int colNumber);
        bool CheckWin(IPlayer player);
        void Reset();
    }
    public interface ILine:IList<ICell>
    {
        public bool CheckWin(IPlayer player, int connectionLength); 
    }
    public interface IReceiveChip
    {
        public void ReceiveChip(IChip chip);
    }
    public class Board : IBoard
    {
        List<Column> Cells { get; set; }
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

    public class Column : List<ICell>, ILine, IReceiveChip
    {
        int maxCapacity { get; set; }
        public bool CheckWin(IPlayer player, int connectionLength)
        {
            int longestConnection = 0;
            //vertical
            foreach(var i in this)
            {
                if (i.Chip.Color == player.Color)
                {
                    longestConnection++;
                }
                else
                {
                    longestConnection=0;
                }

                if (longestConnection == connectionLength)
                {
                    return true;
                }
            }

            //horicontal
            for(int i = 0; i < this.Count; i++)
            {

            }

            return false;
        }

        public void ReceiveChip(IChip chip)
        {
            if (this.Count >= maxCapacity)
            {
                throw new InvalidOperationException("You cannot set a chip when all cells in this column already have a chip.");
            }
            foreach(var i in this)
            {
                if (i.Chip == null)
                {
                    i.Chip=chip;
                }
            }
        }
    }

}