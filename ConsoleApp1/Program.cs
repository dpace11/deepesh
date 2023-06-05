DayOne dayOne = new();

dayOne.Sum(10, 15);
Console.WriteLine();

dayOne.ConvertToMin(30); 
Console.WriteLine();

dayOne.NextNumber(5);
Console.WriteLine();

dayOne.PowerCircuitCalcu(15, 40);
Console.WriteLine();

Console.WriteLine("enter your age");
int x=int.Parse(Console.ReadLine());
dayOne.AgeToDays(x);


