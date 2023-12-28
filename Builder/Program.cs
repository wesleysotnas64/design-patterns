using Builder.BuilderController;
using Builder.Interfaces;

Director director = new Director();
IBuilder builder = new ConcreteBuilder();

director.Builder = builder;

Console.WriteLine("Pizza 4 Queijos:");
director.BuildFourCheeses();
builder.GetPizza().Resume();

Console.WriteLine("Pizza de Frango com Catupiry:");
director.BuildChickenWithCatupiry();
builder.GetPizza().Resume();

//Possível usar também apenas o builder
Console.WriteLine("Pizza de Personalizada:");
builder.BuildWhiteSouce();
builder.BuildMozzarella();
builder.BuildTomato();
builder.BuildBasil();
builder.BuildOlive();
builder.GetPizza().Resume();