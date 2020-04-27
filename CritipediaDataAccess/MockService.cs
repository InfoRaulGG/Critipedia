using System;
using System.Text;

namespace CritipediaDataAccess
{
    public static class MockService
    {
        public static string GenerateRandomString(int size)
        {
            StringBuilder build = new StringBuilder();
            Random rand = new Random();
            char c = new char();

            for (int i = 0; i < size; i++)
            {
                c = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rand.NextDouble() + 65)));
                
                build.Append(c);
   
            }

            if (String.IsNullOrEmpty(build.ToString()))
            {
                build.Append("Hello World");  
            }

            string result = char.ToUpper(build.ToString()[0]) + build.ToString().Substring(1);

            return result;
        }

        public static string GeneratePhoneNumber()
        {
            Random random = new Random();
            string r = "";
            int i;
            for (i = 1; i < 11; i++)
            {
                r += random.Next(0, 9).ToString();
            }
            return r;
        }
    }
}
