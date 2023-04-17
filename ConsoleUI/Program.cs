int a;
a=Convert.ToInt32(Console.ReadLine());

string s = "";

while (a>=1)
{
    s+=a%2;
    a=a/2;
}

Console.WriteLine(s);