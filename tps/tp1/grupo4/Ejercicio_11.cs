class Ejercicio_11
{
    static void Main()
    {
        string frase;
        int cantidad;

        Console.Write("Ingrese una frase: ");
        frase = Console.ReadLine();

        cantidad = frase.Length;

        Console.WriteLine("La cantidad de caracteres es: " + cantidad);

        Console.ReadKey();
    }
}

