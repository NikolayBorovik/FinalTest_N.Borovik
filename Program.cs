// 
Console.Clear();

string[] text = { "Whether", "the", "weather", "is", "fine", ",", "Whether the weather", "is", "not" };

string[] ToStringWithMax3Chars(string[] str)
{
    int count = 0;
    string[] temp = new string[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        char[] a = text[i].ToCharArray();
        if (a.Length <= 3)
        {
            temp[count] = text[i];
            count++;
        }
    }
}


