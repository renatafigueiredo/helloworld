using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboratorio_0___Figuras_Geometricas
{
    // Nivel 1
    public class Quadrado : Figura
    {
        private int lado;
        private double areaFiguras;

        public Quadrado()
        {
            lado = 1;
        }

        public Quadrado(int lado)
        {
            this.lado = lado;
        }

        public Quadrado(int x, int y, int lado)
            : base(x, y)
        {
            this.lado = lado;
        }

        public int Lado
        {
            set{ lado = value; }

            get{ return lado; }
        }

        public double AreaFiguras
        {
            get{return lado * lado;}
        }
           


        // Nivel 2
        public override string ToString()
        {
            return base.ToString() + " L=" + lado;
        }
    }
}
