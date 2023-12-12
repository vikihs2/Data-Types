int num = int.Parse(Console.ReadLine());
int year = num * 100;
double days = year * 365.24;
double hours = days * 24;
double mins = hours * 60;
Console.WriteLine($"{num} centuries = {year} years = {days} days = {hours} hours = {mins} minutes");