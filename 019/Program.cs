Console.WriteLine("Введите пятизначное число для проверки на палиндром: ");
string checkedNumber = Console.ReadLine();

if(checkedNumber.Length == 5)
{
if(checkedNumber[0] == checkedNumber[4] && checkedNumber[1] == checkedNumber[3]) 
Console.WriteLine($"Число {checkedNumber} является палиндромом");
else Console.WriteLine($"Число {checkedNumber} не является палиндромом");
}
else Console.WriteLine($"Вы ввели неправильное число, перезапустите программу");

