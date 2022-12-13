using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Adapter.I
{
    public class Client
    {
        public static void Execute()
        {
            ICircle circle = new Circle() { R = 5 };
            circle = new SquareToCircleAdapter(new Square() { A = 8  });

            circle = new Square() { A = 8 }.ToCircle();

            CheckR(circle);
        }

        public static void CheckR(ICircle circle)
        {
            Console.WriteLine( circle.R <= 5);
        }
    }
}
