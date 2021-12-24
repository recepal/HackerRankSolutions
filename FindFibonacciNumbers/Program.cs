// See https://aka.ms/new-console-template for more information

var list = FindFibonacciNumbers();
Console.WriteLine(string.Join(",", list));


List<int> FindFibonacciNumbers()
{
    List<int> resultList = new ();

    for (int i = 0; i < 10; i++)
    {
        int result = FindFibonacci(i);
        resultList.Add(result);
    }

    return resultList;
}

int FindFibonacci(int number)
{
    if (number < 0) return 0;
    if (number == 0 || number == 1) return number;
    return (FindFibonacci(number - 1) + FindFibonacci(number - 2)); 
}