

string str = @"1
2
""3""
4
5";

Console.WriteLine(str);


str = str.Replace("\r\n", "-");
Console.WriteLine(str);


