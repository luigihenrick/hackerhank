namespace Core.Exercices.SuperDigit;

public class SuperDigit
{

    /*
     * Complete the 'superDigit' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING n
     *  2. INTEGER k
     */

    public static int Calculate(string n, int k)
    {
        var superDigit = CalculateSuperDigit(n.ToCharArray());
        
        return CalculateSuperDigit(Enumerable.Range(0, k).Select(i => (char)(superDigit + 48)));
    }
    
    private static int CalculateSuperDigit(IEnumerable<char> i)
    {
        Console.WriteLine($"Size of array {i.Count()} first char {i.First()}");
        if (i.Count() > 1)
        {
            return CalculateSuperDigit(i.Aggregate(0, (total, next) => total + int.Parse(next.ToString())).ToString().ToCharArray());
            //return CalculateSuperDigit(i.Sum(x => int.Parse(x.ToString())).ToString().ToCharArray());
        }
        
        return int.Parse(i.First().ToString());
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        string n = firstMultipleInput[0];

        int k = Convert.ToInt32(firstMultipleInput[1]);

        int result = SuperDigit.Calculate(n, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
