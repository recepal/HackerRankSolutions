// See https://aka.ms/new-console-template for more information

FindOddNumber();

void FindOddNumber()
{
    int[] list = new int[] { 1, 3, 5, 7, 9, 13, 15, 17 };

    var minValue = list.ToList().OrderBy(f => f).FirstOrDefault();
    int result = 0;

    while (true)
    {
        if (list.Contains(minValue))
        {
            minValue += 2;
        }
        else
        {
            result = minValue;
            break;
        }
    }

    Console.WriteLine(result);
}



