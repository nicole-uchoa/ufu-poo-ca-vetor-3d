using System;

namespace caVetor3D
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] x = { 4, 5, 6 };
            double[] y = { 8, 6, 5 };
          
            Vetor2D vetor = new();
            Vetor3D v = new(3, 2, 1);
            Console.WriteLine(v.ModuloVetor(1, 2, 3));
            Console.WriteLine(vetor.ModuloVetor(1, 2));

            v.ProdutoVetorial(x, y);
            //v.SetZ(3);
            //Console.WriteLine(v.GetZ());

        }
    }
}
