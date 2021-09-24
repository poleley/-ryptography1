using System;
using System.IO;

namespace Тасование_Фишера_Йетса
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int n = 33;
            char[] abc = new char[n];
            int j = 0;
            for (int i = 'а'; i <= 'е'; ++i)
            {
                abc[j] = (char)i;
                j++;
            }
            abc[j] = 'ё';
            j++;
            for (int i = 'ж'; i <= 'я'; ++i)
            {
                abc[j] = (char)i;
                j++;
            }

            char[] res = new char[n];

            while (n > 0)
            {
                n = n - 1;
                j = rnd.Next(0, n);
                res[n] = abc[j];
                abc[j] = abc[n];
            }

                 for (int k = 0; k < 33; ++k)
                   Console.WriteLine(res[k]);

            string path = "key.txt";
            try
            {
                for (int k = 0; k < 33; ++k)
                    using (StreamWriter stream = new StreamWriter(path, true, System.Text.Encoding.UTF8))
                        stream.WriteLine(res[k]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
