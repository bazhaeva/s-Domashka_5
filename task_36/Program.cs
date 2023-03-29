int length = GetUserNumber("Введите число: ", "Ошибка ввода!");
int[] userArray = GetArrayRandom(length);
int countNoEvenPos = CountNoEvenPos(userArray);

Console.Write($"{String.Join(" ", userArray)} -> {countNoEvenPos}");



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
int[] GetArrayRandom(int inputLenght)
{
    int[] randomArray = new int[inputLenght];
    for (int i = 0; i < inputLenght; i++)
    {
        randomArray[i] = new Random().Next(-100, 100);  // от -100 до 100, чтобы не выдавал километровые числа
    }
    return randomArray;
}

//-----------------Получение суммы элементов, стоящих на нечетных позициях
int CountNoEvenPos(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}