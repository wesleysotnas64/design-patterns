
namespace Prototype
{
    // Classe derivada - Círculo
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override void Draw()
        {
            Console.WriteLine($"Desenhando um círculo com raio {Radius} em ({X}, {Y})");
        }

        public override IShapePrototype Clone()
        {
            // Chama a implementação da classe base e ajusta propriedades específicas do círculo
            return new Circle { X = this.X, Y = this.Y, Radius = this.Radius };
        }
    }
}
