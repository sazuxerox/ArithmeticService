using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ArithmeticService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IArithmetic" in both code and config file together.
    [ServiceContract]
    public interface IArithmeticService
    {
        [OperationContract]
        int Addition(int a, int b);

        [OperationContract]
        int Subtraction(int a, int b);

        [OperationContract]
        int Multiplication(int a, int b);

        [OperationContract]
        double Division(int a, int b);

    }

    [ServiceContract]
    public interface IModuloService
    {
        [OperationContract]
        int Modulo(int a, int b);
    }
}
