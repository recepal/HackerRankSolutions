
string s = "07:05:45PM";
string result = timeConversion(s);

Console.WriteLine(result);

static string timeConversion(string s)
{
    string numStr = s.Substring(0, 2);
    int num = int.Parse(numStr);

    if (s.EndsWith("PM"))
    {
        if (num < 12)
        {
            num = num + 12;
            return num.ToString() + s.Substring(2, 6);
        }
        else
        {

            return s.Substring(0, 8);
        }
    }
    else
    {
        if (num >= 12)
        {
            num = num - 12;

            return num.ToString().PadLeft(2, '0') + s.Substring(2, 6);
        }
        else
        {

            return s.Substring(0, 8);
        }

    }
}