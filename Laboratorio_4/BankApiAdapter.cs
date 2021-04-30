using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_4
{
    public class BankApiAdapter : IPaymentProcessor
    {
        private BankApi _bankApi;
        public BankApiAdapter(BankApi bankApi)
        {
            this._bankApi = bankApi;
        }
        public void Charge()
        {
            this._bankApi.ChargeClient();
        }

        public void GetClientData()
        {
            this._bankApi.GetClientInformation();
        }


    }
}
