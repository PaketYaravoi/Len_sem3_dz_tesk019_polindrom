 
 

  // аргумент в скобках - эт о размер массива, а "new" выдялить память под массив.

// 1) ввести число
// 2) проверка на 5значность и int 
// 3) проверка на полиндром

/*
1) 



*/

string number = Console.ReadLine();  // 1) создали переменную для дальнейшей работы
bool IsCorectNumber = IsFifeNumber(number); // 2) проверка на то что в нашей строке , действительно цыфры, а не другие символы, и за одно то что их дей-льно 5(тут функция вызывается) дословно "если, пятизначное что то - число" 
if(IsCorectNumber) 
{
    int [] array =  FillArray(number); // дальше нам нужно работать с массивами, создаем его из функции которая принимает аргумент строку number
    bool isPolindrom = CheckPolindrom(array);
    if(isPolindrom)
    {
        Console.WriteLine("Число -  полиндром");
    
    }
    else 
    {
        Console.WriteLine("не полиндпром=!!!");
    }
}  
else
{
    Console.WriteLine("+_");
}


bool CheckPolindrom(int[] array)
{
    // Проверить на полиндром
    for(int i  = 0; i < (array.Length - 1)/2; i++)
    {
        int lastIndex = array.Length - i -1;
        if(array [i] != (array[lastIndex])) // не изменяем массив (убираем кра йнее правое ) а сравниваем 1 с последним и ....
            return false;
    }
    return true;
}

int[] FillArray(string number)
{
    int[] array = new int[5];
    for(int i  = 0; i < number.Length; i++)
    {
        //array[i] = number[i]
        array[i] = (int)Char.GetNumericValue(number[i]); // строка конвертирует элемент строки которыый является char символов в тип int GetNumericValue - функция библиотеки которая конвертирует тип данный char(элемент строки) в элемент int 
    }
    return array;
}
//int intVal = (int)Char.GetNumericValue(ch);

// 2) проверка на то что в нашей строке , действительно цыфры, а не другие символы, и за одно то что их дей-льно 5
bool IsFifeNumber(string number)
{
    if(number.Length  != 5)
    {
        Console.WriteLine("Колличество символов не равно 5");
        return false;
    }
    if(!int.TryParse(number, out var q)) // отвечает за то , чтобы не было ошибок при вводе символов не являющиеся числами, более того Parse сам по себе не тащит, только TryParse
    {
        Console.WriteLine("не число !");
        return false;
    }
    return true;
}




