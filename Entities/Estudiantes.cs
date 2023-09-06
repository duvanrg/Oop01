

namespace Oop01.Entities
{
    public class Estudiantes
    {
        private string id;
        private string nombre;
        private string email;
        private int edad;

        public Estudiantes()
        {
        }
        public Estudiantes(string id, string nombre, string email, int edad)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Email = email;
            this.Edad = edad;
        }

        public string Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int Edad { get { return edad; } set { edad = value; } }

        public  void ImprimirDatos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Id: {0,11}{1, 40} \nNombre: {0,11}{2, -20} \nEmail: {0,12}{3, -30} \nEdad: {0,13}{4, -20} ", "", id, nombre, email, edad);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}