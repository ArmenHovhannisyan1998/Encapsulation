using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encopsulation
{
    class Myclass
    {
        Myclass my = null;
        private void Method()
        {
            Console.WriteLine("Hello C#");
        }

        public void CallMethod()
        {
            my = new Myclass();
            my.Method();
        }
    }
}
