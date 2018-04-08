
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrypToolClone
{
    class Hill
    {
        static string sources = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private int[,] matrix;
        private int[,] inverseMatrix;
        public string getsSources()
        {
            return sources;
        }

        public void setMatrix(int[,] Matrix)
        {
            matrix = Matrix;
        }


        public int[,] getMatrix()
        {
            return this.matrix;
        }

        //tính det bang de qui
        // Lay cot 0 lam chuan , nen j luc nao cung lon hon k.
        // 
        public int det(int[,] matrix, int n)
        {

            if (n == 1)
                return matrix[0, 0];
            if (n == 2)
                return (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]);

            int s, sum = 0;

            for (int k = 0; k < n; k++)
            {
                int[,] child = new int[n - 1, n - 1];
                for (int i = 0; i < n; i++)
                    for (int j = 1; j < n; j++)
                        if (i < k)
                            child[i, j - 1] = matrix[i, j];
                        else
                            if (i > k)
                            child[i - 1, j - 1] = matrix[i, j];
                if (k % 2 == 0)
                    s = 1;
                else
                    s = -1;

                sum += matrix[k, 0] * s * det(child, n - 1);
            }
            return sum;
        }
        //ma trận con
        public int con(int[,] matrix, int n, int h, int c)
        {
            int[,] child = new int[n - 1, n - 1];
            int temi = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (i == h)
                    temi = 1;
                int temj = 0;
                for (int j = 0; j < n - 1; j++)
                {
                    if (j == c)
                        temj = 1;
                    child[i, j] = matrix[i + temi, j + temj];
                }
            }
            if ((h + c) % 2 == 0)
                return det(child, n - 1);
            return -det(child, n - 1);
        }

        //tim ma tran nghich dao
        public int[,] Inverse()
        {
            int n = matrix.GetLength(0);
            if (det(matrix, n) == 0)
                return null;
            if (USCLN(det(matrix, n), 26) != 1)
                return null;
            int Det = det(matrix, n);
            if (Det < 0)
                while (Det < 0)
                    Det += 26;
            else
                Det = Det % 26;
            int t = 1;
            while ((Det * t) % 26 != 1)
                t++;
            if (n == 1)
            {
                int[,] a = new int[1, 1];
                a[0, 0] = t;
                return a;
            }
            inverseMatrix = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    inverseMatrix[i, j] = con(matrix, n, j, i);
                    if (inverseMatrix[i, j] < 0)
                    {
                        while (inverseMatrix[i, j] < 0)
                            inverseMatrix[i, j] = inverseMatrix[i, j] + 26;
                    }
                    else
                        inverseMatrix[i, j] = inverseMatrix[i, j] % 26;
                    inverseMatrix[i, j] = (inverseMatrix[i, j] * t) % 26;
                }
            return inverseMatrix;
        }
        public int USCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0 || b == 0)
                return a + b;
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }

        public string Print()
        {
            string text = "";
            if (matrix == null)
                return text;
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    text = text + matrix[i, j] + "\t";
                }
                text = text + "\r\n";
            }
            return text;
        }

        public static string ConvertCharToNumber(string text, int first)
        {
            if ((sources.IndexOf(text) + first) >= 0 && (sources.IndexOf(text) + first) <= 9)
                return "0" + (sources.IndexOf(text) + first).ToString();
            else
                return (sources.IndexOf(text) + first).ToString();
        }

        public static string ConverNumberToChar(string num, int first)
        {
            if (Int32.Parse(num) - first >= 0)
                return sources[Int32.Parse(num) - first].ToString();
            else
                return "Z";
        }

        public string Decrypt(string text, int first)
        {
            string ciper = "";
            int n = inverseMatrix.GetLength(0);
            int tem;
            for (int k = 0; k < text.Length - n + 1; k += n)
            {
                string c = text.Substring(k, n);
                for (int i = 0; i < n; i++)
                {
                    tem = 0;
                    for (int j = 0; j < n; j++)
                    {
                        tem = tem + (int)inverseMatrix[i, j] * Int32.Parse(ConvertCharToNumber(c[j].ToString(), first));
                    }
                    if (first == 1 && tem % 26 == 0)
                        ciper += "Z";
                    else
                        ciper += ConverNumberToChar((tem % 26).ToString(), first);
                }
            }
            return ciper;
        }

        public string Encrypt(string text, int first)
        {
            string ciper = "";
            int n = matrix.GetLength(0);
            int tem;
            for (int k = 0; k < text.Length - n + 1; k += n)
            {
                string c = text.Substring(k, n);
                for (int i = 0; i < n; i++)
                {
                    tem = 0;
                    for (int j = 0; j < n; j++)
                    {
                        tem = tem + (int)matrix[i, j] * Int32.Parse(ConvertCharToNumber(c[j].ToString(), first));
                    }
                    if (first == 1 && tem % 26 == 0)
                        ciper += "Z";
                    else
                        ciper += ConverNumberToChar((tem % 26).ToString(), first);
                }
            }
            return ciper;
        }
    }
}

