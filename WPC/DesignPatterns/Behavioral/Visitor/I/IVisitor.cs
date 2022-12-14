using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Visitor.I
{
    internal interface IVisitor
    {
        void Visit(PlainText element);
        void Visit(BoldText element);
        void Visit(Hyperlink element);
    }
}
