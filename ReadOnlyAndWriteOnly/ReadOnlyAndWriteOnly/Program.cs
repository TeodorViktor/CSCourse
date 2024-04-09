using ReadOnlyAndWriteOnly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyAndWriteOnly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car();
            audi.Name = "BMW";
            audi.Details();
            Console.ReadKey();
        }
    }
}