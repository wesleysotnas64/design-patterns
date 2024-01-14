using FactoryMethod.Interfaces;

namespace FactoryMethod.Classes
{
    abstract class Logistic
    {
        public abstract ITransport FactoryMethod();
        public string NameLogistc { get; protected set; }

        public string SomeOperation()
        {
            var transport = FactoryMethod();

            string result = $"{NameLogistc} => {transport.Operation()}";

            return result;
        }
    }
}
