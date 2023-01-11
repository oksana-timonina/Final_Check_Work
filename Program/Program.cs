/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.

ПРИМЕРЫ:
["Hello", "2", "world", ":-)"] → ["2", ":-)"]
["1234", "1567", "-2", "computer science"] → ["-2"]
["Russia", "Denmark", "Kazan"] → [] */


// ------- ОСНОВНАЯ ПРОГРАММА -------

// Задание первоначального массива

string[] arr1 = {"Hello", "2", "world", ":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"};

int max_elements_length = 3;

/*//ввод данных пользователем с клавиатуры
Console.Write ("Введите элементы массива (через пробел): ");
string [] arr1 = Console.ReadLine()!.Split(' ');

// string [] arr = Console.ReadLine()!.Split(','); ----- чтение данных, введенных через запятую

//вывод данных на консоль
Console.WriteLine ();
Console.WriteLine ($"Массив: [{String.Join (", ", arr)}]");
Console.WriteLine(($"Массив (new, string elements length <= 3): [{String.Join (", ", String_Elements_Length(arr1))}]")); */

// Вывод данных
Console.WriteLine ($"Исходные массивы.");
Console.WriteLine ($"Массив №1: [{String.Join (", ", arr1)}]");
Console.WriteLine ($"Массив №2: [{String.Join (", ", arr2)}]");
Console.WriteLine ($"Массив №3: [{String.Join (", ", arr3)}]");
Console.WriteLine ();
Console.WriteLine ($"Массивы из строк, длина которых меньше либо равна {max_elements_length} символам.");
Console.WriteLine(($"Массив №1 (new): [{String.Join (", ", String_Elements_Length(arr1))}]"));
Console.WriteLine(($"Массив №2 (new): [{String.Join (", ", String_Elements_Length(arr2))}]"));
Console.WriteLine(($"Массив №3 (new): [{String.Join (", ", String_Elements_Length(arr3))}]"));


// -------- метод подсчета кол-ва символов в массиве -------
string[] String_Elements_Length (string[] array)
{
    int length = array.Length;          
    string[] result = new string[length];
    int count = 0;
            
    for (int i = 0; i < length; i++)
    {
        if(array[i].Length <= max_elements_length)
        {
            result[count] = array[i];
            count++;
        }           
    }
    Array.Resize(ref result, count);
    return result;
}
