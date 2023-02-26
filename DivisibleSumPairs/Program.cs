DivisibleSumPairs(6, 3, new List<int>() { 1, 3, 2, 6, 1, 2 });

void DivisibleSumPairs(int n, int k, List<int> ar)
{
    int result = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            if ((ar[i] + ar[j]) % k == 0)
            {
                result++;
            }
        }
    }

    Console.WriteLine(result);
}