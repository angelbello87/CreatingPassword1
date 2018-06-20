using System;
namespace CreatingPasswordsI
{
    class Program
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            while(t!=0)
            {
                string s = Console.ReadLine();
                string ans="";                
                for (int i = 7; i < s.Length; i++)
                {
                    if (s[i] == ' ')
                        ans += "*";
                    else
                        ans += s[i];
                }                
                Console.WriteLine(s[0].ToString() + s[1].ToString() + s[2].ToString() + ans + s[3] + s[4] + s[5]);
                t--;
            }
        }
    }
}
