namespace C__Libs
{
    public class OneSixUtils
    {
        public static void PrintCollection<T>(IEnumerable<T> input)
        {
            int i = 0;
            string res = string.Empty;

            for (i = 0; i < input.Count() - 1; i++)
            {
                res += (input.ElementAt(i));
                res += (' ');
            }

            res += (input.ElementAt(i));
            Console.WriteLine(res);
        }
        public static void PrintCollection<T>(char delimeter, IEnumerable<T> input)
        {
            int i = 0;
            string res = string.Empty;

            for (i = 0; i<input.Count()-1; i++)
            {
                res+=(input.ElementAt(i));
                res+=(delimeter);
            }

            res+=(input.ElementAt(i));
            Console.WriteLine(res);
        }
        public static void PrintCollection<T>(string delimeter, IEnumerable<T> input)
        {
            int i = 0;
            string res = string.Empty;

            for (i = 0; i < input.Count() - 1; i++)
            {
                res += (input.ElementAt(i));
                res += (delimeter);
            }

            res += (input.ElementAt(i));
            Console.WriteLine(res);
        }
        public static void PrintCollections<T>(params IEnumerable<T>[] parameters)
        {
            string res = string.Empty;
            int i = 0;

            foreach (IEnumerable<T> item in parameters)
            {
                for (i = 0; i < item.Count() - 1; i++)
                {
                    res += (item.ElementAt(i));
                    res += " ";
                }
                res+= (item.ElementAt(i));
                res += '\n';
                i = 0;
            }

            Console.WriteLine(res);
        }
        public static void PrintCollections<T>(char delimeter, params IEnumerable<T>[] parameters)
        {
            string res = string.Empty;
            int i = 0;
            
            foreach (IEnumerable<T> item in parameters)
            {
                for (i = 0; i < item.Count() - 1; i++)
                {
                    res += (item.ElementAt(i));
                    res += (delimeter);
                }
                res += (item.ElementAt(i));
                res += '\n';
                i = 0;
            }

            Console.WriteLine(res);
        }
        public static void PrintCollections<T>(string delimeter, params IEnumerable<T>[] parameters)
        {
            string res = string.Empty;
            int i = 0;

            foreach (IEnumerable<T> item in parameters)
            {
                for (i = 0; i < item.Count() - 1; i++)
                {
                    res += (item.ElementAt(i));
                    res += (delimeter);
                }
                res += (item.ElementAt(i));
                res += '\n';
                i = 0;
            }

            Console.WriteLine(res);
        }
        
    }
}
