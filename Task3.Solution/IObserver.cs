﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public interface IObserver
    {
        void Update(object sender, StockInfoEventArgs args);
    }
}
