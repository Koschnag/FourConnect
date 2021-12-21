using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwtFourConnectCore.Factory
{
    public interface IChipFactory
    {
        Chip CreateChip(Color color);        
    }

    public class ChipFactory : IChipFactory
    {
        public Chip CreateChip(Color color)
        {
            return new Chip(color);
        }
    }

}
