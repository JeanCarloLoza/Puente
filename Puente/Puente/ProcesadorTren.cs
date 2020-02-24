using System;
using System.Collections.Generic;
using System.Text;

namespace Puente
{
    class ProcesadorTren : IProcesadorEnvio
    {
        public void EntregarPedidos()
        {
            Console.WriteLine("entregado por Tren");
        }

        public void EnviarPedidos()
        {
            Console.WriteLine("enviado por Tren");
        }

        public void RecogerPedidos()
        {
            Console.WriteLine("recogido por Tren");
        }
    }
}
