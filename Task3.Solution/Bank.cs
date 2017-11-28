using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public class Bank : IObserver
    {
        public string Name { get; set; }

        public Bank(string name, IObservable observable)
        {
            this.Name = name;
            observable.Register(this);
            Console.WriteLine($"Банк {this.Name} начал торги");
        }

        public void Update(object sender, StockInfoEventArgs args)
        {
            if (args.Info.Euro > 40)
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, args.Info.Euro);
            else
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, args.Info.Euro);
        }
    }
}
