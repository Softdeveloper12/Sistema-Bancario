using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Bancario
{
    class Adapter:Target
    {
        public  SuperAhorro misuperahorro = new SuperAhorro();
        public static Adapter miadapter = new Adapter();
        public override void Apertura()
        {
            misuperahorro.Apertura();
        }
        public override void Deposito()
        {
            misuperahorro.Depositos();
        }
        public override void Retiro()
        {
            misuperahorro.VerifyRetiro();
        }
        public override void Consulta()
        {
            misuperahorro.Consultas();
        }

    }
}
