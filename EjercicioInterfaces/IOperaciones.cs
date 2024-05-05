using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public interface IOperaciones
    {
        public double CalcularAreaCuadrado(double lado);
        public double CalcularPerimetroCuadrado(double lado);
        public double CalcularVolumenCuadrado(double lado);
        public double CalcularLongitudDigonalCuadrado(double lado);
        public double CalcularAreaCirculo(double Radio);

        public void Imprimir();
    }
}
