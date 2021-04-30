using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_4
{
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
