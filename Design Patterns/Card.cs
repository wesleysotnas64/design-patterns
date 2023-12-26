
namespace Design_Patterns
{
    public class Card
    {
        public int Id;
        public string Name;
        public int Power;
        public int Toughness;

        public Card(int id, string name, int power, int toughness)
        {
            this.Id = id;
            this.Name = name;
            this.Power = power;
            this.Toughness = toughness;
        }

    }
}
