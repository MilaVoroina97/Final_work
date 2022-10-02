Console.WriteLine("Введите элементы массива через пробел или запятую: ");
string x = Console.ReadLine();
string[] result = x.Split(';',' ',',','.').ToArray();
string[] result2 = new string[result.Length];