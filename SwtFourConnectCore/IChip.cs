using System.Drawing;

namespace SwtFourConnectCore
{
    public interface IChip
    {
        Color Color { get; set; }
    }

    public class Chip : IChip
    {
        public Chip(Color color)
        {
            Color = color;
        }
        public Color Color { get; set; }
    }
}
