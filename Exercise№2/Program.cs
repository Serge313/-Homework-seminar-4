int number = GetNumber("Enter your number ");
string length = number.ToString();
int sum = 0;


for (int i = 0; i < length.Length; i++)
{
    int digit = number % 10;
    number = number / 10;
    sum = sum + digit;
}
Console.WriteLine(sum);


int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}