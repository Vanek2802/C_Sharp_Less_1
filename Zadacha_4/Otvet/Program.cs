// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

Console.WriteLine ( " Enter First namber: - ");
int FirstNamber = Convert.ToInt32 ( Console.ReadLine () );

Console.WriteLine ( " Enter Second namber: - ");
int SecondNamber = Convert.ToInt32 ( Console.ReadLine () );

Console.WriteLine ( " Enter Third namber: - ");
int ThirdNamber = Convert.ToInt32 ( Console.ReadLine () );

if ( FirstNamber > SecondNamber )
{
    if ( FirstNamber > ThirdNamber )
    {
        Console.WriteLine (" Max namber: " + FirstNamber);
    }
    else 
    {
        Console.WriteLine (" Max namber: " + ThirdNamber);
    }
}

else if ( SecondNamber > ThirdNamber )
{
         Console.WriteLine (" Max namber: " + SecondNamber);
}
else 
{
    Console.WriteLine (" Max namber: " + ThirdNamber);
}