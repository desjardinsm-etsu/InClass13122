Console.WriteLine("Hello World!");

int x = 3;

if(x > 3)
{
    Console.WriteLine("True");
}
else 
{ 
    Console.WriteLine("False"); 
}

string whatToSay = x > 3 ? "True" : "False";



//Console.WriteLine(name ?? "Not Logged In!");

int num = 1;

object number = num;



long longNumber = (long)number;

//int number23 = "1";

//var result = number23 / number23;

string name2 = "Mathew";

char letter = name2[name2.Length - 1];

string path = @"c:\documents\files\myfile.txt";

string somethingCool = "something " + 1 + " something else";
string somethingEvenBEtter = @$"s/omething {name2} something else"; 