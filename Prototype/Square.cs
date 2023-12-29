using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    // Classe derivada - Quadrado
    public class Square : Shape
    {
        public int SideLength { get; set; }

        public override void Draw()
        {
            Console.WriteLine($"Desenhando um quadrado com lado {SideLength} em ({X}, {Y})");
        }

        public override IShapePrototype Clone()
        {
            // Chama a implementação da classe base e ajusta propriedades específicas do quadrado
            return new Square { X = this.X, Y = this.Y, SideLength = this.SideLength };
        }
    }
}
