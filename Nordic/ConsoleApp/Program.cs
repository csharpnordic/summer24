using System.Text;

// See https://aka.ms/new-console-template for more information

Console.WriteLine("Привет, вселенная!");

int a = 10;
a = a + 1;
a += 1;

int b = ++a;
/*
a = a + 1;
int b = a;
*/

int c = ++a;
a++;
++a;

int d = int.MaxValue;
int e = unchecked(d + 1);

d = int.MinValue;
e = d - 1;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);

double d1 = 1, d2 = 1;
Console.WriteLine(d1);
d1 += 0.1;
d1 += 0.1;
d1 += 0.1;
d1 += 0.1;
d1 += 0.1;
d2 += 0.5;
Console.WriteLine(d1);
Console.WriteLine(d2);
Console.WriteLine(d1 == d2);

int A = 2;
int B = 0;
bool flag = (B != 0) && (A / B == 1);
Console.WriteLine(flag);

d1 = double.PositiveInfinity;
d2 = 1;
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine(d1);

Console.Write("Введите вещественное число > ");
string? s = Console.ReadLine();
// d1 = double.Parse(s);
d1 = Convert.ToDouble(s, System.Globalization.CultureInfo.InvariantCulture);
Console.WriteLine(d1.ToString(System.Globalization.CultureInfo.InvariantCulture));

int dx = (int)(d2 / 0);

Console.WriteLine((int)2.999999999);

int number = 55;
char ch = 'W';
s = "";
string s1 = s + number; // число преобразуется в строку
string s2 = s + ch;     // символ преобразуется в строку
string s3 = s + (number == 55 ? number : ch); // символ преобразуется в число, а только потом число преобразуется в строку

Console.WriteLine($"s1 = {s1}");
Console.WriteLine($"s2 = {s2}");
Console.WriteLine($"s3 = {s3}");

