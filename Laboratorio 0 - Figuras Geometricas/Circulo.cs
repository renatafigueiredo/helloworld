﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboratorio_0___Figuras_Geometricas
{
    // Nivel 1
    public class Circulo : Figura
    {
        private int raio;
        private double areaFiguras;

        public Circulo()
        {
            raio = 1;
        }

        public Circulo(int raio)
        {
            this.raio = raio;
        }

        public Circulo(int x, int y, int raio)
            : base(x, y)
        {
            this.raio = raio;
        }

        public int Raio
        {
            set{ raio = value; }

            get{ return raio; }
        }


        public double AreaFiguras
        {
            get{ return Math.PI * raio * raio; }
        }

        // Nivel 2
        public override string ToString()
        {
            return base.ToString() + " R=" + raio;
        }

    }
}
