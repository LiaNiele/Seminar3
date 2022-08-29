// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

void Palindrome(){
    Console.WriteLine("Введите пятизначное число: ");               //Ввод данных
    int num = Convert.ToInt32(Console.ReadLine());
    if (num>9999 && num<100000){                                    //Границы пятизначных чисел
        int fir =num / 10000;                                       //отсекаем первую цифру
        int sec = num % 10000 / 1000;                               //отсекаем вторую цифру
        int fou = num % 100 / 10;                                   //находим третью цифру
        int fif = num % 10;                                         //получаем пятую

        if(fir == fif && sec == fou){                               //сравнение 1с5 и 2с3 цифр
            Console.WriteLine("Число является палиндромом");
        }
        else{
           Console.WriteLine("Число НЕ является палиндромом");      //вывод данных
        }
    }
    else{
        Console.WriteLine("Число не пятизначное");
    }
}

Palindrome();


// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// расстояние = корень квадратный ((х2-х1)^2+(y2-y1)^2+(z2-z1)^2)

void Average(){
    Console.WriteLine("Введите координату х первой точки ");    //ввод данных
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату y первой точки ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату z первой точки ");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату х второй точки ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату y второй точки ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату z второй точки ");
    int z2 = Convert.ToInt32(Console.ReadLine());

    int sqx = (x2 - x1) * (x2 - x1);                             //вычисляем квадраты разностей
    int sqy = (y2 - y1) * (y2 - y1);
    int sqz = (z2 - z1) * (z2 - z1);
    double result = Math.Sqrt(sqx + sqy + sqz);                  //вычисляем корень из суммы квадратов разностей
    Console.WriteLine("Расстояние между двумя точками: " + result);
}

Average();


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Kub(int n){
    int i = 1;
    while(i<=n){
        Console.Write(i*i*i + " ");             //вычисление и вывод кубов чисел от 1 до n
        i++;
    }
}

Console.WriteLine("Введите число: ");           //ввод данных
int num = Convert.ToInt32(Console.ReadLine());
if(num<=0) Console.Write("Некорректный ввод");  //проверка соответствия введенного числа условию задачи
else Kub(num);                                  //выполнение функции


// * Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве

void Average(){
    Console.WriteLine("Введите координату х первой точки ");    //ввод данных
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату y первой точки ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату х второй точки ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату y второй точки ");
    int y2 = Convert.ToInt32(Console.ReadLine());

    int sqx = (x2 - x1) * (x2 - x1);
    int sqy = (y2 - y1) * (y2 - y1);
    double result = Math.Sqrt(sqx + sqy);
    Console.WriteLine("Расстояние между двумя точками: " + result);
}

Average();