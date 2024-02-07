//Напишите программу, которая принимает на вход трехзначное число
// и удаляет вторую цифру этого числа.
// Примеры 
// а = 256 => 26
// a = 891 => 81

// int number = 453;
// int firstDigit = number / 100; // 453 / 100 = 4
// int thirdDigit = number % 10; // 453 / 10 = 3

// int result = firstDigit * 10 + thirdDigit; // 4*10 + 3 = 43
// Console.WriteLine($"В числе {number} => {result}");

// git add. (-a)
// git commit -m this can be replaced with git commit -am
 
// Напишите программу, которая принимает на вход трехзначное число 
// и возводит вторую цифру этого числа в степень, равную третьей цифре.
// Примеры 
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

// int number = 947;
// int secondDigit = number / 10 % 10; // 947 / 10 % 10 = 94 % 10 = 4
// int thirdDigit = number % 10; // 947 % 10 = 7
// int result = (int)Math.Pow(secondDigit, thirdDigit); // result is converted to (int) type
// Console.WriteLine($"{secondDigit} ^ {thirdDigit} = {result}"); // 4 ^ 7 = 16384

// Напишите программу, которая выводит третью с конца 
// цифру заданного числа или сообщает, что третьей цифры нет
// 456 => 4
// 7812 => 8
// 91 => no third number

int number = 925;
if (number >= 100) // number has three digits
{
int thirdDigitFromEnd = number / 100 % 10;
Console.WriteLine($"Третья цифра с конца: {thirdDigitFromEnd}");
}
else // there is no third digit
{
    Console.WriteLine("No third digit");
}