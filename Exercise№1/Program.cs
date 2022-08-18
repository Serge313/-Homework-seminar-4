//Решение с помощью метода
double firstNumber = GetNumber("Enter your first number ");
double secondNumber = GetNumber("Enter your second number ");
double numberToPower = ToPower(firstNumber, secondNumber);
Console.WriteLine($"{firstNumber}, {secondNumber} -> {numberToPower}");


double ToPower(double a, double b)
{
    double c = Math.Pow(a, b);
    return c;
}


double GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}


//Решение с помощью цикла
int number1 = GetYourNumber("Enter number 1 ");
int number2 = GetYourNumber("Enter number 2 ");
int toPower = 1;


for (int i = 0; i < number2; i++)
{
    toPower = toPower * number1;
}
Console.WriteLine(toPower);


int GetYourNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}