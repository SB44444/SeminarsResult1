/* Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
 Пример работы программы: Исходный массив [2, hello, sun, 33, world] возвращаемый массив [2, sun, 33]
*/
void OutputedArray(string[] array)  // Метод выводящийновый массив из строк, длинной три и менее символа
{       
    Console.WriteLine("Your New Array:");
    for(int i = 0; i < array.Length; i++)
        if( array[i].Length <= 3)
           Console.Write(array[i] + "  ");
}
string [] InputedArray(int size)   // Метод заполнения исходного массива любым количеством элементов 
{
   string[] array = new string [size];      
   for(int i = 0; i < size; i++)
        array[i] = Convert.ToString(Console.ReadLine() + String.Empty);  //  Метод String.Empty добавлен для исключения NULL
return array;      
}
void ShowArray(string[] array)   // Метод вывода массива
{       
    Console.WriteLine("Your Array:");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");  
}
Console.WriteLine("Input size of your array");
int sizeA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input elements of your array");
string[] myInputedArray = InputedArray(sizeA);
ShowArray(myInputedArray);
Console.WriteLine();  
OutputedArray(myInputedArray);