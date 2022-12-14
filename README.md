<h2 align="center"> Итоговая контрольная работа </h2>

**Задача:**

1. Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 

2. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

3. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

<h2 align="center">Описание решения:</h2>

1. Для начала необходимо создать *строковый массив*, в который мы будем записывать данные, вводимые пользователем. Ввод данных пользователем заканчивается, как только он нажимает Enter:

```c#
Console.WriteLine("Введите элементы массива через пробел или запятую: ");
string x = Console.ReadLine();
string[] result = x.Split(';',' ',',','.').ToArray();
```

2. Далее мы создаем *второй массив(длиной такой же как и первый)*, для того чтобы записать туда только те элементы, которые состоят из трех символов.

3. Теперь можно создать метод, с помощью которого мы и будем определять, считывать и записывать во второй массив элементы, состоящие из трех символов. Делать мы это будем с помощью **цикла for** (который будет пробегаться по всему массиву) и **условия if** (которое и будет искать такие элементы):

```c#
void GetThreeSymbolsElemnets(string[] array1,string[] array2)
{
    for(int i = 0 ; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3) array2[i] = array1[i];
    }
}
```

4. После того как мы нашли элементы, состоящие из трех символов, и записали их во второй массив, необходимо этот массив распечатать, чтобы пользователь увидел те самые искомые элементы. Для этого мы также сделаем отдельный метод **PrintArray**:

```c#
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" '{array[i]}' ");
    }
    Console.WriteLine();
}
```

5. Ну и в конце осталось лишь использовать описанные выше методы для решения задачи и вывести на экран элементы, с тремя символами:
```c#
GetThreeSymbolsElemnets(result,result2);
Console.WriteLine("Элементы, состоящие из трех символов: ");
PrintArray(result2);
```
