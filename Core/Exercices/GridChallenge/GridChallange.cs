namespace Core.Exercices.GridChallenge;

public class GridChallenge
{

    /*
     * Complete the 'gridChallenge' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING_ARRAY grid as parameter.
     */

    public static string Calculate(List<string> grid)
    {
        Console.WriteLine($"Input = {string.Join(',', grid)}");
        int stringSize = grid[0].Length;
        
        var orderedRows = grid.Select(s => 
        {
            char[] result = s.ToCharArray();
            for(int i = 0; i < stringSize - 1; i++)
            {
                for (int j = 0; j < stringSize - i - 1; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        var temp =  result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }
            return new string(result);
        }).ToList();
        
        Console.WriteLine($"Ordered rows result = {string.Join(',', orderedRows)}");
        
        for (int row = 0; row < orderedRows.Count() - 1; row++)
        {
            for (int j = 0; j < stringSize; j++)
            {
                if (orderedRows[row][j] > orderedRows[row+1][j])
                {
                    Console.WriteLine($"Comparing {orderedRows[row][j]} with {orderedRows[row+1][j]} returned NO");
                    return "NO";
                }
            }
        }
        
        return "YES";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> grid = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid.Add(gridItem);
            }

            string result = GridChallenge.Calculate(grid);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
