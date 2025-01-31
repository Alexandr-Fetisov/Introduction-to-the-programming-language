﻿// Мы попробовали в примере Example011_ArrayLibrary написать свои первые методы: метод заполнения массива и метод его
// печати на экран. Теперь попробуем адаптировать решение предыдущей задачи, в которой
// находили нужные элементы и позицию нужного элемента в массиве.
// Для этого потребуется описать метод, отличный от void. Он будет возвращать позицию, то есть index.
// Назовём этот метод IndexOf, а в качестве аргумента будет приходить массив collection и какой-то элемент find.
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length) //Теперь в цикле while пропишем пока index < length будем чего-то делать
    {
        collection[index] = new Random().Next(1, 10);// После этого обратимся к аргументу collection на позицию index
                                                     // и положим туда новое случайное число — целое число из диапазона 1–10.

        //в качестве чего-то это будет как минимум index + 1 и пишим компактно вместо index = index + 1; пишем index ++
        index++;
    }
}
// Теперь сделаем метод void, который будет печатать массив. Аналогичным образом в качестве
// аргумента здесь будет приходить массив. Обратите внимание, что здесь мы специально не
// даём одинаковые имена, чтобы привыкнуть называть разные аргументы различными
// именами. То есть в первом случае будет collection, а во втором, например, col:
void PrintArray(int[] col)
{
    int count = col.Length; // Количество элементов обозначим таким образом
    int position = 0; // Далее обозначим текущую позицию не через именование перемен index, а через position
    while (position < count) // скажем пока position < count
    {
        Console.WriteLine(col[position]); //мы будем выводить на экран через Console.WriteLine значение текущего элемента (col[position])
        position++; // Далее запишем position++ то есть увеличиваем значение текущей позиции
    }
}

int IndexOf(int[] collection, int find) // Назовём этот метод IndexOf, а в качестве аргумента будет приходить
{                                         //массив collection и какой-то элемент find.{
    int count = collection.Length; // Далее определяем количество элементов через count — collection.Length.
    int index = 0;                //  Нам потребуются индексы, чтобы щёлкать массив, пусть это будет переменная index.
    int position = -1; // Чтобы куда-то сохранить позицию, определим новую переменную position. И пусть по умолчанию это будет 0.
                      // Это не совсем общее решение, но пока подойдёт.
                      //  Но есть проблема: если поискать элемент, которого точно не существует, например, элемент 444,
                      // и запустить этот код, выйдет позиция 0
                      // Если мы ищем какой-то элемент, то либо он будет равен 0, либо больше 0. Но если не встречается ни одного
                      // элемента, то договоримся, что по умолчанию станет возвращаться значение -1. Это
                      // искусственный приём. То есть, если элемента нет, значит, выйдет -1. Таким образом, если
                      // запустить наш код, обнаружится значение позиции, равное -1. Это значит, что такой элемент не найден.

    while (index < count) // Затем возьмём цикл while, который будет проверять index < count.
    {
        if (collection[index] == find) // если collection[index] совпал с find, потребуется куда-то сохранить позицию (см.стр.39)
        {
            position = index; // В position положим значение нашего индекса
            break; //чтобы получать 1 вхождение (если к примеру у нас сгенерироавлось несколько одинаковых чисел)
        }
        index++; //Ведём в фигурные скобки index ++
    }
    return position; // После того как этот цикл отработает, ожидаем return position, нашу позицию элемента.
}

int[] array = new int[10];

// Теперь разберёмся, для чего используется ключевое слово void. Дело в том, что в контексте
// языка С# есть методы, которые могут возвращать или не возвращать какие-то значения. Если
// метод ничего не возвращает, он называется void-методом. Обратите внимание, что в этом
// случае в коде оператор return, отвечающий за поиск максимума из 3, не используется.

// Протестируем наш метод. Для начала напишем FillArray и в качестве аргумента передадим
// наименование нашего массива. Затем вызовем следующий метод PrintArray, который будет
// распечатывать наш массив. Запускаем и видим, что нет Run. Обычно код запускается со
// второго раза, но иногда бывают исключения, и он срабатывает с первого.

FillArray(array);
PrintArray(array);
Console.WriteLine(); // Теперь протестируем. Введём Console.WriteLine

int pos = IndexOf(array, 444); //  Определим переменную pos и положим в неё результат работы метода IndexOf.
                             // В качестве аргумента будет передаваться наш массив. Например, будем искать число 4.
Console.WriteLine(pos);
