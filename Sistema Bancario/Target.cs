using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Bancario
{
    abstract class Target
    {
        public abstract void Apertura();


        public abstract void Deposito();


        public abstract void Retiro();

        
        public abstract void Consulta();
        
        
    }
}
