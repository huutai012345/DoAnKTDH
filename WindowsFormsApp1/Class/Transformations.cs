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

            return MulMatrix(matrix1, matrix2);
        }

        

    }
}
