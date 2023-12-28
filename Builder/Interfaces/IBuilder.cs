
using Builder.Classes;

namespace Builder.Interfaces
{
    public interface IBuilder
    {
        //Molho
        void BuildTomatoSouce();
        void BuildWhiteSouce();

        //Principal
        void BuildPepperoni();
        void BuildChicken();

        //Queijos
        void BuildGorgonzola();
        void BuildProvolone();
        void BuildParmesan();
        void BuildCatupiry();
        void BuildMozzarella();

        //Adicionais
        void BuildOlive();
        void BuildCorn();
        void BuildTomato();
        void BuildBasil();

        Pizza GetPizza();
    }
}
