using System;

namespace LaboratorioAntonia
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person per = new Person("Bob","Kunga");
            Console.WriteLine("Nombre: {0}",per.Name);
            Console.WriteLine("Apellido: {0}", per.Lastname);
            
        }
    }
}
