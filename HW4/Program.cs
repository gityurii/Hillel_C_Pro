using HW4;

public class Program
{
    public static void Main()
    {
        // Task 1
        Console.WriteLine("Task 1:");
        var john = new Worker (2000m, "Euro", "Developer");
        var jane = new Worker(2500m, "Euro", "Manager");
        
        Console.WriteLine($"{john.Position} with {john.Salary} {john.Currency} salary is created");
        Console.WriteLine($"{jane.Position} with {jane.Salary} {jane.Currency} salary is created");
        
        Console.WriteLine(john < jane ? "John has a lower salary." : "John does not have a lower salary.");
        
        var salaryRaise = 500;
        john += salaryRaise;

        Console.WriteLine($"New salary for {john.Position}: {john.Salary} {john.Currency}");
        Console.WriteLine(john == jane ? "Salaries are equal." : "Salaries are not equal.");
        
        // Task 2
        Console.WriteLine("Task 2:");
        var city1 = new City(500000);
        var city2 = new City(750000);

        Console.WriteLine(city1 < city2 ? "City1 has fewer residents." : "City1 does not have fewer residents.");

        city1 += 300000;

        Console.WriteLine($"City1 now has {city1.Residents} residents.");
        Console.WriteLine(city1.Equals(city2) ? "Cities have the same number of residents." : "Cities have different numbers of residents.");
        
        // Task 3
        Console.WriteLine("Task 3:");
        
        var card1 = new CreditCard(1000m, "USD");
        var card2 = new CreditCard(1500m, "USD");

        Console.WriteLine(card1 < card2 ? "Card1 has a lower balance." : "Card1 does not have a lower balance.");

        card1 += 700m;

        Console.WriteLine($"Card1 now has a balance of {card1.Balance} {card1.Currency}.");
        Console.WriteLine(card1 == card2 ? "Cards have the same balance." : "Cards have different balances.");

        // Task 4
        Console.WriteLine("Task 4:");
        
        var matrixA = new Matrix(2, 2);
        var matrixB = new Matrix(2, 2);

        matrixA.Data[0, 0] = 1;
        matrixA.Data[0, 1] = 2;
        matrixA.Data[1, 0] = 3;
        matrixA.Data[1, 1] = 4;

        matrixB.Data[0, 0] = 5;
        matrixB.Data[0, 1] = 6;
        matrixB.Data[1, 0] = 7;
        matrixB.Data[1, 1] = 8;

        var matrixC = matrixA + matrixB;
        var matrixD = matrixA - matrixB;

        Console.WriteLine("Matrix A:");
        PrintMatrix(matrixA);

        Console.WriteLine("Matrix B:");
        PrintMatrix(matrixB);

        Console.WriteLine("Matrix A + Matrix B:");
        PrintMatrix(matrixC);

        Console.WriteLine("Matrix A - Matrix B:");
        PrintMatrix(matrixD);

        var matrixE = matrixA * matrixB;
        Console.WriteLine("Matrix A * Matrix B:");
        PrintMatrix(matrixE);

        Console.WriteLine(matrixA == matrixB ? "Matrix A is equal to Matrix B." : "Matrix A is not equal to Matrix B.");
    }
    public static void PrintMatrix(Matrix matrix)
    {
        for (int i = 0; i < matrix.Rows; i++)
        {
            for (int j = 0; j < matrix.Columns; j++)
            {
                Console.Write(matrix.Data[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}