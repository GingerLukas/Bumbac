// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//1 to 100
for (int i = 1; i <= 100; i++)
{
    bool three = i % 3 == 0;
    bool five = i % 5 == 0;
    //check for 3
    if (three)
    {
        Console.Write("bum");
    }
    //check for 5
    if (five)
    {
        Console.Write("bác");
    }
    //number if neither 3 or 5
    if(!five && !three)
    {
        Console.Write(i);
    }

    //end line
    Console.WriteLine();
}