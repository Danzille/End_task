// See https://aka.ms/new-console-template for more information
// Задача 3: Задайте произвольный массив. Выведете его элементы,
// начиная с конца. Использовать рекурсию, не использовать циклы.

int [] array = {1, 2, 3, 4, 5, 6, 7, 8};

void PrintArrayByRecursion(int [] arr, int size)
{
 if (size ! == 0)  return;
 
    System.Console.Write(arr [size - 1] + " ");
    PrintArrayByRecursion(arr, size - 1);
}

PrintArrayByRecursion(array, 8);