using Builder.Classes;
using Builder.Interfaces;

namespace Builder.BuilderController
{
    public class ConcreteBuilder : IBuilder
    {
        private Pizza pizza = new Pizza();

        public ConcreteBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            pizza = new Pizza();
        }

        //Molho
        public void BuildTomatoSouce()
        {
            pizza.AddIngredient("Molho de Tomate");
        }
        public void BuildWhiteSouce()
        {
            pizza.AddIngredient("Molho Branco");
        }

        //Principal
        public void BuildPepperoni()
        {
            pizza.AddIngredient("Pepperoni");
        }
        public void BuildChicken()
        {
            pizza.AddIngredient("Frango");
        }

        //Queijos
        public void BuildGorgonzola()
        {
            pizza.AddIngredient("Gorgonzola");
        }
        public void BuildProvolone()
        {
            pizza.AddIngredient("Provolone");
        }
        public void BuildParmesan()
        {
            pizza.AddIngredient("Parmesão");
        }
        public void BuildCatupiry()
        {
            pizza.AddIngredient("Catupiry");
        }
        public void BuildMozzarella()
        {
            pizza.AddIngredient("Mussarela");
        }

        //Adicionais
        public void BuildOlive()
        {
            pizza.AddIngredient("Azeitona");
        }
        public void BuildCorn()
        {
            pizza.AddIngredient("Milho Verde");
        }
        public void BuildTomato()
        {
            pizza.AddIngredient("Tomate");
        }
        public void BuildBasil()
        {
            pizza.AddIngredient("Manjericão");
        }

        public Pizza GetPizza()
        {
            Pizza returnPizza = pizza;

            Reset();

            return returnPizza;
        }
    }
}
