using System;
using System.IO;

class Program
{
    static void Main()
    {
        int maxLen = 0;
        int curLen = 0;

        using (StreamReader f = new StreamReader("C:\\Users\\igorc\\OneDrive\\Рабочий стол\\24.txt"))
        {
            string s = f.ReadToEnd();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'X')
                {
                    curLen++;
                    if (curLen > maxLen)
                        maxLen = curLen;
                }
                else
                {
                    curLen = 0;
                }
            }
        }

        Console.WriteLine(maxLen);
    }
}


