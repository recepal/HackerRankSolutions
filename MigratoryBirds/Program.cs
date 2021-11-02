// See https://aka.ms/new-console-template for more information
List<int> arr = new List<int>() { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4, };

migratoryBirds(arr);

static int migratoryBirds(List<int> arr)
{
    Dictionary<int, int> numbers = new();

    foreach (int number in arr)
    {
        if (!numbers.Any(f => f.Key == number))
        {
            numbers.Add(number, arr.Count(f => f == number));
        }
    }

    List<KeyValuePair<int, int>>? list = numbers.Where(f => f.Value == numbers.Max(m => m.Value)).ToList();

    return list.OrderBy(f => f.Key).FirstOrDefault().Key;
}