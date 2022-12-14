using WPC.DesignPatterns.Behavioral.TemplateMethod;


Client.Execute();




void ShowArea(WPC.SOLID.L.Rectangle rectangle)
{
    Console.WriteLine(rectangle.Area);
}

static void SetupRectangle(WPC.SOLID.L.Rectangle rectangle, int a, int b)
{
    rectangle.A = a;
    rectangle.B = b;
}

void LSP()
{
    var rectangle = new WPC.SOLID.L.Square();
    int a = 3;
    int b = 5;
    SetupRectangle(rectangle, a, b);


    Console.WriteLine($"{a} * {b} =");
    ShowArea(rectangle);
}