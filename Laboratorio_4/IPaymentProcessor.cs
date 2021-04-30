using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_4
{
    public interface IPaymentProcessor
    {
        void GetClientData();
        void Charge();


    }
}
