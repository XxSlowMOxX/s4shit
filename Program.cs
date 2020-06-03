using System;

namespace s4shit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Matrix m = new Matrix(new int[4,3]);
            Console.WriteLine(m.c.ToString());
        }
    }
    public class Matrix
    {
        public readonly Tuple<int, int> dim;
        public int[,] c{ get; set; }
        public Matrix(int[,]cont)
        {
            c = cont;
            dim = new Tuple<int, int>(c.GetLength(0), c.GetLength(1));
        }
        
    }
    public class Vector
    {
        public readonly int dim;
        public float[] v;
        public Vector(float[] vectorList)
        {
            dim = vectorList.Length;
        }
        public static Vector operator *(Matrix m1, Vector v1)
        {
            if(m1.dim.Item1 != v1.dim)
            {
                throw new FormatException("Vector Dimension does not Match Matrix Dimension");
            }
            float[] returnVector = new float[m1.c.GetLength(0)];
            for (int row = 0; row < m1.c.GetLength(0); row++)
            {

            }
            return new Vector(new float[10]);
        }
    }

    
}
