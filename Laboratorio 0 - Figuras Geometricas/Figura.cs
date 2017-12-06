using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboratorio_0___Figuras_Geometricas
{
    // Nivel 1
    public abstract class Figura : IMover  // IMover - Nivel 4
    {
        private int x, y;
        private double areaFiguras;

        public Figura()
        {
        }

        public Figura(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            set{ x = value; }

            get{ return x; }
        }

        public int Y
        {
            set{ y = value; }

            get{ return y; } 

        }
            
        public double AreaFiguras
        {
            get{ return 0.0;}
        }


        // Nivel 2
        public override string ToString()
        {
            return "(" + x + "," + y + ")";
        }


        // Nivel 4
        public void Deslocar(int dx, int dy)
        {
            x += dx;
            y += dy;
        }
    }
}
