using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwtFourConnectCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwtFourConnectCoreTest
{
    [TestClass]
    public class BoardTests
    {
        [TestMethod]
        public void CreateBoard()
        {
            IBoard board = new Board();
        }
    }
}
