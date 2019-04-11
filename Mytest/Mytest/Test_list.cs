using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mytest
{
    class Test_list
    {
        List<string> f = new List<string>();

        public Test_list()
        {

        }

        public List<string> SList(ref List<string> Temp)
        {
            f = Temp;
            return f;
        }

        public List<string> SListReturn()
        {

            return f;
        }
    }
}
