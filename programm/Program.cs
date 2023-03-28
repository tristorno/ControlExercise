string[] arrayLong = new string[5];
for (int i=0; i<arrayLong.Length; i++)
{
    arrayLong[i]=Income($"Input the {i+1} array element: ");
}
Outcome("The input array: ", arrayLong);
Outcome("The final array: ", IfElementShort(arrayLong));
 
///Ввод
string Income (string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine()??"0";
}
 
///Определение элементов длинной менее 4 симоволов и заполнение массива
string[] IfElementShort (string[] arrayLong)
{
    int j = 0;
    string[] arrayShort = new string [arrayLong.Length];
    for (int i=0; i<arrayLong.Length; i++)
    {
        if (arrayLong[i].Length < 4) //4 - Условие задачи
        {
            arrayShort[j] = arrayLong[i];
            j++;
        }
    }
    Array.Resize(ref arrayShort, j);
    return arrayShort;
}


///Печать массива
void Outcome (string msg, string[] arr)
{  
    Console.WriteLine(msg);
    for (int i=0; i<arr.Length; i++)
    {
        Console.Write($"|{arr[i]}|");
    }
    Console.WriteLine("\n");
}
