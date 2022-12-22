// Задача 1 Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


System.Console.WriteLine("Введите переменную x: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите переменную y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x==0 || y==0)
{
  System.Console.WriteLine("X и Y не должны равнятся нулю");  
}
else if (x > 0 && y > 0)
{
   System.Console.WriteLine("Точка находится в первой четверти");   
}
else if (x < 0 && y > 0)
{
   System.Console.WriteLine("Точка находится в второй четверти");   
}
else if (x < 0 && y < 0)
{
   System.Console.WriteLine("Точка находится в третьей четверти");   
}
else if (x > 0 && y < 0)
{
   System.Console.WriteLine("Точка находится в четвертой четверти");   
}


// Задача 2 Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


System.Console.WriteLine("Введите номер четверти:");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    System.Console.WriteLine("x > 0 , y > 0");
}
else if (number == 2)
{
    System.Console.WriteLine("x < 0 ,y > 0");
}
else if (number == 3)
{
    System.Console.WriteLine("x < 0 , y < 0");
}
else if (number == 4)
{
    System.Console.WriteLine("x > 0 , y < 0");
}
else
{
    System.Console.WriteLine("Неверный номер четверти");
}

// Задача 3 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.


// ((x1 - x2)^2 + (y1 - y2)^2)^(1/2)

System.Console.WriteLine("Введите координату X точки A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y точки A: ");
int y1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату X точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2)),2); 
System.Console.WriteLine($"Расстояние между двумя точками: {result}");

// Задача 4 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
//от 1 до N.

System.Console.WriteLine("Введите число");
int x = int.Parse (Console.ReadLine()!);

 for ( int i = 1; i = x; i++)
 {
    
    Console.WriteLine (Math.Pow(i,2);
 }