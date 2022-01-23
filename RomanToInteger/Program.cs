// See https://aka.ms/new-console-template for more information

RomanToInteger("III");

int RomanToInteger(string s)
{

    Dictionary<char, int> dict = new()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 },
    };

    var total = 0;
    var charList = s.ToCharArray();

    for (int i = charList.Length - 1; i >= 0; i--)
    {

        total += dict[charList[i]];
        if (i != 0)
        {
            if ((charList[i] == 'V' || charList[i] == 'X') && charList[i - 1] == 'I')
            {
                total -= 2;
            }
            if ((charList[i] == 'L' || charList[i] == 'C') && charList[i - 1] == 'X')
            {
                total -= 20;
            }
            if ((charList[i] == 'D' || charList[i] == 'M') && charList[i - 1] == 'C')
            {
                total -= 200;
            }

        }

    }

    return total;
}



