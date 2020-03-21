using System;
namespace LaboratorioAntonia
{
    public class Person
    {
        //Atributos
        private string name;
        private string lastname;

        //Constructor
        public Person(string pName, string pLastname)
        {
            name = pName;
            lastname = pLastname;
        }

        //get y set
        public string Name()
        {
            return name;    
        }

        public string Lastname()
        {
            return lastname;
        }

        //comportamiento: lanzamiento 
        public int Launch()
        {
            Random play = new Random();
            int num;
            num = play.Next(0, 3);
            return num; 
        }
            
        

    }
}


