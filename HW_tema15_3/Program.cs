int[] array = new int[10]; //инициализация массива

for(int i=0; i<array.Length; i++) //заполнение массива с клавиатуры
{
    Console.WriteLine("Введите элемент массива: ");

    array[i] = int.Parse(Console.ReadLine()); //вводим элементы
}

for(int i=0; i < array.Length; i++) //вывод элементов массива
{
    Console.Write(array[i]+" ");
}
Console.WriteLine(); //разделение

Console.Write("Введите число, которое хотите найти: ");
int number=int.Parse(Console.ReadLine()); //переменная для ввода числа, которое будем искать в массиве

Array.Sort(array); //сортировка массива через link

for (int i=0; i < array.Length; i++)
{
    Console.Write(array[i]+" "); //вывод отсортированного массива
}
//                        определяем индекс элемента в массиве
Console.WriteLine("Позиция: "+Array.IndexOf(array, number));