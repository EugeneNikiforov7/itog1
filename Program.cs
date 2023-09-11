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



string[] textArray = {"Hello", "2", "world", ":-)", "sdf"};
