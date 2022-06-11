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

string PrintArrayIf(string[] printarray, int Length)
{
    int count = 2;
    string print = string.Empty;
    for (int i = 0; i < Length; i++)
    {
        if (printarray[i] != "0")
        {
            print += $"{printarray[i]} ";
        }
        if (i == count)
        {
            print += System.Environment.NewLine;
            count += 3;
        }
    }
    return print;
}

string[] FilterArray(string[] arrayIn, int Length)
{
    string[] arrayOut = new string[Length];
    return arrayOut;
}

void Main()
{
    string enter = "array size";
    int size = GetValueNullNatural(enter);

    string[] array = new string[size];

    System.Console.WriteLine(PrintArrayIf(FilterArray(array, size), size));
}