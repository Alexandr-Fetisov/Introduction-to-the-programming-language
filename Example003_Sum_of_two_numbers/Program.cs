//Добавили команду new Random().Next(min,max) для генерирования случайных чисел, в данном примере от 1 до 10
int numberA = new Random().Next(1, 10);
Console.WriteLine(numberA); //Добавили команду Console.WriteLine() для вывода сгенерированного числа в терминал
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);