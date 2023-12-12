int n = int.Parse(Console.ReadLine());

if (n < 3)
{
    return;
}

int count = 0;

for (char i = 'a'; i < 'a' + n; i++)
{
    for (char j = 'a'; j < 'a' + n; j++)
    {
        for (char k = 'a'; k < 'a' + n; k++)
        {
            Console.WriteLine("{0}{1}{2}", i, j, k);
            count++;
        }
    }
}