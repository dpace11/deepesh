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

Console.WriteLine();
dayOne.triArea(3.0F, 5.6F);

Console.WriteLine();
dayOne.Rem(5, 7);

Console.WriteLine();
dayOne.IsEqualZero(6);

Console.WriteLine();
dayOne.LessThanHundred(45, 67);

Console.WriteLine() ;
dayOne.IsEqual(5, 5);

Console.WriteLine();
Console.WriteLine(dayOne.GiveMeSomething("is better than nothing"));

Console.WriteLine();
dayOne.Reverse(true);

Console.WriteLine();
Console.WriteLine($"there are {dayOne.howManyseconds(2)} in 2 hours");