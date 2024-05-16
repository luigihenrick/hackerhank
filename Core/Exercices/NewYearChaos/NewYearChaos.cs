namespace Core.Exercices.NewYearChaos;

public class NewYearChaos
{

    /*
     * Complete the 'minimumBribes' function below.
     *
     * The function accepts INTEGER_ARRAY q as parameter.
     */

    public static string MinimumBribes(List<int> q)
    {
        var numberOfBribes = GetBribes(q.ToArray());

        var result = numberOfBribes == -1 ? "Too chaotic" : numberOfBribes.ToString();
        
        Console.WriteLine(result);

        return result;
    }

    private static int GetBribes(int[] array)
    {
        var numberOfbribes = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            var positionsChanged = 0;
            for (int j = i+1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    positionsChanged++;
                    numberOfbribes++;
                }
                
                if (array[j] > array[i] + 20)
                {
                    break;
                }
                
                if (positionsChanged > 2)
                {
                    return -1;
                }
            }
        }
        
        return numberOfbribes;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

            NewYearChaos.MinimumBribes(q);
        }
    }
}
