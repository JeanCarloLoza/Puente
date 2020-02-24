using System;
using System.Collections.Generic;
using System.Text;

namespace Puente
{
    interface IProcesadorEnvio
    {
        public void RecogerPedidos();
        public void EnviarPedidos();
        public void EntregarPedidos();
    }
}
