using System;
using System.Collections.Generic;
using System.Text;

namespace Puente
{
    class ProcesadorAvion : IProcesadorEnvio
    {
        public void EntregarPedidos()
        {
            Console.WriteLine("entregado por avion");
        }

        public void EnviarPedidos()
        {
            Console.WriteLine("enviado por avion");
        }

        public void RecogerPedidos()
        {
            Console.WriteLine("recogido por avion");
        }
    }
}
