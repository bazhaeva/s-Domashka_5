int length = GetUserNumber("Введите число: ", "Ошибка ввода!");
double[] userArray = GetArrayRandom(length);
double result = Difference(userArray);
Console.Write($"{String.Join(" ", userArray)} -> Max-min = {result}");


//=========================================Методы===========================================

//-----------------Получение величины массива от пользователя
int GetUserNumber(string messageToUser, string errorMessage)
{
    while (true)
    {
        Console.Write(messageToUser);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}



//-----------------Заполнение массива генератором случайных чисел
double[] GetArrayRandom(int inputLenght)
{
    double[] randomArray = new double[inputLenght];
    for (int i = 0; i < inputLenght; i++)
    {
        randomArray[i] = new Random().Next(-100, 100);  // от -100 до 100, чтобы не выдавал километровые числа
    }
    return randomArray;
}


//-----------------Нахождение разницу между максимальным и минимальным элементами массива
double Difference(double[] array)
{
    int maxPosition = 0;
    int minPosition = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > array[maxPosition])
            maxPosition = i;
        if (array[i] < array[minPosition])
            minPosition = i;
    }
    return array[maxPosition] - array[minPosition];
}