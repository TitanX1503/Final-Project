using System;

namespace Final_Project
{
    class Alumnos
    {
        string name { get; set; }

       public Alumnos(string name)
        {
            this.name = name;
        } 

         public string Name()
        {
            return name;
        }
    }
}