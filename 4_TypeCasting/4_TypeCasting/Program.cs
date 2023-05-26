double a = 3.34;
int b  = Convert.ToInt32(a);
int c = 123;
double d = Convert.ToDouble(c)+0.1;
int e = 321;
String f = Convert.ToString(e);
String g = "$";
Char h = Convert.ToChar(g);
String i = "true";
Boolean j = Convert.ToBoolean(i);

Console.WriteLine(b);
Console.WriteLine(a.GetType()); //Type
Console.WriteLine(b.GetType()); //Type
Console.WriteLine(d);
Console.WriteLine(c);
Console.WriteLine(c.GetType()); //Type
Console.WriteLine(d.GetType()); //type
Console.WriteLine(e);
Console.WriteLine(e.GetType());
Console.WriteLine(f);
Console.WriteLine(f.GetType());
Convert.ToString(h);
Console.WriteLine(h.GetType());
Console.WriteLine(i);
Console.WriteLine(i.GetType());
Convert.ToString(j);
Console.WriteLine(j.GetType());