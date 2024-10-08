using C_Pro_Practice.HW1;

int firstNumber;
int secondNumber;

Console.Write("Enter the first number: ");
var validFirstNumber = int.TryParse(Console.ReadLine(), out firstNumber);

if (validFirstNumber)
{
    Console.Write("Enter the second number: ");
    var validSecondNumber = int.TryParse(Console.ReadLine(), out secondNumber);
    
    if (validSecondNumber && secondNumber != 0)
    {
        int addResult = Calculator.Add(firstNumber, secondNumber);
        int subtractResult = Calculator.Subtract(firstNumber, secondNumber);
        int multResult = Calculator.Multiply(firstNumber, secondNumber);
        int divResult = Calculator.Devide(firstNumber, secondNumber);

        Console.WriteLine();
        Console.WriteLine($"The sum of {firstNumber} and {secondNumber} = {addResult}");
        Console.WriteLine($"The diff of {firstNumber} and {secondNumber} = {subtractResult}");
        Console.WriteLine($"The multiplication of {firstNumber} and {secondNumber} = {multResult}");
        Console.WriteLine($"The division of {firstNumber} and {secondNumber} = {divResult}");
    }
    else
    {
        Console.WriteLine("Not a valid integer is entered");
    }
}
else Console.WriteLine("Not a valid integer is entered");