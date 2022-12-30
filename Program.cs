namespace BuildArrayfromPermutationCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

public class Solution
{
    public int[] BuildArray(int[] nums)
    {
        List<int> vals = new List<int>();
       
        foreach(var num in nums)
        {
            vals.Add(nums[num]);
        }
        return vals.ToArray();
    }
}