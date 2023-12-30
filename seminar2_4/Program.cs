int n = 568;
if (n<10)
{
    Console.WriteLine(n);
}
else
{
    while (n>0)
    {
        int exit = n%10;
        n = n/10;
        if (n>0)
        {
            Console.Write(exit + ",");
        }
        else
        {
            Console.Write(exit);
        }
    }
}