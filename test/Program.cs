string[] array = new string [] { "Russia", "Denmark", "Kazan", "22","Ola" };

void PrintArray (string[] arr)
{

    for (int  i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void Diffarray (string[] arr)
{
       for (int  i = 0; i < arr.Length; i++)
    {
        string element = arr [i];
        if (element.Length <= 3)
        {
            arr[i] =element ;
        }
         else
         arr[i] =  string.Empty;

    }
}

PrintArray(array);

Diffarray (array);

Console.Write("элементы массива равные или меньше 3 знаков -> ");

PrintArray(array);
