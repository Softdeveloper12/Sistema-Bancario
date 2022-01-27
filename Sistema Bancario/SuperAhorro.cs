using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Bancario
{
    class SuperAhorro
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

            foreach (Adapter deposit in Menu.MiAdaptador)
            {
                if (deposit.misuperahorro.num == valor)
                {
                    Console.WriteLine($"Su balance es de:{deposit.misuperahorro.balance}DOP$");
                    Console.WriteLine("Ingrese cuanto desea depositar:");
                    double dep = double.Parse(Console.ReadLine());
                    deposit.misuperahorro.balance += dep;
                    Console.WriteLine($"\nSe ha efectuado un deposito de:{dep}Dop");
                    Console.WriteLine($"\nSu balance es ahora de:{deposit.misuperahorro.balance}DOP");

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
            foreach (Adapter retiro in Menu.MiAdaptador)
            {
                if (retiro.misuperahorro.num == valor)
                {
                    Console.WriteLine($"Su balance es de:{retiro.misuperahorro.balance}DOP$");
                    Console.WriteLine("Ingrese cuanto desea Retirar:");
                    double ret = double.Parse(Console.ReadLine());
                    retiro.misuperahorro.balance -= ret;
                    Console.WriteLine($"\nSe ha efectuado un retiro de:{ret}Dop");
                    Console.WriteLine($"\nSu balance es ahora de:{retiro.misuperahorro.balance}DOP");

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
            foreach (Adapter Consulta in Menu.MiAdaptador)
            {
                if (Consulta.misuperahorro.num == valor)
                {
                    Console.WriteLine($"Su consulta es:{Consulta.misuperahorro.balance}");
                }
            }
        }
        public void VerifyRetiro()
        {
            Console.WriteLine("Ingrese su numero de cuenta para validarla:");
            int valor = int.Parse(Console.ReadLine());
            foreach (Adapter retiro in Menu.MiAdaptador)
            {
                if (retiro.misuperahorro.num  == valor)
                {
                    Console.WriteLine($"Su balance es de:{retiro.misuperahorro.balance}DOP$");
                    Console.WriteLine("Ingrese cuanto desea Retirar:");
                    double ret = double.Parse(Console.ReadLine());

                    retiro.misuperahorro.balance -= ret;
                    if (retiro.misuperahorro.balance <= (40 % retiro.misuperahorro.balance))
                    {
                        Retiros();
                    }
                    else
                    {
                        Console.WriteLine("No es valido retirar para su tipo de cuenta.");
                        
                    }
                    
                }
                else
                {
                    Console.WriteLine("Error de validacion de cuenta, el numero de cuenta ingresado es inexistente, por favo intente de nuevo....");
                    Console.ReadKey();
                    Console.Clear();


                }

            }
        }
    }
}

