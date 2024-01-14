using FactoryMethod.Interfaces;

namespace FactoryMethod.Classes
{
    class SeaLogistic : Logistic
    {
        public SeaLogistic()
        {
            NameLogistc = "Logística Marítma";
        }
        public override ITransport FactoryMethod()
        {
            return new Ship();
        }
    }
}
