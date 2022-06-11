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

void FillArray(string[] arrayEnter, int Length)
{
    for (int i = 0; i < Length; i++)
    {
        int arg = new Random().Next(1, 10000);
        arrayEnter[i] = System.Convert.ToString(arg);
    }
}

string[] FilterArray(string[] arrayIn, int Length)
{
    string[] arrayOut = new string[Length];
    for (int i = 0; i < Length; i++)
    {
        if (arrayIn[i].Length < 4)
        {
            arrayOut[i] = arrayIn[i];
        }
        else
        {
            arrayOut[i] = "*";
        }
    }
    return arrayOut;
}

string PrintArrayIf(string[] printarray, int Length)
{
    int count = 2;
    string print = string.Empty;
    for (int i = 0; i < Length; i++)
    {
        if (printarray[i] != "*")
        {
            print += $"{printarray[i]} ";
            if (i == count)
            {
                print += System.Environment.NewLine;
                count += 3;
            }
        }
    }
    return print;
}

string PrintArray(string[] printarray, int Length)
{
    int count = 3;
    string print = string.Empty;
    for (int i = 0; i < Length; i++)
    {
        print += $"{printarray[i]} ";
        if (i == count)
        {
            print += System.Environment.NewLine;
            count += 4;
        }
    }
    return print;
}

void Main()
{
    string enter = "array size";
    int size = GetValueNullNatural(enter);

    string[] array = new string[size];
    FillArray(array, size);

    if (size > 3)
    {
        array[0] = "who";
        array[3] = "what";
    }

    System.Console.WriteLine(PrintArray(array, size));
    System.Console.WriteLine(PrintArrayIf(FilterArray(array, size), size));
}

Main();