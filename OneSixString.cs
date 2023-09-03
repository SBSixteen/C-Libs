namespace C__Libs
{
    public class OneSixString
    {
        public static string Concat(IEnumerable<string> Input)
        {
            string res = "";

            foreach (string input in Input)
            {
                res += input;
            }

            return res;
        }
        public static string Concat(IEnumerable<char> Input)
        {
            string res = "";

            foreach (char input in Input)
            {
                res += input;
            }

            return res;
        }
        public static string Koncat(IEnumerable<string> Input, char dellimeter)
        {
            string res = "";

            foreach (string input in Input)
            {
                res += input;
                res+= dellimeter;
            }

            return res;
        }        
        public static string Koncat(IEnumerable<string> Input, string dellimeter)
        {
            string res = "";

            foreach (string input in Input)
            {
                res += input;
                res+= dellimeter;
            }

            return res;
        }
        public static string Koncat(IEnumerable<char> Input, char dellimeter)
        {
            string res = "";

            foreach (char input in Input)
            {
                res += input;
                res += dellimeter;
            }

            return res;
        }        
        public static string Koncat(IEnumerable<char> Input, string dellimeter)
        {
            string res = "";

            foreach (char input in Input)
            {
                res += input;
                res += dellimeter;
            }

            return res;
        }
        public static IList<String> Split(string Input, char delimeter)
        {
            List<string> res = new List<string>();
            string temp = string.Empty;

            foreach (char i in Input)
            {
                if (i == delimeter)
                {
                    res.Add(temp);
                    temp = string.Empty;
                    continue;
                }

                temp += i;
            }

            if (!temp.Equals(string.Empty))
            {
                res.Add(temp);
            }

            return res;
        }
        public static IList<String> Split(string Input, string delimeter)
        {
            List<string> res = new List<string>();
            string temp = string.Empty;
            string cut = string.Empty;

            foreach (char i in Input)
            {
                if (temp.Length >= delimeter.Length 
                     && temp[(temp.Length - delimeter.Length)..temp.Length] == delimeter)
                {
                    cut = temp[0..(temp.Length - delimeter.Length)];
                    if (!cut.Equals(string.Empty)) {
                        res.Add(temp[0..(temp.Length - delimeter.Length)]);
                        temp = "" + i;
                        continue;
                    }
                    temp = string.Empty;
                }

                temp += i;
            }

            if (!temp[0..(temp.Length - delimeter.Length)].Equals(string.Empty)) {
                if (temp[(temp.Length - delimeter.Length)..temp.Length] == delimeter) {
                    res.Add(temp[0..(temp.Length - delimeter.Length)]);
                    return res;
                }
            }
            res.Add(temp);
            return res;
        }
        public static string Replace(string input, string delimeter)
        {
            var x = Split(input, delimeter);
            return Concat(x);
        }
        public static IList<int> AsciiMap(string input)
        {
            IList<int> res = new List<int>();

            foreach (char i in input)
            {
                res.Add((int)i);
            }

            return res;
        }
    }
}
