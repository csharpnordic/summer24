// See https://aka.ms/new-console-template for more information

Console.WriteLine("Привет, вселенная!");

int a = 10;
a = a + 1;
a += 1;
int b = a++;
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


