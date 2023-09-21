string str = "Hello";
char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);
string newMsg = new string(charMessage);
Console.WriteLine(newMsg);