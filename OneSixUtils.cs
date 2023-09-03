namespace C__Libs
{
    public class OneSixUtils
    {
        public static void PrintCollection<T>(IEnumerable<T> input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
        public static void PrintCollections<T>(params IEnumerable<T>[] parameters)
        {
            foreach (IEnumerable<T> item in parameters)
            {
                foreach (var p in item)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            } 
        }
        
    }
}
