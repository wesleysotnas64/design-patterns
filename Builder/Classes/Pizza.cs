namespace Builder.Classes
{
    public class Pizza
    {
        private List<string> ingredients = new List<string>();

        public void AddIngredient(string ingredient)
        {
            this.ingredients.Add(ingredient);
        }

        public void Resume()
        {

            Console.WriteLine("------------------------------------");

            foreach (string ingredient in ingredients)
            {
                Console.WriteLine("-> " + ingredient);
            }

            Console.WriteLine("------------------------------------");
            Console.WriteLine();

        }
    }
}
