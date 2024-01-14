using FactoryMethod.Interfaces;

namespace FactoryMethod.Classes
{
    public class Ship : ITransport
    {
        public string Operation()
        {
            return "Transporte em container pelo mar.";
        }
    }
}
