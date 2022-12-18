                        // محمود ابراهيم محمد النجار
Console.Write("Enter The First Number: ");           
double Start_Number =Convert.ToDouble(Console.ReadLine());
Console.Write("Enter The Second Number: ");
double End_Number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("----------------------------");
Console.WriteLine("The Perfect Numbers Between {0} and {1}", Start_Number, End_Number);
Console.WriteLine("----------------------------");

double sum, m;

for(; Start_Number < End_Number; Start_Number++)
{
    sum = 0;
    for ( m = 1; m < Start_Number; m++)
    {
        if (Start_Number % m == 0)
        { 
        sum += m;
        }
    }

    if (sum == Start_Number)
    {
    Console.WriteLine(sum);
    }
}
