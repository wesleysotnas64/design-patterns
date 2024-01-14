
namespace FactoryMethod.Classes
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("Iniciando com Logística marítima...");
            ClientCode(new SeaLogistic());

            Console.WriteLine("");

            Console.WriteLine("Iniciando com Logística rodoviária...");
            ClientCode(new RoadLogistic());
        }

        public void ClientCode(Logistic logistic)
        {
            Console.WriteLine(logistic.SomeOperation());
        }
    }
}
