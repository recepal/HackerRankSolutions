
int[] nums = new int[] { 9, 7, 3 };
int result = findMissing(nums);

Console.WriteLine(result);

int findMissing(int[] nums)
{
    int result = 0;

    var ascList = nums.OrderBy(x => x).ToList();

    for (int i = 0; i < ascList.Count() - 1; i++)
    {
        int number = ascList[i] + 2;

        if (!ascList.Contains(number))
        {
            result = number;
            break;
        }
    }

    return result;
}