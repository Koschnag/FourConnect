using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwtFourConnectCore
{
    public interface IPlayer
    {
        string Name { get; set; }
        IColor Color { get; set; }
        IList<IChip> Chips { get; set; }        
        void DropChip(int colNumber);
    }
}
