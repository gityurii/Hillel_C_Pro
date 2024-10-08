/* Запрограмуйте клас Money (об'єкт класу оперує однією валютою) для роботи з грошима.
 * У класі мають бути передбачені: поле для зберігання цілої частини грошей (долари, євро, гривні тощо)
 * і поле для зберігання копійок (центи, євроценти, копійки тощо)
 * Реалізувати методи виведення суми на екран, задання значень частин
 * (цілої частини грошей та копійок).
 * На базі класу Money створити клас Product для роботи з продуктом або товаром.
 * Реалізувати метод, який дозволяє зменшити ціну на задане число.
 * Для кожного з класів реалізувати необхідні методи і поля.
 * Додати iнкапсуляцiю до полiв та методiв якщо треба.
*/

namespace C_Pro_Practice.HW2;

public class Money
{
    public string CurrencyName { get; set; }
    public string FractionName { get; set; }
    public int Integer { get; set; }
    public int Fractional { get; set; }

    
    public Money(string name, string fractionName, int integer, int fractional)
    {
        CurrencyName = name;
        FractionName = fractionName;
        Integer = integer;
        Fractional = fractional;
    }

    public override string ToString()
    {
        return $"{Integer} {CurrencyName}s and {Fractional} {FractionName}s";
    }

    public void ConsolePrintAmount()
    {
        Console.WriteLine($"{Integer} {CurrencyName}s and {Fractional} {FractionName}s");
    }

    public void SetNewBalance(int integer, int fractional)
    {
        Integer = integer;
        Fractional = fractional;
    }

    public void DecreaseBalance(Money value)
    {
        Integer -= value.Integer;
        if (Fractional < value.Fractional)
        {
            Integer -= 1;
            Fractional += 100 - value.Fractional;
        }
        else
        {
            Fractional -= value.Fractional;
        }
    }
}