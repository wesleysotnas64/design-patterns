

using FactoryMethod.Interfaces;

namespace FactoryMethod.Classes
{
    class RoadLogistic : Logistic
    {
        public RoadLogistic()
        {
            NameLogistc = "Logística Rodoviária";
        }

        public override ITransport FactoryMethod()
        {
            return new Truck();
        }
    }
}
