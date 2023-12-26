using Design_Patterns;

Singleton instance1 = Singleton.Instance;
Singleton instance2 = Singleton.Instance;

instance1.AddCard(new Card(1, "Goblin Sorrateiro", 3, 1));
instance1.AddCard(new Card(2, "Dragão Flamejante", 6, 5));
instance2.AddCard(new Card(3, "Encantamento de Cura", 2, 0));
instance2.AddCard(new Card(4, "Contrafeitiço Espelhado", 1, 0));
instance2.AddCard(new Card(5, "Território da Floresta", 0, 0));

instance1.ShowCards();

instance2.RmvCard(new Card(1, "Goblin Sorrateiro", 3, 1));

instance2.ShowCards();