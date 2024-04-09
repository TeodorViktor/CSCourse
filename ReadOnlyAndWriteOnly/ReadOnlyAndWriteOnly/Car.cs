using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyAndWriteOnly
{
    internal class Car
    {
        private string _name;
        private int _hp;
        public Car() { }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public void Details()
        {
            Console.WriteLine(_name);
        }

    }
}
