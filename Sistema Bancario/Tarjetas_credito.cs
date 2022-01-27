using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Bancario
{
    class Tarjetas_credito
    {
        private static Random alt = new Random();
        private int num = alt.Next(100001, 999999);
        private int limit;
        private int limite;
        private int valor;
        private int balance;
        private int consumo;
        private int valortarjeta;
        public void Expedicion()
        {
            Console.WriteLine($"Numero de la tarjeta: {num}");
            Console.WriteLine("Ingrese el limite de la tarjeta:");
            limit = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"\nBalance de la Tarjeta de Credito:{limit}DOP");


        }
        public void Consumos()
        {
            Console.WriteLine("Ingrese su numero de Tarjeta para validarla:");
            int valor = int.Parse(Console.ReadLine());
            foreach(Tarjetas_credito card in Menu.CrearTarjeta)
            {
                if (card.num== valor)
                {
                    Console.WriteLine($"El limite de la tarjeta de credito es de:{card.limit}DOP");
                    Console.WriteLine("Ingrese cuanto desee consumir:");
                    card.consumo = int.Parse(Console.ReadLine());
                    card.balance = card.limit - card.consumo;
                    Console.WriteLine($"El monto consumido es:{card.consumo}");
                    Console.WriteLine($"El monto Disponible es:{card.balance}");
                    
                    Console.ReadKey();
                    Console.Clear();

                }
                
            }
        }
        public void Pagos()
        {
            Console.WriteLine("Ingrese su numero de Tarjeta para validarla:");
            int valor = int.Parse(Console.ReadLine());
            foreach (Tarjetas_credito cardpagos in Menu.CrearTarjeta)
            {
                if(cardpagos.num== valor)
                {
                    Console.WriteLine($"\nEl limite de la tarjeta es de:{cardpagos.limit}DOP");
                    Console.WriteLine($"\nEl balance actual de la tarjeta es de:{cardpagos.balance}");
                    
                    Console.WriteLine($"Ingrese la cantidad a pagar:");
                    int pago = int.Parse(Console.ReadLine());
                    cardpagos.valortarjeta = cardpagos.consumo - pago;
                    cardpagos.balance += pago;
                    
                    Console.WriteLine($"\nMonto pagado:{pago}DOP");
                    Console.WriteLine($"\nMonto Disponible:{cardpagos.balance}DOP");

                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("El numero de la tarjeta es inexistente");
                    Console.ReadKey();
                    Console.Clear();
                    Pagos();
                }
            }
        }
    }
}
