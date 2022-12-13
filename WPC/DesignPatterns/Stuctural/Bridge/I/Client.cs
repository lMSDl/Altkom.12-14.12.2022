using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WPC.DesignPatterns.Creational.Singleton;

namespace WPC.DesignPatterns.Stuctural.Bridge.I
{
    public class Client
    {
        public static void Execute()
        {
            Shape shape = new Square();
            Console.WriteLine(shape);
            Color color = new Red();
            Console.WriteLine(color);

            shape.Color = color;
            Console.WriteLine(shape);
        }
    }
}
