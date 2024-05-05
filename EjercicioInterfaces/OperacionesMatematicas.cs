using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public class OperacionesMatematicas : IOperaciones
    {
       
        public double CalcularAreaCirculo(double Radio)
        {
            return Math.PI * Radio * Radio;
        }

        public double CalcularAreaCuadrado(double lado)
        {
            return lado * lado;
        }

        public double CalcularLongitudDigonalCuadrado(double lado)
        {
            return Math.Sqrt(lado * lado);
        }

        public double CalcularPerimetroCuadrado(double lado)
        {
            return 4 * lado;   
        }

        public double CalcularVolumenCuadrado(double lado)
        {
            return lado* lado *lado;
        }

        public void Imprimir(double lado , double Radio)
        {
            Console.WriteLine("Resutlados:");
            Console.WriteLine("Area del Cuadrado:", CalcularAreaCuadrado(lado));
            Console.WriteLine("Perimtro del Cuadrado:", CalcularPerimetroCuadrado(lado));
            Console.WriteLine("Volumen de Cubo:", CalcularVolumenCuadrado(lado));
            Console.WriteLine("Longitud de la diagonal del cuadrado:", CalcularLongitudDigonalCuadrado(lado));
            Console.WriteLine("Area del Circulo:", CalcularAreaCirculo(Radio));
        }

        public void Imprimir()
        {
            throw new NotImplementedException();
        }
    }
}
