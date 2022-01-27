using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Bancario
{
    class Prestamos
    {
        private double adeudado;
        private double montoprestamo;
        private double tasaprestamo;
        private double totalprestamo;
        private static Random alt = new Random();
        int num = alt.Next(1000, 9999);
        private double balance;

       

        public void SolicitudPrestamo()
        {
            Console.WriteLine($"Numero de Prestamo: {num}");
            Console.WriteLine("Ingrese el monto del prestamo:");
            montoprestamo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tasa:");
            tasaprestamo= double.Parse(Console.ReadLine());
            totalprestamo = montoprestamo + (montoprestamo * (tasaprestamo / 100));
            balance = totalprestamo;
            Console.WriteLine($"Prestamo con intereses:{balance}DOP");
        }
        
        public void PagoPrestamo()
        {
            Console.WriteLine("Ingrese su numero de prestamo para la convalidacion:");
            int val= int.Parse(Console.ReadLine());
            foreach(Prestamos prestado in Menu.CrearPrestamo)
            {
                if (prestado.num == val)
                {
                    Console.WriteLine($"\nEl prestamo es de:{prestado.totalprestamo}DOP");
                    Console.WriteLine($"Ingrese la cantidad a pagar:");
                    double pago = double.Parse(Console.ReadLine());
                    adeudado = prestado.totalprestamo - pago;
                    Console.WriteLine($"\nSe ha realizado un pago de:{pago}DOP");
                    Console.WriteLine($"\nAhora su balance del prestamo pendiente es de:{adeudado}DOP");
                    prestado.totalprestamo = adeudado;
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("El numero de prestamo es invalido porque es inexistente, por favor intente de nuevo");
                    Console.ReadKey();
                    Console.Clear();
                    PagoPrestamo();
                }
            }

           

        }
    }
}
