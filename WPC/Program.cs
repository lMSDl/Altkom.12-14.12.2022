using WPC.DesignPatterns.Creational.AbstractFactory;
using WPC.SOLID.L;


Client.Execute();




void ShowArea(Rectangle rectangle)
{
    Console.WriteLine(rectangle.Area);
}

static void SetupRectangle(Rectangle rectangle, int a, int b)
{
    rectangle.A = a;
    rectangle.B = b;
}

void LSP()
{
    var rectangle = new Square();
    int a = 3;
    int b = 5;
    SetupRectangle(rectangle, a, b);


    Console.WriteLine($"{a} * {b} =");
    ShowArea(rectangle);
}