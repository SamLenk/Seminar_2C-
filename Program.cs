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