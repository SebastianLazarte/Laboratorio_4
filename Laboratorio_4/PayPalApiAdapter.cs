using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_4
{
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
}
