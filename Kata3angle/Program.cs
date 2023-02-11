using System.Numerics;

namespace Kata3angle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountBits());
        }

        public static int CountBits(int n)
        {
            var binaryNumber = string.Empty;
            int count = 0;

            while (n > 0)
            {
                binaryNumber = (n % 2) + binaryNumber;
                n /= 2;
            }

            char[] binaryChars = binaryNumber.ToCharArray();
            for(int i = 0; i < binaryChars.Length; i++)
            {
                if (binaryChars[i] == '1')
                    count++;
            }
            return count;
        }
    }
}