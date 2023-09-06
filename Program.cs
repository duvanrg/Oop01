using Oop01.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Estudiantes estudiantes = new Estudiantes();
        estudiantes.Id = Guid.NewGuid().ToString();
        Console.WriteLine("Ingrese Nombre: ");
        estudiantes.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese Email: ");
        estudiantes.Email = Console.ReadLine();
        Console.WriteLine("Ingrese Edad: ");
        estudiantes.Edad = int.Parse(Console.ReadLine());

        estudiantes.ImprimirDatos();
    }
}