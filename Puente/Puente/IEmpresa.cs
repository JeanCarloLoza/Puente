using System;
using System.Collections.Generic;
using System.Text;

namespace Puente
{
    abstract class IEmpresa
    {
        IProcesadorEnvio envioBarco = new ProcesadorBarco();
    }
}
