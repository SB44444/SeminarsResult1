#   Итоговая проверочная работа.
Данный репозиторий содержит блок - схему и програмное решение на языке С#.

##   Задача:
*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

##  Решение:
* Объявлям массивы и входящие параметры.
* Пока значение индекса исходного массмва i, меньше длинны массива, проверяем условие: если длинна элемента массива меньше или равна трем, то присваиваем значение исходного массива соответствующему элементу выходного массива и увеличиваем значение индексов обоих массивов и возвращаемся в начало цикла для проверки условия. Если длинна больше, то увеличиваем значение индекса исходного массива и возвращаемся в начало цикла для проверки условия.  
* Когда зачение индекса исходного массива i, сравняется с количеством элементов массива - выход из цикла.
* Возвращаем сформированный новый массив.
