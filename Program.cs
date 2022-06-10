int GetValueNullNatural(string text)
{
    string getValue = String.Empty;
    int value = 0;
    bool correct = false;
    while (!correct)
    {
        bool control = false;
        System.Console.Write($"Enter the {text}:");
        getValue = System.Console.ReadLine()!;
        control = int.TryParse(getValue, out value);
        if (control == true)
        {
            if (value != 0)
            {
                correct = true;
            }
        }
    }
    return value;
}

string PrintArray(string[] printarray, int Length)
{
    string print = string.Empty;
    for (int i = 0; i < Length; i++)
    {
        print += $"{printarray[i]} ";
        print += System.Environment.NewLine;
    }
    return print;
}

void Main()
{
    string enter = "array size";
    int size = GetValueNullNatural(enter);
}