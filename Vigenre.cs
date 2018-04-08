
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrypToolClone
{
    //key chi la cac chu cai in hoa;
    class Vigenere
    {
        private string nguon1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string nguon2 = "abcdefghijklmnopqrstuvwxyz";
        public string Encrypt(string mess, string key)
        {
            string results = "";
            int n = mess.Length,
                m = key.Length;
            int j = 0;
            for (int i = 0; i < n; i++)
            {

                if ((nguon1.IndexOf(mess[i])) >= 0)
                {
                    results += nguon1[(nguon1.IndexOf(mess[i]) + nguon1.IndexOf(key[j % m])) % 26];
                    j++;
                }
                else if ((nguon2.IndexOf(mess[i])) >= 0)
                {
                    results += nguon2[(nguon2.IndexOf(mess[i]) + nguon1.IndexOf(key[j % m])) % 26];
                    j++;
                }
                else
                    results += mess[i];

            }
            return results;
        }
        public string Decrypt(string mess, string key)
        {
            string results = "";
            int n = mess.Length,
                m = key.Length;
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if ((nguon1.IndexOf(mess[i])) >= 0)
                {
                    if ((nguon1.IndexOf(mess[i]) - nguon1.IndexOf(key[j % m])) < 0)
                        results += nguon1[(nguon1.IndexOf(mess[i]) + 26 - nguon1.IndexOf(key[j % m])) % 26];
                    else
                        results += nguon1[(nguon1.IndexOf(mess[i]) - nguon1.IndexOf(key[j % m])) % 26];
                    j++;
                }
                else if ((nguon2.IndexOf(mess[i])) >= 0)
                {
                    if ((nguon2.IndexOf(mess[i]) + nguon1.IndexOf(key[j % m])) < 0)
                        results += nguon2[(nguon2.IndexOf(mess[i]) + 26 - nguon1.IndexOf(key[j % m])) % 26];
                    else
                        results += nguon2[(nguon2.IndexOf(mess[i]) - nguon1.IndexOf(key[j % m])) % 26];
                    j++;
                }
                else
                    results += mess[i];

            }
            return results;
        }
    }

}
