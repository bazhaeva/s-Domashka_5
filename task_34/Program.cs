int length  = GetUserNumber("Введите число: ", "Ошибка ввода!");
//int[] userArray = GetArray(length);                                      ***для заполнения массива с клавиатуры
int[] userArray = GetArrayRandom(length);
int countEvenEls = CountEven(userArray);

Console.Write($"{String.Join(" ", userArray)} -> {countEvenEls} четных в массиве");



//=========================================Методы===========================================

//-----------------Подсчет четных элементов массива
int CountEven(int[] array)
{
    int countEvenEls =0;
    foreach(int el in array)
        {
            if(el%2==0) countEvenEls+=1;
        }
    return countEvenEls;

}


//-----------------Заполнение массива генератором случайных чисел
int[] GetArrayRandom(int inputLenght)
{
    int[] randomArray = new int[inputLenght];
    for(int i=0; i<inputLenght; i++)
    {
        randomArray[i] = new Random().Next(100, 1000);
    }
    return randomArray;
}


//-----------------Заполнение массива вручную
int[] GetArray(int inputLenght)
{
    int[] userArray = new int[inputLenght];
    for(int i=0; i<inputLenght; i++)
    {
        userArray[i] = GetElArray($"Введите элемент массива {i}: ", "Ошибка ввода. Введите трехзначное число");
    }
    return userArray;
}



//-----------------Получение величины массива от пользователя
int GetUserNumber(string messageToUser, string errorMessage)
{
        while(true)
        {
            Console.Write(messageToUser);
            if(int.TryParse(Console.ReadLine(), out int userNumber))
                return userNumber;
            Console.WriteLine(errorMessage);
        }
}

//-----------------Получение элементов массива от пользователя
int GetElArray(string messageToUser, string errorMessage)
{
        while(true)
        {
            Console.Write(messageToUser);
            if(int.TryParse(Console.ReadLine(), out int elArray) && elArray>99 && elArray<1000)
                return elArray;
            Console.WriteLine(errorMessage);
        }
}
