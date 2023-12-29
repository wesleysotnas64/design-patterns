using Prototype;

// Cria instâncias originais das formas geométricas
Circle originalCircle = new Circle { X = 10, Y = 20, Radius = 5 };
Square originalSquare = new Square { X = 5, Y = 15, SideLength = 8 };

// Cria cópias das formas geométricas usando o padrão Prototype
Circle clonedCircle = (Circle)originalCircle.Clone();
Square clonedSquare = (Square)originalSquare.Clone();

// Modifica as propriedades de uma cópia para demonstrar a independência
clonedCircle.X = 30;
clonedSquare.Y = 25;

// Desenha as formas originais e as cópias
originalCircle.Draw();
clonedCircle.Draw();

originalSquare.Draw();
clonedSquare.Draw();    