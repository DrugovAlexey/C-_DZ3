// Это очень корявое решение
Console.WriteLine(" Введите пятизначное число");
string a = Console.ReadLine();
int a1 = Convert.ToInt32(a);
int b1 = a1 / 10000;
int c1 = a1 % 10;
int b2 = a1 / 1000 % 10;
int c2 = a1 / 10 % 10;

if (b1 == c1 && b2 == c2)
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine("Это не палиндром");
}

