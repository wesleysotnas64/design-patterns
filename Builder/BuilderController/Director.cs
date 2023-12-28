
using Builder.Interfaces;

namespace Builder.BuilderController
{
    public class Director
    {
        private IBuilder builder;

        public IBuilder Builder
        {
            set { builder = value; }
        }

        public void BuildMargherita()
        {
            this.builder.BuildTomatoSouce();
            this.builder.BuildMozzarella();
            this.builder.BuildBasil();
        }

        public void BuildFourCheeses()
        {
            this.builder.BuildWhiteSouce();
            this.builder.BuildMozzarella();
            this.builder.BuildParmesan();
            this.builder.BuildGorgonzola();
            this.builder.BuildProvolone();
        }

        public void BuildPepperoni()
        {
            this.builder.BuildTomatoSouce();
            this.builder.BuildMozzarella();
            this.builder.BuildPepperoni();
        }

        public void BuildChickenWithCatupiry()
        {
            this.builder.BuildTomatoSouce();
            this.builder.BuildChicken();
            this.builder.BuildCatupiry();
            this.builder.BuildCorn();
            this.builder.BuildOlive();
        }
    }
}
