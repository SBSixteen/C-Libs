using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;

namespace C__Libs
{
    public class OneSixMath
    {
        private static float PI_2 = 1.5707964f;
        private static float PI = 3.1415926f;

        public static int Max(int a, int b)
        {
            return (a >= b ? 1 : 0) * a + b * (b > a ? 1 : 0);
        }
        public static int Min(int a , int b)
        {
            return (a >= b ? 1 : 0) * b + a * (b > a ? 1 : 0);
        }
        public static double Avg(params IEnumerable<int>[] parameters)
        {
            double sum = 0.0;
            double iter = 0.0;
            foreach (IEnumerable<int> t in parameters)
            {
                foreach (int t2 in t)
                {
                    sum = sum + t2;
                    iter++;
                }
            }

            return sum/iter;
        }
        public static double Avg(params IEnumerable<double>[] parameters)
        {
            double sum = 0.0;
            double iter = 0;
            foreach (IEnumerable<double> t in parameters)
            {
                foreach (double t2 in t)
                {
                    sum = sum + t2;
                    iter++;
                }
            }
            return sum/iter;
        }
        public static float Avg(params IEnumerable<float>[] parameters)
        {
            float sum = 0.0f;
            float iter = 0.0f;
            foreach (IEnumerable<float> t in parameters)
            {
                foreach (float t2 in t)
                {
                    sum = sum + t2;
                    iter++;
                }
            }
            return sum/iter;
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

            foreach (double i in parameters)
            {
                sum += i;
            }

            return sum / parameters.Length;

        }
        public static float Avg(params float[] parameters)
        {

            float sum = 0;

            foreach (float i in parameters)
            {
                sum += i;
            }

            return sum / parameters.Length;

        }
        public static double Sum(params IEnumerable<int>[] parameters)
        {
            double sum = 0.0;
            foreach(IEnumerable<int> t in parameters)
            {
                foreach (int t2 in t)
                {
                    sum = sum + t2;
                }
            }

            return sum;
        }        
        public static double Sum(params IEnumerable<double>[] parameters)
        {
            double sum = 0.0;
            foreach(IEnumerable<double> t in parameters)
            {
                foreach (double t2 in t)
                {
                    sum = sum + t2;
                }
            }
            return sum;
        }
        public static float Sum(params IEnumerable<float>[] parameters)
        {
            float sum = 0.0f;
            foreach (IEnumerable<float> t in parameters)
            {
                foreach (float t2 in t)
                {
                    sum = sum + t2;
                }
            }
            return sum;
        }
        public static double Sum(params int[] parameters)
        {
            double sum = 0.0;
            foreach (int t in parameters)
            {
                sum += t;
            }
            return sum;
        }
        public static double Sum(params double[] parameters)
        {
            double sum = 0.0;
            foreach (double t in parameters)
            {
                sum += t;
            }
            return sum;
        }
        public static float Sum(params float[] parameters)
        {
            float sum = 0.0f;
            float iter = 0.0f;
            foreach (float t in parameters)
            {
                sum += t;

            }
            return sum;
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
        public static float Abs(float a)
        {
            return (a < 0 ? -1 : 1) * a;
        }
        public static double Abs(double a)
        {
            return (a < 0 ? -1 : 1) * a;
        }
        public static Dictionary<T, int> MakeFreqDictionary<T>(params T[] parameters)
        {
            Dictionary<T, int> dupes = new();

            foreach (T i in parameters)
            {
                _ = dupes.ContainsKey(i) ? dupes[i]++ : dupes[i] = 1;
            }

            return dupes;
        }
        public static Dictionary<T, int> MakeFreqDictionary<T>(bool print, params T[] parameters)
        {
            Dictionary<T, int> dupes = new();

            foreach (T i in parameters)
            {
                _ = dupes.ContainsKey(i) ? dupes[i]++ : dupes[i] = 1;
            }

            _ = print ? printdictionary(dupes) : 0;

            return dupes;
        }
        public static Dictionary<T, int> MakeDuplicateDictionary<T>(params T[] parameters)
        {
            var temp = MakeFreqDictionary<T>(parameters);

            foreach (KeyValuePair<T, int> kvp in temp)
            {
                _ = 1 == kvp.Value ? temp.Remove(kvp.Key) : false;
            }

            return temp;
        }
        public static Dictionary<T, int> MakeDuplicateDictionary<T>(bool print, params T[] parameters)
        {

            var temp = MakeFreqDictionary<T>(parameters);

            foreach (KeyValuePair<T, int> kvp in temp)
            {
                _ = 1 == kvp.Value ? temp.Remove(kvp.Key) : false;
            }

            _ = print ? printdictionary(temp) : 0;

            return temp;

        }
        public static List<T> FindMostFrequent<T>(params T[] parameters)
        {
            List<T> list = new List<T>();
            var temp = MakeDuplicateDictionary<T>(parameters);
            int max = 0;

            foreach (KeyValuePair<T, int> kvp in temp)
            {
                max = Max(max, kvp.Value);
            }

            foreach (KeyValuePair<T, int> kvp in temp)
            {
                _ = kvp.Value == max ? listaddhehe<T>(list, kvp.Key): nothing();
            }

            return list;
        }
        public static List<T> FindMostFrequent<T>(bool print,params T[] parameters)
        {
            List<T> list = new List<T>();
            var temp = MakeDuplicateDictionary<T>(parameters);
            int max = 0;

            foreach (KeyValuePair<T, int> kvp in temp)
            {
                max = Max(max, kvp.Value);
            }

            foreach (KeyValuePair<T, int> kvp in temp)
            {
                _ = kvp.Value == max ? listaddhehe<T>(list, kvp.Key) : nothing();
            }

            _ = print ? printlist(list) : 0;

            return list;
        }
        public static List<T> FindUniques<T>(params T[] parameters)
        {
            var temp = MakeFreqDictionary<T>(parameters);

            List<T> values = new List<T>();

            foreach (KeyValuePair<T, int> kvp in temp)
            {
                _ = kvp.Value == 1 ? listaddhehe<T>(values, kvp.Key) : nothing();
            }

            return values;
        }
        public static float ATan2(float y, float x)
        {
            float res = .0f;

            //Very easy to predict? Maybe
            if (x == 0)
            {
                res = (y > 0.0f ? 1 : -1) * PI_2;
                res = (y == 0 ? 0 : 1) * res;
                return res;
            }

            res = (Abs(x) > Abs(y)) ? 0.0f : PI_2; 
            res = (res == PI_2) ? (y > 0 ? PI_2 : -PI_2)+-approxatan(x/y) : 0;
            res = (res == 0 && x < 0) ? (y >= 0 ? approxatan(y / x)+PI : approxatan(y / x) - PI) : res;
            res = (res == 0 && x > 0) ? approxatan(y / x) : res;

            return res;
        }
        public static IEnumerable<int> GenerateIntCollection(int start, int end)
        {
            List<int> result = new List<int>();

            while (start <= end)
            {
                result.Add(start);
                start++;
            }

            return result;
        }
        public static IEnumerable<float> GenerateFloatCollection(float start, float end, float increments)
        {
            List<float> result = new List<float>();

            while (start <= end)
            {
                result.Add(start);
                start+=increments;
            }

            return result;
        }
        public static IEnumerable<double> GenerateDoubleCollection(double start, double end, double increments)
        {
            List<double> result = new List<double>();

            while (start <= end)
            {
                result.Add(start);
                start+=increments;
            }

            return result;
        }
        
        //<privates>
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
        private static int printlist<T>(List<T> A)
        {
            foreach (T kvp in A)
            {
                Console.WriteLine(kvp);
            }

            return 0;
        }
        private static int listaddhehe<T>(List<T> here, T a)
        {
            here.Add(a);
            return 1;
        }
        private static float approxatan(float z)
        {
            const float n1 = 0.97239411f;
            const float n2 = -0.19194795f;
            return (n1 + n2 * z * z) * z;
        }
        private static int nothing()
        {
            //How miserable of you to end up using this.
            return 1;
        }
        
        //NotMine
        public static float ApproxAtan2(float y, float x)
        {
            //<DSPRelated ATan2>
            if (x != 0.0f)
            {
                if (OneSixMath.Abs(x) > OneSixMath.Abs(y))
                {
                    float z = y / x;
                    if (x > 0.0)
                    {
                        // atan2(y,x) = atan(y/x) if x > 0
                        return approxatan(z);
                    }
                    else if (y >= 0.0)
                    {
                        // atan2(y,x) = atan(y/x) + PI if x < 0, y >= 0
                        return approxatan(z) + PI;
                    }
                    else
                    {
                        // atan2(y,x) = atan(y/x) - PI if x < 0, y < 0
                        return approxatan(z) - PI;
                    }
                }
                else // Use property atan(y/x) = PI/2 - atan(x/y) if |y/x| > 1.
                {
                    float z = x / y;
                    if (y > 0.0)
                    {
                        // atan2(y,x) = PI/2 - atan(x/y) if |y/x| > 1, y > 0
                        return -approxatan(z) + PI_2;
                    }
                    else
                    {
                        // atan2(y,x) = -PI/2 - atan(x/y) if |y/x| > 1, y < 0
                        return -approxatan(z) - PI_2;
                    }
                }
            }
            else
            {
                if (y > 0.0f) // x = 0, y > 0
                {
                    return PI_2;
                }
                else if (y < 0.0f) // x = 0, y < 0
                {
                    return -PI_2;
                }
            }
            return 0.0f; // x,y = 0. Could return NaN instead.
        }
    }
}
