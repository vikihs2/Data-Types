static int SumOfDigits(int number)
{
    int sum = 0;
  while (number > 0)
{
  sum += number % 10;
        //number /= 10;
  }
return sum;
}
static bool IsSpecial(int number)
{
  int sum = SumOfDigits(number);
return sum == 5 || sum == 7 || sum == 11;
}
static void Main()
{
  int n = int.Parse(Console.ReadLine());
 for (int i = 1; i <= n; i++)
 {
   Console.WriteLine($"{i} -> {IsSpecial(i)}");
}
}