using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Adapter.I
{
    public class SquareToCircleAdapter : ICircle
    {
        private Square Square { get; }

        public SquareToCircleAdapter(Square square)
        {
            Square = square;
        }

        public double R => Square.A * Math.Sqrt(2) / 2.0;
    }
}
