// Code.

int length = Input("Введите размер массива: ");
string[] arrayOfLines = new string[length];

arrayOfLines = FillingArray(arrayOfLines);

ConclusionArray(arrayOfLines);
int sizeLimit = 3;
string[] arrayResult = SearchDesiredLines(arrayOfLines, sizeLimit);

ConclusionArray(arrayResult);

// Methods of finalTaskProgram.
int Input(string invite)
{
    Console.Write(invite);
    return int.Parse(Console.ReadLine());
}
string[] FillingArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} строку в массив: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
string[] SearchDesiredLines(string[] arrayLines, int limit)
{
    int sizeCounter = 0;
    
    for (int i = 0; i < arrayLines.Length; i++)
    {
        if (arrayLines[i].Length <= limit)
        {
            sizeCounter++;
        }
    }
    string[] arrayWithResult = new string[sizeCounter];
    int count = 0;
    if (sizeCounter != 0)
    {
        for (int i = 0; i < arrayLines.Length; i++)
        {

            if (arrayLines[i].Length <= limit)
            {
                arrayWithResult[count] = arrayLines[i];
                count++;
            }
        }
        return arrayWithResult;
    }
    else
    {
        string[] arrayEmptyLine = { String.Empty };
        return arrayEmptyLine;
    }
}

void ConclusionArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1)
        {
            Console.Write($"[{array[i]}], ");
        }
        else
        {
            Console.WriteLine($"[{array[i]}].");
        }
    }
}