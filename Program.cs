int current = 0;
int amount = 0;
while (amount <= 100)
{
    bool fizz = current % 3 == 0;
    bool buzz = current % 5 == 0;
    if (fizz && buzz)
    {
        Console.WriteLine(current);
        amount++;
    }
    current++;
}