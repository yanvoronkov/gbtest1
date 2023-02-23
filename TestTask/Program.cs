// Задача: Написать программу, которая
// из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

//пользовательский ввод массива в строку через запятую

int InsertDigit(string text) //Метод пользовательского ввода числа
{
	int result; bool parse;
	Console.WriteLine(text);
	parse = Int32.TryParse(Console.ReadLine(), out result);
	if (!parse) result = InsertDigit(text);//Если пользователь ввел некорректное значение вызываем повтороно метод.
	return result;
}

string[] GetUserNumbers(string text) //Метод пользовательского ввода через запятую
{
	Console.WriteLine(text);
	string str = Console.ReadLine();
	string[] strArr = str.Split(',');
	string[] result = new string[strArr.Length];
	for (int i = 0; i < strArr.Length; i++)
	{
		result[i] = Convert.ToString(strArr[i]);
	}
	return result;
}

void PrintArray(string[] array)// Печать массива
{
	System.Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) System.Console.Write(array[i] + ",");
		else System.Console.Write(array[i]);
	}
	System.Console.WriteLine("]");
}


string[] FilterArray(string[] arr, int n)//создание нового массива из значений, длиной n и менее символов
{
	int amountOfItems = 0;
	int amountOfExceptions = 0;
	for (int i = 0; i < arr.Length; i++) //расчет количества значенией массива длиной n и менее символов
	{
		if (arr[i].Length <= n)
		{
			amountOfItems++;
		}
	}
	string[] newArray = new string[amountOfItems];

	for (int i = 0; i < arr.Length; i++) //заполнение нового массива длиной n и менее символов
	{
		if (arr[i].Length <= n)
		{
			newArray[i - amountOfExceptions] = arr[i];
		}
		else amountOfExceptions++;
	}
	return newArray;
}
int n = InsertDigit("Введите число - ограничение по длине строк: ");
string[] array = GetUserNumbers("Введите значения массива через запятую: ");
PrintArray(array);
string[] newArray = FilterArray(array, n);
PrintArray(newArray);