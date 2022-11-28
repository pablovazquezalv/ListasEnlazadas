using System;
using System.Collections.Generic;
using System.Text;

namespace ListasEnlazadas
{
    class Lista
    {
        private Nodo first, end;


        public Lista()
        {
            first = null;
            end = null;
        }

        public void AgregarOrdenado()
        {

            Console.WriteLine("Escribe la palabra:");
            string valor = Console.ReadLine();
            Nodo nuevo = new Nodo(valor);
            if (first == null)
            {
                first = end = nuevo;
                return;
            }
            if (first.valor.CompareTo(valor) > 0)
            {
                nuevo.siguiente = first;
                first = nuevo;
                return;
            }
            Nodo actual = first;
            while (actual.siguiente != null)
            {
                if (actual.siguiente.valor.CompareTo(valor) > 0)
                {
                    nuevo.siguiente = actual.siguiente;
                    actual.siguiente = nuevo;
                    return;
                }
                actual = actual.siguiente;



            }
            nuevo.anterior = end;
            end.siguiente = nuevo;
            end = nuevo;

        }

        public void AgregarFinal(string valor)

        {
            Nodo nuevo = new Nodo(valor);
            if (first == null) first = end = nuevo;

            else
                end.siguiente = nuevo;
            nuevo.anterior = end;
            nuevo.siguiente = null;
            end = nuevo;


        }

        public void AgregarInicio(string valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (first == null) first = end = nuevo;
            else
                nuevo.siguiente = first;
            first.anterior = nuevo;
            nuevo.anterior = null;
            first = nuevo;
        }
        public void MostrarAscendente()
        {

            Nodo actual = first;
            while (actual != null)
            {
                Console.WriteLine("-"+actual.valor);
                actual = actual.siguiente;
            }

        }
        public void MostrarDescendente()
        {

            {
                Nodo actual = end;
                while (actual != null)
                {
                    Console.WriteLine(actual.valor);
                    actual = actual.anterior;
                }
            }

        }

        public string Buscar(string valor)
        {

            Nodo actual = first;
            while (actual != null)
            {
                if (actual.valor == valor)
                {
                    Console.WriteLine("El valor " + valor + " se encuentra en la lista");
                    return valor;
                }
                actual = actual.siguiente;
            }
            Console.WriteLine("El valor " + valor + " NO se encuentra en la lista");
            return null;


        }

        

        public void VaciarLista()
        {

            Nodo Actual = first;
            while (Actual != null)
            {

                Actual = Actual.siguiente;
                Actual.anterior = null;
                first = Actual;

            }
        }

        public void Eliminar(String valor)
        {
            Nodo actual = first;
            
                while (actual.siguiente != null && actual.valor != valor)
                {
                    actual = actual.siguiente;
                }
                if (actual.valor == valor)
                {
                    if (actual == first && actual == end)
                    {
                        first = end = null;
                        return;
                    }

                    if (actual == first)
                    {
                        first = actual.siguiente;
                        first.anterior = null;
                        return;
                    }

                    if (actual == end)
                    {
                        end = actual.anterior;
                        end.siguiente = null;
                        return;
                    }
                    Nodo anterior = actual.anterior, siguiente = actual.siguiente;

                    anterior.siguiente = siguiente;

                    siguiente.anterior = anterior;

                
            }



         
        }

        public void Modificar(string valor)
        {
            if (valor == null)
            {
                Console.WriteLine("El arreglo esta Vacio......");

            }
            else
            {

                string valorb = Buscar(valor);
                if (valorb == null)
                {
                    Console.WriteLine("No existe");
                }
                else
                {
                    Eliminar(valor);
                    AgregarOrdenado();
                }

            }

        }


        public void EliminarR()
        {

            Console.WriteLine("Escribe la palabra:");
            string valore = Console.ReadLine();

            string valor = Buscar(valore);

            if (valor == null)
            {
                Console.WriteLine("no existe");
            }
            else
            {
                Nodo actual = first;

                while (actual.siguiente != null && actual.valor != valor)
                {
                    actual = actual.siguiente;
                }
                if (actual.valor == valor)
                {
                    if (actual == first && actual == end)
                    {
                        first = end = null;
                        return;
                    }

                    if (actual == first)
                    {
                        first = actual.siguiente;
                        first.anterior = null;
                        return;
                    }

                    if (actual == end)
                    {
                        end = actual.anterior;
                        end.siguiente = null;
                        return;
                    }
                    Nodo anterior = actual.anterior, siguiente = actual.siguiente;

                    anterior.siguiente = siguiente;

                    siguiente.anterior = anterior;


                }

            }
        }
    }
}
