using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor3D
{
    class Vetor3D : Vetor2D
    {
        private double z;

        //construtores
        public Vetor3D()
        {
            double[] z = Array.Empty<double>();
        }
        public Vetor3D(double x, double y, double z) : base(x, y)
        {
            double[] v = { x, y, z };
        }

        public void SetZ(double _z)
        {
            z = _z;
        }
        public double GetZ()
        {
            return z;
        }
        public double ModuloVetor(double x, double y, double z)
        {
            double[] v = new double[] { x, y, z };
            double a = 0;
            for (int i = 0; i < v.Length; i++)
            {
                a += Math.Pow(v[i], 2);
            }
            double mv = Math.Sqrt(a);
            return mv;
        }
        public override double AnguloVetores(double[] x, double[] y)
        {
            double a = ProdutoEscalar(x, y) / (ModuloVetor(x[0], x[1], x[2]) * ModuloVetor(y[0], y[1], y[2]));
            double r = Math.Acos(a);
            return r;
        }
        public void ProdutoVetorial(double[] x, double[] y)
        {
            double[] pv = new double[3];
            pv[0] = (x[2] * y[1]) - (x[1] * y[2]);
            pv[1] = (x[0] * y[2]) - (x[2] * y[0]);
            pv[2] = (x[1] * y[0]) - (x[0] * y[1]);

            for (int i = 0; i < pv.Length; i++)
            {
                Console.WriteLine(pv[i]);
            }

        }
    }
}
