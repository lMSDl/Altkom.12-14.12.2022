using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.PrivateClassData
{
    internal class ClassData
    {

        private readonly int _intValue;
        private string _stringValue;

        public ClassData(int intValue, string stringValue)
        {
            _intValue = intValue;
            _stringValue = stringValue;
        }

        public void DoSth()
        {
            _intValue = 2;

            _stringValue = "";
        }

    }
}
