//Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write (" Enter namber: - ");
int namber = Convert.ToInt32 ( Console.ReadLine ());

int evenNamber = 2;

if ( namber > 1)
{
    while ( evenNamber <= namber)
    {
        Console.Write ( evenNamber + " ");
        evenNamber = evenNamber +2;
    }
}