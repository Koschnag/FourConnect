namespace SwtFourConnectCore
{
    public interface ICell
    {
        public IChip Chip { get; set; }
    }

    public class Cell : ICell
    {
        public IChip Chip { get; set; }
    }

}