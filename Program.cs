

string PrintArray(string[] printarray)
{
    string print = string.Empty;
    for (int i = 0; i < printarray.Length; i++)
    {
        print += $"{printarray[i]} ";
        print += System.Environment.NewLine;
    }
    return print;
}

