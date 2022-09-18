﻿//Допустим, у нас есть массив array, в котором n элементов. Найдём элемент, совпадающий с
//некоторым значением find, который определяет пользователей.
//1. Сохраним его в переменную find. Затем установим счётчик в нулевую позицию.
//2. Если на текущей позиции элемент совпал с find, операцию можно завершить, потому что мы нашли позицию.
//3. Если элемент не совпал с find, увеличиваем значение счётчика index на 1 и переходим на предыдущий шаг.
//4. Сравниваем снова. И если элемент совпал с find, значит, алгоритм закончил работу.
//5. Если элемент совпал с find, снова увеличиваем индекс. Смотрим результат.
//6. В результате если элемент находится, операция завершается успешно. А если этого элемента так и нет, надо сообщить об этом

// Итак, реализуем теперь этот алгоритм кодом. 
// Сначала определим новый массив. Дадим int имя array. Далее определим какое-то количество чисел, например, 8. Технически их может
// быть сколько угодно, потому сейчас мы реализовываем задачу для любого количества элементов/
int[] array = {1,12,31,4,18,15,16,17,18};

// Далее по алгоритму требуется n элементов. Чтобы получить n, напишем:
int n = array.Length;

// Внутри массива есть информация о том, сколько элементов в нём содержится. В частности,
// array.Length возвращает длину или количество элементов массива. Определили.
// Далее надо, чтобы пользователь мог ввести число. Выберем число 4:
int find = 18;

// Теперь по нашему алгоритму требуется установить некоторый счётчик index, поэтому определим его так же.
// Индекс, равный 0. Помним, что элементы в нашем массиве начинаются с 0, то есть 1 стоит под нулевой позицией:
int index = 0;
// Далее нам потребуется цикл while, в котором будем проверять: если index < n. Отмечаем, что
// на каждом этапе надо увеличивать значение индекса, поэтому прописываем:
//while (index < n)
// {
// index = index + 1;
// }
// Программисты пишут это в более короткой форме:

//while (index < n)
//{
//if(array[index] == find) // Теперь выполняем второй пункт алгоритма. Если array[index] совпал с find, то алгоритм
// завершает свою работу. Можно при этом показать значение позиции.
//index + +;
//}

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index); // Обратите внимание, что понятие эквивалентно равенству левой части и правой. То есть
                                  // элемент, находящийся по нужному индексу, равен элементу find. Укажем index.
        break;                    // Если выполняется это условие, то просто добавляется break («прервать»)  
    }

    index++;
}
// Пока всё идёт хорошо. Сделаем запуск нашего проекта через dotnet run — получаем число 3.
// Теперь в качестве искомого возьмём число 18 и ожидаем увидеть последнюю позицию.
// Последняя позиция соответствует 7. Не забываем, что индексы начинаются с нуля.

// Посмотрим, что можно улучшить. Если у нас будет несколько одинаковых элементов, наш алгоритм покажет их все:
//int[] array = {1,12,31,4,18,15,16,17,18};
// Перезапустим систему и убедимся, что сначала появится позиция 4, а затем последняя.
// Разберёмся, как это исправить.
// Технически нам потребуется новый оператор. Посмотрим, как он выглядит.
// Если выполняется это условие, то просто добавляется break («прервать»):
// if(array[index] == find)
// {
// Console.WriteLine(index);
// break;
// }
// Перезапустим программу и убедимся, что будет найден первый элемент. Находим первый
// элемент и завершаем на этом свою работу. Мы выполнили условие пункта 2 нашего
// алгоритма. То есть, если array[index] совпал с find, значит, алгоритм завершил работу
// успешно, мы узнали индекс и решили задачу.
