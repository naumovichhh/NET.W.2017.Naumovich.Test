using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public class Broker : IObserver
    {
        private IObservable stock;

        public string Name { get; set; }

        public Broker(string name, IObservable observable)
        {
            this.Name = name;
            stock = observable;
            stock.Register(this);
            Console.WriteLine($"Брокер {this.Name} начал торги");
        }

        public void Update(object sender, StockInfoEventArgs args)
        {
            if (args.Info.USD > 30)
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, args.Info.USD);
            else
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, args.Info.USD);
        }

        public void StopTrade()
        {
            Console.WriteLine($"Брокер {this.Name} прекратил торги");
            stock.Unregister(this);
            stock = null;
        }
    }
}
