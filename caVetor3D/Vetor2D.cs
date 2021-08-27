using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor3D
{
    class Vetor2D
    {
        protected double x;
        protected double y;

        //construtor 
        public Vetor2D()
        {
            double[] v = Array.Empty<double>();

        }
        public Vetor2D(double x, double y)
        {
            double[] v = new double[] { x, y };
        }
        //get e set
        public void SetX(double _x)
        {
            x = _x;
        }
        public void SetY(double _y)
        {
            y = _y;
        }
        public double GetX()
        {
            return x;
        }
        public double GetY()
        {
            return y;
        }

        //métodos
        public double ProdutoEscalar(double[] x, double[] y)
        {
            double pe = 0;
            for (int i = 0; i < y.Length; i++)
            {
                pe += x[i] + y[i];
            }
            return pe;
        }
        public double ModuloVetor(double x, double y)
        {
            double[] v = new double[] { x, y };
            double a = 0;
            for (int i = 0; i < v.Length; i++)
            {
                a += Math.Pow(v[i], 2);
            }
            double mv = Math.Sqrt(a);
            return mv;
        }
        public virtual double AnguloVetores(double[] x, double[] y)
        {
            double a = ProdutoEscalar(x, y) / (ModuloVetor(x[0], x[1]) * ModuloVetor(y[0], y[1]));
            double r = Math.Acos(a);
            return r;
        }

        public void VetorProjecao(double[] x, double[] y)
        {
            int l = y.Length;
            double[] proj = new double[l];
            double p1 = ProdutoEscalar(x, y) / (Math.Pow(ModuloVetor(y[0], y[1]), 2));
            Console.Write("v[] = { ");
            for (int i = 0; i < l; i++)
            {
                proj[i] = p1 * y[i];
                Console.Write(proj[i] + " ");
            }
            Console.WriteLine("}");
        }
    }
}
