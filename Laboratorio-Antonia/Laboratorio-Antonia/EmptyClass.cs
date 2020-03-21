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
        public string Name
        {
            set { name = value; }
            get { return name; }    
        }

        public string Lastname
        {
            set { lastname = value; }
            get { return lastname; } 
        }


        

    }
}


