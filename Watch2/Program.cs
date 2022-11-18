string stringNumbers = "23, 5, -7, -856, 28";
int[] array = ParseStringToArray(stringNumbers, ',');

for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

int[] ParseStringToArray(string input, char separator)
{
    int numbresCount = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if(input[i] == separator)
            numbresCount++;
    }

    int[] numbers = new int[numbresCount];
    int numberIndex = 0;
    string subString = "";
    for (int i = 0; i < input.Length; i++)
    {
        if(input[i] != separator)
        {
            subString += input[i];
        }
        else
        {
            numbers[numberIndex++] = Convert.ToInt32(subString);
            subString = "";
        }
    }
    numbers[numberIndex] = Convert.ToInt32(subString);

    return numbers;
}