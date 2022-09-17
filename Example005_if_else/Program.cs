Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "alexandr") // в концe после закрывающей скобки ) нет точки с запятой; добавили ToLower() - позволяет все символы строки перевести в нижний регистр
{
    Console.WriteLine("Ура, это же Alexandr!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}

