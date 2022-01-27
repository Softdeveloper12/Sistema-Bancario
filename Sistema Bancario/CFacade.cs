using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Bancario
{
    class CFacade
    {
        #region Variables
        private Prestamos prestamo = new Prestamos();
        private Certificados certificados = new Certificados();
        private Cuentas_ahorros cuenta = new Cuentas_ahorros();
        private Adapter adapter = new Adapter();
        #endregion

        #region OpsCuentas
        public void OperacionCuentas()
        {
            Console.WriteLine("1- Cuenta de ahorro normal");
            Console.WriteLine("2- Cuenta de super ");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                
                cuenta.Consultas();
            }
           else if (n == 2)
            {
                
                adapter.Consulta();
            }
            else
            {
                Console.WriteLine("Opcion Invalida, por favor ingrese una opcion correcta.... ");
                Console.ReadKey();
                Console.Clear();
                OperacionCuentas();
            }
        }

        #endregion

        #region OpsPrestamos
        public void OperacionPrestamos()
        {

            prestamo.PagoPrestamo();

        }

        #endregion

        #region OpsCertificados
        public void OperacionCertificados()
        {
            certificados.ConsultaInteres();
        }
        #endregion
    }
}
