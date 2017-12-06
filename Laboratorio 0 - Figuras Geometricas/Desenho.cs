using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboratorio_0___Figuras_Geometricas
{
    // Nivel 3
    public delegate void Funcao();

    public class Desenho : IMover  // IMover - Nivel 4
    {
        public event Funcao changed;
        private Figura[] figuras;
        private int numeroFiguras;
        private const int NUMEROMAXIMOFIGURAS = 100;
        private double areaFiguras;
        private String titulo;

        public Desenho()
        {
            figuras = new Figura[NUMEROMAXIMOFIGURAS];
            numeroFiguras = 0;
        }

        public void AdicionarFigura(Figura figura)
        {
            if (numeroFiguras <= NUMEROMAXIMOFIGURAS)
                figuras[numeroFiguras++] = figura;
            onChanged();
        }

        public int NumeroFiguras
        {
            get { return numeroFiguras; }
        }

        public double AreaFiguras
        {
            get
            {
                double area = 0.0;
                for (int i = 0; i < numeroFiguras; i++)
                    area += figuras[i].AreaFiguras;

                return area;
            }
        }

        //Nivel 2
        public static bool operator ==(Desenho a, Desenho b)
        {
            for (int i = 0; i < a.figuras.Length; i++)
            {
                for (int e = 0; e < b.figuras.Length; e++)
                {
                    if (a.figuras[i].GetType().Equals(b.figuras[e].GetType()))
                    {
                        if (a.figuras[i].X.Equals(b.figuras[i].X) && a.figuras[i].Y.Equals(b.figuras[i].Y))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Desenho a, Desenho b)
        {
            for (int i = 0; i < a.figuras.Length; i++)
            {
                for (int e = 0; e < b.figuras.Length; e++)
                {
                    if (a.figuras[i].GetType().Equals(b.figuras[e].GetType()))
                    {
                        if (a.figuras[i].X.Equals(b.figuras[i].X) && a.figuras[i].Y.Equals(b.figuras[i].Y))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void onChanged()
        {
            if(changed != null){
                changed();
            }
        }


        // Nivel 4
        public String Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public void Deslocar(int dx, int dy)
        {
            for (int i = 0; i < numeroFiguras; i++)
                figuras[i].Deslocar(dx, dy);
        }


       
       

        public override string ToString()
        {
            string txt = "";

            txt += "Desenho:";
            for (int i = 0; i < numeroFiguras; i++)
                txt += "\nfig" + i + " - " + figuras[i].ToString();
            return txt;
        }



        // Nivel 5
        public void RemoverFigura(int indice)
        {
            if (indice >= 0 && indice < numeroFiguras)
            {
                for (int i = indice; i < numeroFiguras - 1; i++)
                    figuras[indice] = figuras[indice + 1];
                numeroFiguras--;
            }
            onChanged();
        }
    }
}

