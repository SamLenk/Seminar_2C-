// Задача 1

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


// Задача 2

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