using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace C__Libs
{
    public class OneSixMath
    {

        public static int Max(int a, int b)
        {
            return (a >= b ? 1 : 0) * a + b*(b > a ? 1 : 0);
        }

        public static int Min(int a , int b)
        {
            return (a >= b ? 1 : 0) * b + a * (b > a ? 1 : 0);
        }

        public static double Avg(params int[] parameters)
        {

            double sum = 0;

            foreach (int i in parameters)
            {
                sum+= i;
            }

            return sum/parameters.Length;

        }

        public static double Avg(params double[] parameters)
        {

            double sum = 0;

            foreach (int i in parameters)
            {
                sum += i;
            }

            return sum / parameters.Length;

        }

        public static float Avg(params float[] parameters)
        {

            float sum = 0;

            foreach (int i in parameters)
            {
                sum += i;
            }

            return sum / parameters.Length;

        }

        public static int BinaryToInt(string S)
        {
            _ = (checkifstringbinary(S) ? 0 : throw new InvalidDataException("Supplied string is not binary!"));

            int a = 0;
            int b = 1;

            for (int i = S.Length-1; i > -1; i--)
            {
                a += (S[i] == '1' ? 1 : 0) * b;
                b = b << 1;
            }

            return a;
        }
    
        public static string IntToBinary(int input)
        {
            char[] result = new char[32];
            
            int index = result.Length-1;

            while (input > 0)
            {
                result[index] = (input % 2 == 0 ? '0' : '1');
                input = input / 2;
                index--;
            }

            return new string(result);
        }

        public static string Int32ToBinary(int input)
        {
            char[] result = new char[32];

            int index = result.Length - 1;

            while(index > -1)
            {
                result[index] = (input % 2 == 0 ? '0' : '1');
                input = input / 2;
                index--;
            }
            return new string(result);
        }

        public static int Abs(int a)
        {
            return (a < 0 ? -1 : 1) * a;
        }

        public static Dictionary<T, int> FindDuplicates<T>(params T[] parameters)
        {
            Dictionary<T, int> dupes = new();

            foreach (T i in parameters)
            {
                _ = dupes.ContainsKey(i) ? dupes[i]++ : dupes[i] = 1;
            }

            return dupes;
        }

        public static Dictionary<T, int> FindDuplicates<T>(bool print, params T[] parameters)
        {
            Dictionary<T, int> dupes = new();

            foreach (T i in parameters)
            {
                _ = dupes.ContainsKey(i) ? dupes[i]++ : dupes[i] = 1;
            }

            _ = print ? printdictionary(dupes) : 0;

            return dupes;
        }

        private static bool checkifstringbinary(string s)
        {
            int check = 0;
            int index = s.Length - 1;


            while (check == 0 && index > -1)
            {
                check = (s[index] == '1' || s[index] == '0') ? 0 : 1;
                index--;
            }

            return check == 0;
        }

        private static int printdictionary<T,G>(Dictionary<T,G> A)
        {
            foreach (KeyValuePair<T, G> kvp in A)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value);
            }

            return 0;
        }
    


    }
}
