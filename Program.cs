#region T1
for (int i = 0; i <= 9; i++)
{
    Console.WriteLine(i);
}
#endregion
Console.WriteLine("\n_______________________\n");
#region T2
Console.Write("Enter number: ");
int s = 0, v = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nLogs: ");

for (int i = 0; i <= v; i++)
{
    s += i;
    Console.WriteLine(s);
}

Console.WriteLine("\nFinal results: " + s);
#endregion
Console.WriteLine("\n_______________________\n");
#region T3
Console.Write("Enter number of loops: ");
int v1 = Convert.ToInt32(Console.ReadLine());
//int u
 int s1 = 0;

Console.WriteLine("\nLogs: ");
for (int i = 1; i <= v1; i++)
{
    Console.Write("Enter number to be added to: ");
    //u = Convert.ToInt32(Console.ReadLine());
    //s1 += u;

    s1 += Convert.ToInt32(Console.ReadLine()); //Enhanced by Abdulaziz 
    Console.Write("... Result now: " + s1 + "\n");
}

Console.WriteLine("\nFinal result: " + s1);
#endregion
Console.WriteLine("\n_______________________\n");
#region T4
Console.Write("Enter a number bigger than 0: ");
float input = float.Parse(Console.ReadLine());
Console.Write("\n");
while (input < 0)
{
    Console.Write($"Invalid input '{input}'! ... Enter a valid input: ");
    input = float.Parse(Console.ReadLine());
}

Console.WriteLine("\nYou've entered a valid number: " + input);
#endregion
Console.WriteLine("\n_______________________\n");
#region T5

#endregion
Console.WriteLine("\n_______________________\n");
#region T6

#endregion
