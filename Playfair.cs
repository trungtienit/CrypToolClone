
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrypToolClone
{
    class Playfair
    {
        private string sources5x5 = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
        private string sources6x6 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private string[,] key;
        private int n;

        public int N { get => n; set => n = value; }

        public string[,] getkey()
        {
            return key;
        }

        public void setKey(string src)
        {
            key = new string[n, n];
            int tmp = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    key[i, j] = src[tmp].ToString();
                    tmp++;
                }
            }
        }
        public string getSrc()
        {
            return n == 5 ? sources5x5 : sources6x6;
        }


        public void CreateKey(string str)
        {
            str = str.Replace(" ", "");
            if(n==5)
                str= str.Replace("J", "I");
            string tmp = "";
            string matrix = getSrc();

            //matrix.IndexOf(key[i]) != -1 &&
            for (int i = 0; i < str.Length; i++)
            {
                if (tmp.IndexOf(str[i]) == -1)
                {
                    matrix = matrix.Remove(matrix.IndexOf(str[i].ToString()), 1);
                    tmp += str[i];
                }
            }
            setKey(tmp + matrix);

        }
        public int[] FindPosition(string str)
        {
            int[] a = new int[2];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (key[i, j] == str)
                    {
                        a[0] = i;
                        a[1] = j;
                        break;
                    }
                }
            }
            return a;
        }

        public int FindCase(string a, string b)
        {
            int[] texta = FindPosition(a);
            int[] textb = FindPosition(b);
            if (texta[0] == textb[0])
                return 0;
            if (texta[1] == textb[1])
                return 1;
            return -1;
        }

        public string Encrypt(string text)
        {

            string result = "";
            for (int i = 0; i < text.Length; i += 2)
            {
                int[] text1 = FindPosition(text[i].ToString());
                int[] text2 = FindPosition(text[i + 1].ToString());
                switch (FindCase(text[i].ToString(), text[i + 1].ToString()))
                {
                    //cung hang
                    case 0:
                        result += key[text1[0], (text1[1] + 1) % n] + key[text2[0], (text2[1] + 1) % n];
                        break;
                    //cung cot
                    case 1:
                        result += key[(text1[0] + 1) % n, text1[1]] + key[(text2[0] + 1) % n, text2[1]];
                        break;
                    //cheo
                    case -1:
                        result += key[text1[0], text2[1]] + key[text2[0], text1[1]];
                        break;
                }
            }
            return result;
        }
        //giải mã
        public string Decrypt(string text)
        {

            string result = "";
            for (int i = 0; i < text.Length; i += 2)
            {
                int[] text1 = FindPosition(text[i].ToString());
                int[] text2 = FindPosition(text[i + 1].ToString());
                switch (FindCase(text[i].ToString(), text[i + 1].ToString()))
                {
                    case 0:
                        result += key[text1[0], (text1[1] - 1 + n) % n] + key[text2[0], (text2[1] - 1 + n) % n];
                        break;
                    case 1:
                        result += key[(text1[0] - 1 + n) % n, text1[1]] + key[(text2[0] - 1 + n) % n, text2[1]];
                        break;
                    case -1:
                        result += key[text1[0], text2[1]] + key[text2[0], text1[1]];
                        break;
                }
            }
            return result;
        }
    }
}
