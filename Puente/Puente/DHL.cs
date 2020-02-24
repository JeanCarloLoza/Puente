using System;
using System.Collections.Generic;
using System.Text;

namespace Puente
{
    class DHL : IEmpresa
    {
        IProcesadorEnvio envioBarco = new ProcesadorBarco();
        IProcesadorEnvio envioAvion = new ProcesadorAvion();

        public void RecogerMar()
        {
            envioBarco.RecogerPedidos();
        }

        public void EnviarMar()
        {
            envioBarco.EnviarPedidos();
        }

        public void EntregarMar()
        {
            envioBarco.EntregarPedidos();
        }
        public void RecogerAvion()
        {
            envioAvion.RecogerPedidos();
        }
        public void EnviarAvion()
        {
            envioAvion.EnviarPedidos();
        }

        public void EntregarAvion()
        {
            envioAvion.EntregarPedidos();
        }
    }
}
