using System;
using System.Collections.Generic;
using System.Text;

namespace ListasEnlazadas
{
    class Menu
    {
        public char opcion { get; set; }

        public Menu(char opcion)
        {
            this.opcion = opcion;
        }
        public Menu()
        {

        }

        public char menuOpciones()
        {

            char opcion;


            Console.WriteLine();
            Console.WriteLine("Seleccione la opcion que desea hacer:");
            Console.WriteLine("(A) Insertar ");//YA
            Console.WriteLine("(B) Eliminar"); //YA
            Console.WriteLine("(C) Mostrar"); //YA
            Console.WriteLine("(D) Buscar"); //YA
            Console.WriteLine("(E) Modificar"); //YA
            Console.WriteLine("(F) Creditos"); //YA
            opcion = Convert.ToChar(Console.ReadLine().ToUpper());
            // Console.ReadKey();
            return opcion;



        }

    }
}
