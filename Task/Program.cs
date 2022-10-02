Console.WriteLine("Введите элементы массива через пробел или запятую: ");
string x = Console.ReadLine();
string[] result = x.Split(';',' ',',','.').ToArray();
Console.ReadKey();
string[] result2 = new string[result.Length];
void GetThreeSymbolsElemnets(string[] array1,string[] array2)
{
    for(int i = 0 ; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3) array2[i] = array1[i];
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
GetThreeSymbolsElemnets(result,result2);
Console.WriteLine("Элементы, состоящие из трех символов: ");
PrintArray(result2);

