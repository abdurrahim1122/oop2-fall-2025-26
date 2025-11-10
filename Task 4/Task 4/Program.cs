int a, b, temp;
Console.Write("Enter first number: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
b = Convert.ToInt32(Console.ReadLine());
temp = a;
a = b;
b = temp;

Console.WriteLine("\nAfter swapping:");
Console.WriteLine("a = " +a);
Console.WriteLine("b =" +b);