using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwtFourConnectCore.Factory
{

    public interface IBoardFactory
    {
        public IBoard CreateBoard();
    }

    public class BoardFactory : IBoardFactory
    {
        public IBoard CreateBoard()
        {
            throw new NotImplementedException();
        }
    }
}
