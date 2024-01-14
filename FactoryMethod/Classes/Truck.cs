using FactoryMethod.Interfaces;

namespace FactoryMethod.Classes
{
    public class Truck : ITransport
    {
        public string Operation()
        {
            return "Transporte em caixas por terra.";
        }
    }
}
