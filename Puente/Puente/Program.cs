using System;

namespace Puente
{
    class Program
    {
        static void Main(string[] args)
        {
            Fedex fedex = new Fedex();
            Console.WriteLine("Fedex");
            fedex.RecogerMar();
            fedex.EnviarMar();
            fedex.EntregarrMar();
            Console.WriteLine("\n");

            DHL dhl = new DHL();
            Console.WriteLine("DHL");

            dhl.RecogerAvion();
            dhl.EnviarAvion();
            dhl.EntregarAvion();

            dhl.RecogerMar();
            dhl.EnviarMar();
            dhl.EntregarMar();
            Console.WriteLine("\n");

            Estafeta estafeta = new Estafeta();
            Console.WriteLine("Estafeta");

            estafeta.RecogerTren();
            estafeta.EnviarTren();
            estafeta.EntregarTren();
        }
    }
}
