class Ejercicio_10
{
    static void Main()
    {
        string x;
        int mitad;
        string segundaMitad;
        string primeraMitad;

        Console.Write("Ingrese una frase: ");
        x = Console.ReadLine();

        mitad = x.Length / 2;

        primeraMitad = x.Substring(0, mitad);
        segundaMitad = x.Substring(mitad);

        Console.WriteLine("Resultado: " + segundaMitad + primeraMitad);

        Console.ReadKey();
    }
}
