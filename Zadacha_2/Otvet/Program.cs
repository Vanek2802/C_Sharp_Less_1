// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

int max = 0;
int min = 0;

Console.Write ("Enter First namber -");
int FirstNamber = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Enter Second namber -");
int SecondNamber = Convert.ToInt32 (Console.ReadLine());

if ( FirstNamber > SecondNamber )
{
    max = FirstNamber;
    min = SecondNamber;
}
else 
{
    max = SecondNamber;
    min = FirstNamber;
}
Console.WriteLine ( " max = " + max + " , " + " min = " + min );