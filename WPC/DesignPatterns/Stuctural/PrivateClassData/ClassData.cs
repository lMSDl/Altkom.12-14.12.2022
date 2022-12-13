using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.PrivateClassData
{
    internal class ClassData
    {

/*        private int _intValue;
        private string _stringValue;*/
        private PrivateClassData _privateClassData;

        public ClassData(int intValue, string stringValue)
        {
            _privateClassData = new PrivateClassData(intValue, stringValue);
            /*_intValue = intValue;
            _stringValue = stringValue;*/
        }

        public void DoSth()
        {
            /*_intValue = 2;
            _stringValue = "";*/

            _privateClassData.GetStringValue();
        }

    }
}
