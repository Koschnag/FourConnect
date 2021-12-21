using System.Drawing;

namespace SwtFourConnectCore
{
    public interface IPlayer
    {
        string Name { get; set; }
        Color Color { get; set; }
        IList<IChip> Chips { get; }
        public void DropChip();
    }

    public class Player : IPlayer
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public IList<IChip> Chips { get;}

        public Player(string name, Color color, IList<IChip> chips)
        {
            this.Name = name;
            this.Color = color;
            this.Chips = chips;
        }

        public void DropChip()
        {
            Chips.RemoveAt(Chips.Count-1);
        }
    }
}
