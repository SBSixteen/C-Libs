using C__Libs;

/*Console.WriteLine(OneSixMath.Min(-11, -3));
Console.WriteLine(OneSixMath.Avg(3,2,1,3,4,5,6,1,2,3,2,54,1,13));*/

//Console.WriteLine(OneSixMath.Int32ToBinary(49)); 
//Console.WriteLine(OneSixMath.IntToBinary(49));
//Console.WriteLine(OneSixMath.BinaryToInt("00000000000000000000000000110001"));
//Console.WriteLine(OneSixMath.BinaryToInt("110001"));
//Console.WriteLine(OneSixMath.Abs(-1974109));

int[] C = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15}; 
var D =OneSixMath.MakeFreqDictionary('F', 'C', 'A', 'F', 'F', 'B', 'F', 'A', 'C', 'C', 'A', 'C', 'B', 'C', 'C', 'A', 'B','D');
var F = OneSixMath.MakeDuplicateDictionary('F', 'C', 'A', 'F', 'F', 'B', 'F', 'A', 'C', 'C', 'A', 'C', 'B', 'C', 'C', 'A', 'B', 'D');
//OneSixUtils.PrintCollections(F, D);
Console.WriteLine(OneSixMath.Sum(C));
float y = 0;
float x = 0;

Random rnd = new Random();
float mine, their;
List<float> nums = new();

var watch = new System.Diagnostics.Stopwatch();

watch.Start();


for (int i = 0; i <1000000; i++)
{
    y = (float)rnd.NextDouble()*99;
    x = (float)rnd.NextDouble()*99;

    mine = (float)OneSixMath.ApproxAtan2(y, x);
}

watch.Stop();
Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

//Time for my One Million Calculations of ATan2 => 43ms
//Time for C# One Million Calculations of ATan2 => 28ms
//Time for DSPRelated One Million Calculations of ATan2 => 37ms

//Time for my Ten Million Calculations of ATan2 => 442ms
//Time for C# Ten Million Calculations of ATan2 => 287ms
//Time for DSPRelated Ten Million Calculations of ATan2 => 385ms