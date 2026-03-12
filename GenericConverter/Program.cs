using System;

Console.WriteLine("=== 문자열 → 길이 변환 ===");
Converter<string, int> str_to_int = new Converter<string, int>(s => s.Length);
string[] arr1 = { "Hello", "World", "C#" };
Console.WriteLine($"{arr1[0]} -> {str_to_int.Convert(arr1[0])}");
var result1 = str_to_int.ConvertAll(arr1);
Console.Write("전체 변환: ");
foreach (int i in result1)
{
    Console.Write($"{i} ");
}
Console.WriteLine("\n");

Console.WriteLine("=== 정수 → 문자열 변환 ===");
Converter<int, string> int_to_string = new Converter<int, string>(i => (i.ToString() + "번"));
int[] arr2 = {1, 2, 3};
Console.WriteLine($"{arr2[0]} -> {int_to_string.Convert(arr2[0])}");
var result2 = int_to_string.ConvertAll(arr2);
Console.Write("전체 변환: ");
foreach (string s in result2)
{
    Console.Write($"{s} ");
}
Console.WriteLine("\n");

Console.WriteLine("=== 실수 → 정수 변환 ===");
Converter<double, int> double_to_int = new Converter<double, int>(d => (int)d);
double[] arr3 = { 3.7, 1.2, 9.9 };
Console.WriteLine($"{arr3[0]} -> {double_to_int.Convert(arr3[0])}");
var result3 = double_to_int.ConvertAll(arr3);
Console.Write("전체 변환: ");
foreach (int i in result3)
{
    Console.Write($"{i} ");
}
Console.WriteLine("\n");