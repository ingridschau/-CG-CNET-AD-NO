

//Using escape characters
string str = "You can find your \"hosts\" file in the following directory\r\n\r\nC:\\Windows\\System32\\drivers\\etc";
Console.WriteLine(str);


//Using verbatim strings
string str2 = @"You can find your ""hosts"" file in the following directory

C:\Windows\System32\drivers\etc";

Console.WriteLine(str2);