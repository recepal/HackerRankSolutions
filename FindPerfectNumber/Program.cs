// See https://aka.ms/new-console-template for more information


var list = FindPerfectNumber();
Console.WriteLine("1000'e kadar olan mükemmel sayılar: " + string.Join(",", list));


List<int> FindPerfectNumber()
{
    List<int> resultList = new();

    for (int i = 1; i <= 1000; i++)
    {
        int toplam = 0;
        for (int j = 1; j < i; j++)
        {
            if (i % j == 0)
            {
                toplam = toplam + j;
            }
        }

        if (toplam == i)
        {
            resultList.Add(i);
        }

    }

    return resultList;
}