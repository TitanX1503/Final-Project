using System;

namespace PR3_Report_Card
{
    class Materias
    {
        public void Name()
        {
            System.Console.WriteLine("cual es la materia");
            string name = Convert.ToString(Console.ReadLine());
            System.Console.WriteLine($"la calificacion en {name}?");
        }
        public float CalificacionParcial1()
        {
            System.Console.WriteLine("Calificacion Del Primer Parcial");
            float calificacion1 = Convert.ToInt32(Console.ReadLine());
            return calificacion1; 
        }
        public float CalificacionParcial2()
        {
            System.Console.WriteLine("Calificacion Del Segundo Parcial");
            float calificacion2 = Convert.ToInt32(Console.ReadLine());
            return calificacion2;
        }
        public float CalificacionParcial3()
        {
            System.Console.WriteLine("Calificacion Del Tercer Parcial");
            float calificacion3 = Convert.ToInt32(Console.ReadLine());
            return calificacion3;
        }
        public void CalificasionTotal()
        {
            float calificasiontotal = (CalificacionParcial1() + CalificacionParcial2() + CalificacionParcial3())/3;
            System.Console.WriteLine(calificaciontotal);
        }
    }
}