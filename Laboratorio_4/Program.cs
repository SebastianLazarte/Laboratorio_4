using System;
using System.Collections.Generic;

namespace Laboratorio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor bank = new BankApiAdapter(new BankApi());
            Store clientBank = new Store(bank);
            clientBank.Process(); 

            IPaymentProcessor paypal = new PayPalApiAdapter(new PayPalApi());
            Store clientPayPal = new Store(paypal);
            clientPayPal.Process();
            Console.ReadKey();

        }
    }
}
