using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1.Class
{
    public static class Transformations
    {
        public static double[] ConvertToMatrix(this Point p)
        {
            return new double[] { p.X, p.Y, 1 };
        }

        public static Point MulMatrix(double[,] matrix1, double[] matrix2)
        {
            double[] matrixRs;
            matrixRs = new double[3];

            int dem = 0;
            for (int i = 0; i < 3; i++)
            {
                matrixRs[i] = matrix2[0] * matrix1[0, dem] + matrix2[1] * matrix1[1, dem] + matrix2[2] * matrix1[2, dem];
                dem++;
            }

            Point pt = new Point(Convert.ToInt16(matrixRs[0]), Convert.ToInt16(matrixRs[1]));
            return pt;
        }

        public static Point TinhTien(Point p1,int x,int y)
        {
            double[,] matrix1=new double[3,3];
            matrix1[0, 0] = 1;
            matrix1[0, 1] = 0;
            matrix1[0, 2] = 0;
            matrix1[1, 0] = 0;
            matrix1[1, 1] = 1;
            matrix1[1, 2] = 0;
            matrix1[2, 0] = x;
            matrix1[2, 1] = y;
            matrix1[2, 2] = 1;

            double[] matrix2 = ConvertToMatrix(p1);

            //System.p
            //Console.WriteLine(MulMatrix(matrix1, matrix2).X);
            return MulMatrix(matrix1, matrix2);
        }

        public static Point BienDoiTyLe(Point p1, int x, int y)
        {
            double[,] matrix1 = new double[3, 3];
            matrix1[0, 0] = x;
            matrix1[0, 1] = 0;
            matrix1[0, 2] = 0;
            matrix1[1, 0] = 0;
            matrix1[1, 1] = y;
            matrix1[1, 2] = 0;
            matrix1[2, 0] = 0;
            matrix1[2, 1] = 0;
            matrix1[2, 2] = 1;

            double[] matrix2 = ConvertToMatrix(p1);

            //System.p
           // Console.WriteLine(MulMatrix(matrix1, matrix2).X);
            return MulMatrix(matrix1, matrix2);
        }

        public static Point Quay(Point p1, Point p2, int alpha)
        {
            double s = Math.Sin((Math.PI * alpha) / 180),
                    c = Math.Cos((Math.PI * alpha) / 180);
            
            p1 = TinhTien(p1, -p2.X, -p2.Y);

            double[,] matrix1 = new double[3, 3];
            matrix1[0, 0] = c;
            matrix1[0, 1] = -s;
            matrix1[0, 2] = 0;
            matrix1[1, 0] = s;
            matrix1[1, 1] = c;
            matrix1[1, 2] = 0;
            matrix1[2, 0] = 0;
            matrix1[2, 1] = 0;
            matrix1[2, 2] = 1;

            double[] matrix2 = ConvertToMatrix(p1);
            p1 = MulMatrix(matrix1, matrix2);
            p1 = TinhTien(p1, p2.X, p2.Y);



            return p1 ; 
            
        }

        public static Point LayDoiXungOx(Point p1)
        {
            double[,] matrix1 = new double[3, 3];
            matrix1[0, 0] = 1;
            matrix1[0, 1] =0;
            matrix1[0, 2] = 0;
            matrix1[1, 0] = 0;
            matrix1[1, 1] = -1;
            matrix1[1, 2] = 0;
            matrix1[2, 0] = 0;
            matrix1[2, 1] = 0;
            matrix1[2, 2] = 1;

            double[] matrix2 = ConvertToMatrix(p1); 
            return MulMatrix(matrix1, matrix2);
        }

        public static Point LayDoiXungOy(Point p1)
        {
            double[,] matrix1 = new double[3, 3];
            matrix1[0, 0] = 1;
            matrix1[0, 1] = 0;
            matrix1[0, 2] = 0;
            matrix1[1, 0] = 0;
            matrix1[1, 1] = -1;
            matrix1[1, 2] = 0;
            matrix1[2, 0] = 0;
            matrix1[2, 1] = 0;
            matrix1[2, 2] = 1;

            double[] matrix2 = ConvertToMatrix(p1);
            return MulMatrix(matrix1, matrix2);
        }

        public static Point LayDoiXungO(Point p1)
        {
            double[,] matrix1 = new double[3, 3];
            matrix1[0, 0] = 1;
            matrix1[0, 1] = 0;
            matrix1[0, 2] = 0;
            matrix1[1, 0] = 0;
            matrix1[1, 1] = -1;
            matrix1[1, 2] = 0;
            matrix1[2, 0] = 0;
            matrix1[2, 1] = 0;
            matrix1[2, 2] = 1;

            double[] matrix2 = ConvertToMatrix(p1);
            return MulMatrix(matrix1, matrix2);
        }
    }
}
