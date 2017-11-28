using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public delegate void Notify(object sender, StockInfoEventArgs args);

    public class Stock : IObservable
    {
        private StockInfo stocksInfo;

        public event Notify Notification;

        public Stock()
        {
            stocksInfo = new StockInfo();
        }

        public void Register(IObserver observer)
        {
            Notification += observer.Update;
        }

        public void Unregister(IObserver observer)
        {
            Notification -= observer.Update;
        }

        public void Notify()
        {
            Notification(this, new StockInfoEventArgs(stocksInfo));
        }

        public void Market()
        {
            Random rnd = new Random();
            stocksInfo.USD = rnd.Next(20, 40);
            stocksInfo.Euro = rnd.Next(30, 50);
            Notify();
        }
    }
}
