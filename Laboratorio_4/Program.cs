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
    public interface IPaymentProcessor
    {
        void GetClientData();
        void Charge();
        

    }

    public class BankApiAdapter : IPaymentProcessor
    {
        private BankApi _bankApi;
        public BankApiAdapter(BankApi bankApi)
        {
            this._bankApi = bankApi;
        }
        public void Charge()
        {
            this._bankApi.Charge();
        }

        public void GetClientData()
        {
            this._bankApi.GetClientInformation();
        }

       
    }

    public class PayPalApiAdapter : IPaymentProcessor
    {
        private PayPalApi _payPalApi;
        public PayPalApiAdapter(PayPalApi payPalApi)
        {
            this._payPalApi = payPalApi;
        }
        public void Charge()
        {
            this._payPalApi.Pay();
        }
        public void GetClientData()
        {
            this._payPalApi.GetClientData();
        }

           
    }
    public class PayPalApi 
    {
        
        public void GetClientData()
        {
            Console.WriteLine("Obtniendo Informacion cliente de PayPal");
        }

        public void Pay()
        {
            Console.WriteLine("Cobrando al cliente PayPal");
        }
       

    }
    public class BankApi
    {
       

        public void GetClientInformation()
        {
            Console.WriteLine("Obtniendo Informacion del cliente");
        }

        public void Charge()
        {
            Console.WriteLine("Cobrando al cliente ");
        }


    }
   
    public class Store
    {
        private IPaymentProcessor _api;

        public Store(IPaymentProcessor api)
        {
            this._api = api;
        }

        public void Process()
        {

            this._api.GetClientData();
            this._api.Charge();

        }
    }

}
