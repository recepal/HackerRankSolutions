

IsValid("{[]}");

bool IsValid(string s)
{
    Stack<char> sign = new Stack<char>();

    foreach (var item in s.ToCharArray())
        if (item == '(')
            sign.Push(')');
        else if (item == '[')
            sign.Push(']');
        else if (item == '{')
            sign.Push('}');
        else if (sign.Count == 0 || sign.Pop() != item)
            return false;

    return sign.Count == 0;
}

//Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

//An input string is valid if:

//Open brackets must be closed by the same type of brackets.
//Open brackets must be closed in the correct order.