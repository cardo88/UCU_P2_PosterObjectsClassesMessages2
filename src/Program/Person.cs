using System;

namespace Personas
{


    public class Person
    {
        private string nombre = "Sin Nombre";
        private string cedula = "0.000.000-0";

        public string Nombre
        {
            get { return this.nombre;}
            set 
            { 
                if(value != "")
                    this.nombre = value;
            }
        }

        public string Cedula
        {
            get { return this.cedula;}
            set 
            { 
                if (IdUtils.IdIsValid(value))
                    this.cedula = value;
            }        
        }

        public Person(string n, string c)
        {
            this.Cedula = c;
            this.Nombre = n;
        }


        public void IntroduceYourself()
        {
            Console.WriteLine($"Hola, soy {this.Nombre}, y mi cédula es {this.Cedula}");
        }



    }
}