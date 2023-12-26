using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public class Singleton
    {
        private static Singleton instance = null;
        private List<Card> cards = new List<Card>();

        private Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public void RmvCard(Card card)
        {
            cards.Remove(card);
        }

        public void ShowCards()
        {
            foreach (Card card in cards)
            {
                ShowCard(card);
            }
        }

        private void ShowCard(Card card)
        {
            Console.WriteLine($"Id         : {card.Id}");
            Console.WriteLine($"Nome       : {card.Name}");
            Console.WriteLine($"Poder      : {card.Power}");
            Console.WriteLine($"Resistência: {card.Toughness}");
            Console.WriteLine("-----------------------------");
        }
    }
}
