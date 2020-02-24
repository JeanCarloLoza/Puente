using System;
using System.Collections.Generic;
using System.Text;

namespace Puente
{
    class Fedex : IEmpresa
    {
        IProcesadorEnvio envioBarco = new ProcesadorBarco();

        public void RecogerMar() {
            envioBarco.RecogerPedidos();
        }

        public void EnviarMar() {
            envioBarco.EnviarPedidos();
        }

        public void EntregarrMar() {
            envioBarco.EntregarPedidos();
        }
    }
}
