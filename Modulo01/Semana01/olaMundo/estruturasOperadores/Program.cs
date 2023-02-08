

int[] primeNumber = new int[10];
int count;

for (count = 0; count < 10; count++)
{
    primeNumber[count] = int.Parse(Console.ReadLine());
}
for (count = 0; count < 10; count++)
{
    if (!(primeNumber[count] % 2 == 0) && !(primeNumber[count] / 3) && !(primeNumber[count] / 7))
    {
        Console.WriteLine(primeNumber[count] + " is a prime number!");
    }
}

/*
for (int i=0, j=1;i<5;i++,j--)
{
    Console.WriteLine(i);
    Console.WriteLine(j);
}
*/






