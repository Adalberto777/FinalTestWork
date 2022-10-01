// программа, которая из существуещего массива строк формирует массив строк, длинна которых меньше или равна трем
string[] str = {"hello", "2", "world", ":-)", "1", "1325", "0", "hj"};

void PrintArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + "\t");
  }
  Console.WriteLine();
}

int CounterShortString(string[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {        
        if (array[i].Length < 4)
        {
            result++;
        }        
    }
    return result;
}

string[] GetShortArray(string[] array, int counter)
{
    string[] strResult = new string[counter];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            strResult[j] = array[i];
            j++;
        }
    }
    return strResult;
}

int count = CounterShortString(str);



PrintArray(str);
PrintArray(GetShortArray(str, count));
