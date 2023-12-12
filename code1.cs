int n = int.Parse(Console.ReadLine());//kolko chisla da ima
double sum = 0;//sum
for (int i = 0; i < n; i++)//kazva kolko chisla
{
    double number = double.Parse(Console.ReadLine());//chislata vuvedeni po opredelenata brojka
    sum += number;//dobavq chislata kum sumata
}
Console.WriteLine(sum);//printva