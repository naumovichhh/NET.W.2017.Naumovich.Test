using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public class StockInfoEventArgs : EventArgs
    {
        public StockInfo Info
        {
            get;
        }

        public StockInfoEventArgs(StockInfo info)
        {
            Info = info;
        }
    }
}
