using System;
using System.Collections.Generic;
using System.Text;

namespace Puente
{
    class ProcesadorBarco : IProcesadorEnvio
    {
        public void EntregarPedidos()
        {
            Console.WriteLine("entregado por barco");
        }

        public void EnviarPedidos()
        {
            Console.WriteLine("enviado por barco");
        }

        public void RecogerPedidos()
        {
            Console.WriteLine("recogido por barco");
        }
    }
}
