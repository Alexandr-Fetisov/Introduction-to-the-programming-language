﻿//=== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"  //если будет какая-то строка, то для этой строки есть некоторое количесво вспомогательного функционала,
//"qwerty" в частности если требуется обратиться к конкретному символу строки мы можем это делать начиная отсчитывать позицию символа с
// 0123
//для того, чтобы получить конкретный символ, мы можем указать идентификатор строки s и через [] обратится к конкретному символу
//s[3] = r

//Метод у нас будет принимать строку и те символы которые необходимо изменить по условию задачи, соответсвенно старый символ и
// на который нужно заменить
// возвращаться у нас будет строка, значит можно сделать вывод, что это учловно 4 Вид методов
string Replace(string text, char oldValue, char newValue) //даем название Replace, далее string text какой-то входной текст
//далее указываем конкретный символ char oldValue и символ на который будем менять char newValue
{
    string result = String.Empty; // Заводим новую строку result, чтобы не запутаться. Напоминаю, что инициализация пустой
                                  // строки выглядит как string result = String.Empty
    int length = text.Length; //чтобы получить длину строки. Сделать это можно при помощи обращения к соответствующему свойству,
                              //показывающему количество символов в строке. В этом случае textLength, на примере string s = “qwerty”, выдаст 6
    for (int i = 0; i < length; i++) //воспользовавшись циклом for, мы пройдём от нулевого символа до конца нашей строки.
    {
        if(text[i] ==oldValue) result = result + $"{newValue}";//Выполняем следующее действие, если текущий символ, для нас это текст i 
                                                      //совпал с символом, который мы хотим заменить, то в результат мы должны
                                                      //положить новое значение в виде строки newValue
        else result = result + $"{text[i]}"; //Если совпадений не обнаружено, то в result, нужно добавить текущий символ, который и был                                           
    }
    return result; //Чтобы ничего не забыть, мы можем сразу же вернуть этот результат                              
    
}
string newText = Replace(text, ' ', '|');//здесь мы указываем, что на что меняем. В нашем случае просили пробелы заменить 
                                           //на чёрточки, для этого я использую минус. Хотя, с другой стороны, чтобы было видно
                                           //это самоизменения,возьмём вертикальную строчку
Console.WriteLine(newText);
// по факту, нас просили заменить одни символы другими, но это нужно сделать
// для разных символов. Учитывая то, что мы написали в методе 1, в котором сказали есть старое
// значение, нужно будет заменить его на новое значение. В этом случае мы можем
// переиспользовать этот метод, просто указав в качестве аргументов те символы, которые
// нужно заменить на то, что нужно заменить. Так и сделаем
// В нашем случаем полученный текст, мы можем в дальнейшем начать обрабатывать здесь. Для
// красоты я буду разделять каждый вывод пустой строкой. Мы получаем newText и дальше
// требуется в качестве аргумента Replace передать наш старый текст, и опять получить новый,
// только теперь заменить маленькие буковки «к» большими. Показать результат. И так далее.
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С'); // в качестве тренировки, взять и проверить, как работает этот метод, 
                                      //если мы вместо маленьких «с» попробуем поставить большие «С»
Console.WriteLine(newText);
