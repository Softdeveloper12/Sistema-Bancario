using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Bancario
{
    class Menu
    {
        public static List<CFacade> MiFachada = new List<CFacade>();
        public static List<Cuentas_ahorros> CrearCuenta = new List<Cuentas_ahorros>();
        public static List<Prestamos> CrearPrestamo = new List<Prestamos>();
        public static List<Tarjetas_credito> CrearTarjeta = new List<Tarjetas_credito>();
        public static List<Certificados> CrearCertificados = new List<Certificados>();
        public static List<SuperAhorro> CrearSuperAhorro = new List<SuperAhorro>();
        public static List<Adapter> MiAdaptador = new List<Adapter>();

        public static void menu()
        {
            CFacade facade = new CFacade();
            Cuentas_ahorros Cuenta = new Cuentas_ahorros();
            Prestamos Prestamo = new Prestamos();
            Tarjetas_credito tarjetas = new Tarjetas_credito();
            Certificados certificado = new Certificados();
            Adapter Adaptador = new Adapter();


            Console.WriteLine("¿Cual App desea utilizar?");
            Console.WriteLine("1- App de Escritorio");
            Console.WriteLine("2- App Movil");
            int opt = int.Parse(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    //App de Escritorio
                    Console.WriteLine("1- Cuentas de ahorro");
                    Console.WriteLine("2- Prestamos");
                    Console.WriteLine("3- Tarjetas de Credito");
                    Console.WriteLine("4- Certificados Financieros ");
                    int n1 = int.Parse(Console.ReadLine());
                    if (n1 == 1)
                    {
                        Console.WriteLine("1- Cuenta de Ahorro Normal");
                        Console.WriteLine("2- Cuenta de Super Ahorro");
                        int c = int.Parse(Console.ReadLine());
                        switch (c)
                         
                        {
                          case 1:
                                Console.WriteLine("1- Modulo Crear cuenta de ahorro");
                                Console.WriteLine("2- Modulo Depositos");
                                Console.WriteLine("3- Modulo Retiro");
                                Console.WriteLine("4- Modulo consultas");
                                
                                //Cuenta de ahorro normal
                                int ca = int.Parse(Console.ReadLine());
                                if (ca== 1)
                                {
                                    Cuenta.Apertura();
                                    CrearCuenta.Add(Cuenta);
                                    Console.ReadKey();
                                    Console.Clear();
                                    menu();

                                }
                                else if (ca == 2)
                                {
                                    Cuenta.Depositos();
                                    menu();
                                    
                                }
                                else if (ca == 3)
                                {
                                    Cuenta.Retiros();
                                    menu();
                                    
                                }
                                else if (ca == 4)
                                {
                                    Cuenta.Consultas();
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una opcion valida!!");
                                    Console.ReadKey();
                                    Console.Clear();
                                    menu();
                                }

                                break;
                            case 2:
                                //Cuenta Super Ahorro
                                Console.WriteLine("1- Modulo Crear cuenta de super ahorro");
                                Console.WriteLine("2- Modulo Depositos");
                                Console.WriteLine("3- Modulo Retiro");
                                Console.WriteLine("4- Modulo consultas");
                                int cs = int.Parse(Console.ReadLine());
                                if (cs == 1)
                                {
                                    Adapter.miadapter.Apertura();
                                    MiAdaptador.Add(Adapter.miadapter);
                                    Console.ReadKey();
                                    Console.Clear();
                                    menu();
                                }
                                else if (cs == 2)
                                {
                                    Adapter.miadapter.Deposito();
                                    Console.ReadKey();
                                    Console.Clear();
                                    menu();
                                }
                                else if (cs == 3)
                                {
                                    Adapter.miadapter.Retiro();
                                    Console.ReadKey();
                                    Console.Clear();
                                    menu();
                                }
                                else if (cs == 4)
                                {
                                    Adapter.miadapter.Consulta();
                                    Console.ReadKey();
                                    Console.Clear();
                                    menu();
                                }
                                else
                                {
                                    Console.WriteLine("Error de acceso, opcion invalida, intente nuevamente....");
                                    Console.ReadKey();
                                    Console.Clear();
                                    menu();
                                }

                                break;
                            default:
                                Console.WriteLine("Error de acceso, opcion invalida, intente nuevamente....");
                                Console.ReadKey();
                                Console.Clear();
                                menu();
                                break;
                        }
                        
               
                    }
                    else if (n1 == 2)
                    {
                        Console.WriteLine("1- Modulo Solicitud de prestamos");
                        Console.WriteLine("2- Modulo Pago de Prestamos");
                        int p = int.Parse(Console.ReadLine());
                        switch (p)
                        {
                            case 1:
                                Prestamo.SolicitudPrestamo();
                                CrearPrestamo.Add(Prestamo);
                                Console.ReadKey();
                                Console.Clear();
                                menu();
                                break;
                            case 2:
                                Prestamo.PagoPrestamo();
                                menu();
                                break;
                            default:
                                Console.WriteLine("Error de acceso, opcion invalida, intente nuevamente....");
                                Console.ReadKey();
                                Console.Clear();
                                menu();
                                break;
                        }

                    }
                    else if (n1 == 3)
                    {
                        Console.WriteLine("1- Modulo Expedicion");
                        Console.WriteLine("2- Modulo Consumos");
                        Console.WriteLine("3- Modulo Pagos");
                        int t= int.Parse(Console.ReadLine());
                        switch (t)
                        {
                            case 1:
                                tarjetas.Expedicion();
                                CrearTarjeta.Add(tarjetas);
                                Console.ReadKey();
                                Console.Clear();
                                menu();
                                break;
                            case 2:
                                tarjetas.Consumos();
                                menu();

                                break;
                            case 3:
                                tarjetas.Pagos();
                                menu();
                                break;
                            default:
                                Console.WriteLine("Error de acceso, opcion invalida, intente nuevamente....");
                                Console.ReadKey();
                                Console.Clear();
                                menu();
                                break;
                          
                        }
                    }
                    else if (n1 == 4)
                    {
                        Console.WriteLine("1- Modulo Apertura");
                        Console.WriteLine("2- Modulo Consulta de interes");
                        int ce = int.Parse(Console.ReadLine());
                        switch (ce)
                        {
                            case 1:
                                certificado.Apertura();
                                CrearCertificados.Add(certificado);
                                Console.ReadKey();
                                Console.Clear();
                                menu();
                                break;
                            case 2:
                                certificado.ConsultaInteres();
                                menu();
                                break;
                            default:
                                Console.WriteLine("Error de acceso, opcion invalida, intente nuevamente....");
                                Console.ReadKey();
                                Console.Clear();
                                menu();
                                break;
                        }

                    }
                    break;
                case 2:
                    //App Movil
                    Console.WriteLine("1- Cuentas de ahorro");
                    Console.WriteLine("2- Prestamos");
                    Console.WriteLine("3- Certificados Financieros ");
                    int n2 = int.Parse(Console.ReadLine());
                    if (n2 == 1)
                    {
                        facade.OperacionCuentas();
                        MiFachada.Add(facade);
                        Console.ReadKey();
                        Console.Clear();
                        menu();
                    }
                    else if (n2 == 2)
                    {
                        facade.OperacionPrestamos();
                        MiFachada.Add(facade);
                        Console.ReadKey();
                        Console.Clear();
                        menu();
                    }
                    else if (n2 == 3)
                    {
                        facade.OperacionCertificados();
                        MiFachada.Add(facade);
                        Console.ReadKey();
                        Console.Clear();
                        menu();

                    }
                    else
                    {
                        Console.WriteLine("Error de acceso, opcion invalida, intente nuevamente....");
                        Console.ReadKey();
                        Console.Clear();
                        menu();
                    }
                    break;
                default:
                    Console.WriteLine("Error de acceso, opcion invalida, intente nuevamente....");
                    Console.ReadKey();
                    Console.Clear();
                    menu();
                    break;
                

            }
        }
    }
}
