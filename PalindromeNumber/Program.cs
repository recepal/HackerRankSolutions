
Console.WriteLine("Hello, World!");

IsPalindrome(1234567899);

bool IsPalindrome(int x)
{
    bool result = false;

    var charList = x.ToString().ToCharArray();

    if (charList.Any(f => !Char.IsNumber(f)))
    {
        return false;
    }

    List<char> newList = new();

    for (int i = charList.Length-1; i >= 0; i--)
    {
        newList.Add(charList[i]);
    }

   var newNumber = double.Parse(newList.ToArray());

    if (x == newNumber)
    {
        result = true;
    }

    return result;
}