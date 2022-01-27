using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Bancario
{
    class Certificados
    {
        private static Random alt = new Random();
        int num = alt.Next(1000, 9999);
        private int monto;
        private int time;
        private int montototal;
        public void Apertura()
        {
            Console.WriteLine($"Numero de Certificado:{num}");
            Console.WriteLine("\nIngrese el monto que desea para su Certificado");
            monto = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de tiempo de duracion en meses:");
            time = int.Parse(Console.ReadLine());
            Console.WriteLine($"El monto es:{monto}DOP, en tiempo de:{time} meses");
        }
        public void ConsultaInteres()
        {
            Console.WriteLine("Ingrese su numero de certificado para validarlo:");
            int valor = int.Parse(Console.ReadLine());
            foreach (Certificados certificado in Menu.CrearCertificados)
            {
                if (certificado.num== valor)
                {
                    Console.WriteLine($"\nEl monto del certificado:{certificado.monto}");
                    Console.WriteLine($"\nTiempo: {certificado.time}meses");
                    certificado.montototal = certificado.monto * certificado.time;
                    Console.WriteLine($"\nValor Arbitrario:{certificado.montototal}");
                    Console.ReadKey();
                    Console.Clear();

                }
                else
                {
                    Console.WriteLine("El numero del Certificado es inexistente");
                    Console.ReadKey();
                    Console.Clear();
                    ConsultaInteres();
                }
            }
        }
    }
}
