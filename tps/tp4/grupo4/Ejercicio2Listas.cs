using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Ejercicio2Listas
    {
        static void Main(string[] args)
        {
            List<string> alumnos = new List<string>();
            alumnos.Add("Juan, Morales, 34587321, 23/3/2000, San Juan 367, 1167891001");
            alumnos.Add("Maria, Perez, 50507332, 12/5/2001, Gral. Urquiza 368, 1167891002");
            alumnos.Add("Pedro, Gonzalez, 48200420, 03/7/2005, Av. Rivadavia 1234, 1167891003");
            alumnos.Add("Lucia, Fernandez, 40234567, 15/9/2003, Av. Santa Fe 5678, 1167891004");
            alumnos.Add("Carlos, Ramirez, 34567890, 20/11/2002, Av. Corrientes 9101, 1167891005");
            alumnos.Add("Sofia, Torres, 56789012, 05/2/2004, Av. Belgrano 2345, 1167891006");

            foreach (string alumno in alumnos)
            {
                Console.WriteLine(alumno);
            }

            Console.WriteLine("Ingrese que desea hacer: ");
            Console.WriteLine("1. Registrar nuevo alumno");
            Console.WriteLine("2. Eliminar alumno");
            Console.WriteLine("3. Modificar alumno");
            Console.WriteLine("4. Agregar alumno después del seleccionado");
            Console.WriteLine("5. Agregar alumno antes del seleccionado");
            Console.Write("Opción: ");
            string opcion = Console.ReadLine();

            //Agregar un alumno nuevo
            if (opcion == "1")
            {
                // Agregar un nuevo alumno
                Console.WriteLine("Registrar nuevo alumno");
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Apellido: ");
                string apellido = Console.ReadLine();
                Console.Write("DNI: "); 
                string dni = Console.ReadLine();
                Console.Write("Fecha de nacimiento: ");
                string fechaNacimiento = Console.ReadLine();
                Console.Write("Domicilio: ");
                string domicilio = Console.ReadLine();
                Console.Write("Telefono: ");
                string telefono = Console.ReadLine();

                alumnos.Add($"{nombre}, {apellido}, {dni}, {fechaNacimiento}, {domicilio}, {telefono}");
            }
            // Eliminar un alumno
            else if (opcion == "2")
            {
                Console.WriteLine("Eliminar alumno");
                Console.Write("Ingrese el DNI del alumno a eliminar: ");
                string dniEliminar = Console.ReadLine();
            
                alumnos.RemoveAll(alumno => alumno.Contains(dniEliminar));
            }
            // Modificar un alumno
            else if (opcion == "3")
            {
                
                Console.WriteLine("Modificar alumno");
                Console.Write("Ingrese el DNI del alumno a modificar: ");
                string dniModificar = Console.ReadLine();
            
                int index = alumnos.FindIndex(alumno => alumno.Contains(dniModificar));

                if (index != -1)
                {
                    Console.Write("Nuevo nombre: ");
                    string nuevoNombre = Console.ReadLine();
                    Console.Write("Nuevo apellido: ");
                    string nuevoApellido = Console.ReadLine();
                    Console.Write("Nueva fecha de nacimiento: ");
                    string nuevaFechaNacimiento = Console.ReadLine();
                    Console.Write("Nuevo domicilio: ");
                    string nuevoDomicilio = Console.ReadLine();
                    Console.Write("Nuevo telefono: ");
                    string nuevoTelefono = Console.ReadLine();

                    alumnos[index] = $"{nuevoNombre}, {nuevoApellido}, {dniModificar}, {nuevaFechaNacimiento}, {nuevoDomicilio}, {nuevoTelefono}";
                }
                else
                {
                    Console.WriteLine("Alumno no encontrado.");
                }
            }

            //Agregar despues del seleccionado
            if (opcion == "4")
                {
                    Console.WriteLine("Agregar alumno después del seleccionado");
                    Console.Write("Ingrese el DNI del alumno después del cual desea agregar: ");
                    string dniAgregar = Console.ReadLine();

                    int indexAgregar = alumnos.FindIndex(alumno => alumno.Contains(dniAgregar));

                    if (indexAgregar != -1)
                    {
                        Console.Write("Nombre: ");
                        string nombreAgregar = Console.ReadLine();
                        Console.Write("Apellido: ");
                        string apellidoAgregar = Console.ReadLine();
                        Console.Write("DNI: ");
                        string dniNuevo = Console.ReadLine();
                        Console.Write("Fecha de nacimiento: ");
                        string fechaNacimientoAgregar = Console.ReadLine();
                        Console.Write("Domicilio: ");
                        string domicilioAgregar = Console.ReadLine();
                        Console.Write("Telefono: ");
                        string telefonoAgregar = Console.ReadLine();

                        alumnos.Insert(indexAgregar + 1, $"{nombreAgregar}, {apellidoAgregar}, {dniNuevo}, {fechaNacimientoAgregar}, {domicilioAgregar}, {telefonoAgregar}");
                    }
                    else
                    {
                        Console.WriteLine("Alumno no encontrado.");
                    }
                }
            //Agregar alumno antes del seleccionado
            else if (opcion == "5")
                {
                    Console.WriteLine("Agregar alumno antes del seleccionado");
                    Console.Write("Ingrese el DNI del alumno antes del cual desea agregar: ");
                    string dniAgregarAntes = Console.ReadLine();    

                    int indexAgregarAntes = alumnos.FindIndex(alumno => alumno.Contains(dniAgregarAntes));

                    if (indexAgregarAntes != -1)
                    {
                        Console.Write("Nombre: ");
                        string nombreAgregar = Console.ReadLine();
                        Console.Write("Apellido: ");
                        string apellidoAgregar = Console.ReadLine();
                        Console.Write("DNI: ");
                        string dniNuevo = Console.ReadLine();
                        Console.Write("Fecha de nacimiento: ");
                        string fechaNacimientoAgregar = Console.ReadLine();
                        Console.Write("Domicilio: ");
                        string domicilioAgregar = Console.ReadLine();
                        Console.Write("Telefono: ");
                        string telefonoAgregar = Console.ReadLine();

                        alumnos.Insert(indexAgregarAntes, $"{nombreAgregar}, {apellidoAgregar}, {dniNuevo}, {fechaNacimientoAgregar}, {domicilioAgregar}, {telefonoAgregar}");
                    }
                    else
                    {
                        Console.WriteLine("Alumno no encontrado.");
                    }
                }

            //Mostrar la lista actualizada de alumnos
            Console.WriteLine("\nLista actualizada de alumnos:");
            if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4" || opcion == "5")
            {
                foreach (string alumno in alumnos)
                {
                    Console.WriteLine(alumno);
                }
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }
    }
}