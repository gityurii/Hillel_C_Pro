/*
 * Створіть структуру «Десяткове число».
 * Визначте в ній необхідні поля і методи. Реалізуйте наступну функціональність:
 * ■ Перевести число у двійкову систему;
 * ■ Перевести число у вісімкову систему;
 * ■ Перевести число у шістнадцяткову систему.
 */

namespace C_Pro_Practice.HW2;

struct DecimalNumber
{
 public int Value { get; private set; }
 
 public DecimalNumber(int value)
 {
  Value = value;
 }
 
 public string ToBinary()
 {
  return Convert.ToString(Value, 2);
 }
 
 public string ToOctal()
 {
  return Convert.ToString(Value, 8);
 }
 
 public string ToHexadecimal()
 {
  return Convert.ToString(Value, 16).ToUpper();
 }
}