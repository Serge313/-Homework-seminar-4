int size = GetNumber("Enter your number ");
int[] array = new int [size];
FillArray(array);


void FillArray(int[] array1) 
{
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(1, 101);
        Console.Write(array1[i] + " ");
    }
}



int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}