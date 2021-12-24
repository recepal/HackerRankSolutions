// See https://aka.ms/new-console-template for more information


var list = FindPrimeNumber();

Console.WriteLine(string.Join("," , list));


List<int> FindPrimeNumber()
{
    List<int> primeList = new ();
    

    for (int i = 2; i <= 1000; i++)
    {
        int control = 0;
        for (int j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                control++;
            }
        }

        if (control == 0)
        {
            primeList.Add(i);
        }
    }

    return primeList;
}