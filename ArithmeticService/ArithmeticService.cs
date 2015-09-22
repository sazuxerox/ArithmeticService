using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;

namespace ArithmeticService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Arithmetic" in both code and config file together.
    public class ArithmeticService : IArithmeticService, IModuloService
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public double Division(int a, int b)
        {
            return (a/b);
        }

        public int Modulo(int a, int b)
        {
                return (a % b);
        }
    }
}
