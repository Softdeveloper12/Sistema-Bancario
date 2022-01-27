using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Bancario
{
    class Cuentas_ahorros
    {
        private static Random alt = new Random();
        private int num = alt.Next(1001, 9999);
        private double monto;
        private double balance;

        public void Apertura()
        {
            
            Console.WriteLine($"Numero de cuenta:{num}");
            Console.WriteLine("Ingrese la cantidad con la que desea abrir su cuenta:");
            balance = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"\nBalance de Apertura:{balance}DOP");

        }
        public void Depositos()
        {
            Console.WriteLine("Ingrese su numero de cuenta para validarla:");
            int valor = int.Parse(Console.ReadLine());

            foreach (Cuentas_ahorros deposito in Menu.CrearCuenta)
            {
                if (deposito.num == valor) 
                {
                    Console.WriteLine($"Su balance es de:{deposito.balance}DOP$");
                    Console.WriteLine("Ingrese cuanto desea depositar:");
                    double dep = double.Parse(Console.ReadLine());
                    deposito.balance += dep;
                    Console.WriteLine($"\nSe ha efectuado un deposito de:{dep}Dop");
                    Console.WriteLine($"\nSu balance es ahora de:{deposito.balance}DOP");
                    
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Error de validacion de cuenta, el numero de cuenta ingresado es inexistente, por favo intente de nuevo....");
                    Console.ReadKey();
                    Console.Clear();


                }

            }



        }
        public void Retiros()
        {
            Console.WriteLine("Ingrese su numero de cuenta para validarla:");
            int valor = int.Parse(Console.ReadLine());
            foreach (Cuentas_ahorros retiro in Menu.CrearCuenta)
            {
                if (retiro.num == valor)
                {
                    Console.WriteLine($"Su balance es de:{retiro.balance}DOP$");
                    Console.WriteLine("Ingrese cuanto desea Retirar:");
                    double ret = double.Parse(Console.ReadLine());
                    retiro.balance -= ret;
                    Console.WriteLine($"\nSe ha efectuado un retiro de:{ret}Dop");
                    Console.WriteLine($"\nSu balance es ahora de:{retiro.balance}DOP");
                    retiro.monto = balance;
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Error de validacion de cuenta, el numero de cuenta ingresado es inexistente, por favo intente de nuevo....");
                    Console.ReadKey();
                    Console.Clear();


                }

            }
        }
        public void Consultas()
        {
            Console.WriteLine("Ingrese su numero de cuenta para validarla:");
            int valor = int.Parse(Console.ReadLine());
            foreach (Cuentas_ahorros Consulta in Menu.CrearCuenta)
            {
                if (Consulta.num== valor)
                {
                    Console.WriteLine($"Su consulta es:{Consulta.balance}");
                }
            }
        }
    }
}