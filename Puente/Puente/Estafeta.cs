using System;
using System.Collections.Generic;
using System.Text;

namespace Puente
{
    class Estafeta : IEmpresa
    {
        IProcesadorEnvio envioTren = new ProcesadorTren();

        public void RecogerTren()
        {
            envioTren.RecogerPedidos();
        }

        public void EnviarTren()
        {
            envioTren.EnviarPedidos();
        }

        public void EntregarTren()
        {
            envioTren.EntregarPedidos();
        }
    }
}
