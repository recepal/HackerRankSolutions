// See https://aka.ms/new-console-template for more information

FindCharDifference();

void FindCharDifference()
{
    string str = "AAABAB";

    char[] charArr = str.ToCharArray();

    int countA = 0;
    int countB = 0;

    foreach (char ch in charArr)
    {
        if (ch == 'A')
        {
            countA++;
        }
        else
        {
            countB++;
        }
    }

    Console.WriteLine(Math.Abs(countA - countB));
}

