using System;

namespace ListasEnlazadas
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu mimenu = new Menu();

            char opcion;

            Lista list = new Lista();

            Console.WriteLine("-----LISTAS-----");

            do {
                opcion = mimenu.menuOpciones();

                switch (opcion)
                {

                    case 'A':
                        Console.WriteLine("-----------INSERTAR LISTA-----------");
                        list.AgregarOrdenado();
                        break;
                    case 'B':
                        Console.WriteLine("-----------ELIMINAR LISTA-----------");
                      //  Console.WriteLine("Escribe la palabra:");
                       // string valore = Console.ReadLine();
                       // list.Eliminar(valore);
                        list.EliminarR();
                        break;
                    case 'C':

                        Console.WriteLine("-----------MOSTRAR LISTA-----------");
                        list.MostrarAscendente();
                        break;
                    case 'D':
                        Console.WriteLine("-----------BUSCAR LISTA-----------");
                        Console.WriteLine("Escribe la palabra:");
                        string valorb = Console.ReadLine();
                        list.Buscar(valorb);
                        break;
                    case 'E':
                        Console.WriteLine("-----------MODIFICAR LISTA-----------");
                        Console.WriteLine("Escribe la palabra a modificar:");
                        string valorm = Console.ReadLine();
                        list.Modificar(valorm);
                        break;
                    case 'F':
                        Console.WriteLine("-----------CREDITOS----------- ");
                        Console.WriteLine("Sebastian Murillo | 20170134");
                        Console.WriteLine("Julio Cesar Tovar |20170151");
                        Console.WriteLine("Pablo Vazquez Alvarado |21170086");
                        break;
                    default:


                        break;
                }

            } while (opcion != 'J');
        }
    }
}
