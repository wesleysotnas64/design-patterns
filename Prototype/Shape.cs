
namespace Prototype
{
    // Classe base para formas geométricas
    public abstract class Shape : IShapePrototype
    {
        public int X { get; set; }
        public int Y { get; set; }

        public abstract void Draw();

        // Método de clonagem
        public virtual IShapePrototype Clone()
        {
            return (IShapePrototype)this.MemberwiseClone();
        }
    }
}
