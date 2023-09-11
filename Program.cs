int getTextArrayNewSize(string[] arr)
{
    int indexNew = 0;
    foreach (string s in arr)
    {
        if (s.Length <= 3)
        {
            indexNew += 1;
        }
    }
    return indexNew;
}

string[] CreateNewArray(int indexNew, string[] arr)
{
    Console.WriteLine($"Количество элементов в новом массиве: {indexNew}");
    string[] textArrayNew = new string[indexNew];
    indexNew = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            textArrayNew[indexNew] = arr[i];
            indexNew += 1;
        }
    }
    return textArrayNew;
}

void TestNewArray(string[] arr)
{
    Console.Write($"[{string.Join(", ", arr)}]");
    
    // foreach (string s in arr)
    // {
    //     Console.Write($"{s}  ");
    // }
}

string[] textArray = { "Hello", "2", "world", ":-)", "sdf" };
string[] textArrayNew = CreateNewArray(getTextArrayNewSize(textArray), textArray);
TestNewArray(textArray);
Console.Write("->");
TestNewArray(textArrayNew);