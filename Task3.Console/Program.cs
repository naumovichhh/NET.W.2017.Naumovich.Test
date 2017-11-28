using Task3.Solution;

namespace Task3.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock();
            var broker = new Broker("Виталий", stock);
            var broker2 = new Broker("Юлия", stock);
            var bank = new Bank("БПС-Сбербанк", stock);
            stock.Market();
            broker.StopTrade();
            stock.Market();
            System.Console.ReadLine();
        }
    }
}
