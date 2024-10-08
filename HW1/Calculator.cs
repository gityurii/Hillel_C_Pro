/* Створити клас калькулятор.
 * Реалізувати основні методи: додавання, віднімання, множення, розподіл, тощо.
 * Використовувати Git.
 * Надіслати посилання на public гітхаб репозиторій із домашнім завданням.
 */

namespace C_Pro_Practice.HW1;

public static class Calculator
{
    static int firstNumber;
    static int secondNumber;
    
    public static int Add(int x, int y) => x + y;
    public static int Subtract(int x, int y) => x - y;
    public static int Multiply(int x, int y) => x * y;
    public static int Devide(int x, int y) => x / y;
}