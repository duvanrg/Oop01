using Oop01.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        List<Estudiantes> lstClase = new List<Estudiantes>();
        for (var i = 0; i <= 2 + 1; i++)
        {

            Estudiantes estudiantes = new Estudiantes();
            estudiantes.Id = Guid.NewGuid().ToString();
            Console.WriteLine("Ingrese Nombre: ");
            estudiantes.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Email: ");
            estudiantes.Email = Console.ReadLine();
            Console.WriteLine("Ingrese Edad: ");
            estudiantes.Edad = int.Parse(Console.ReadLine());
            lstClase.Add(estudiantes);

            Console.Clear();
            Console.WriteLine(("(0, -36) (1,-30) | (2,3) |", "Cod. Estudiante", "Nombre Estudiante", "Correo Electronico"));
            for (var j = 0; j < lstClase.Count; j++)
            {
                Console.WriteLine(("(0, -36) (1,-30) | (2,3) |", lstClase[j].Id, lstClase[j].Nombre, lstClase[j].Email));
            }
            foreach (Estudiantes est in lstClase)
            {
                Console.WriteLine(("(0, -36) (1,-30) | (2,3) |", est.Id, est.Nombre, est.Email));
            }
            Console.ReadKey();

        }
        // estudiantes.ImprimirDatos();
    }
}