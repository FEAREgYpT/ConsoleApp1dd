using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;


/*TimeOnly worktimebeginning = new TimeOnly(8, 20);
TimeOnly now = TimeOnly.FromDateTime(DateTime.Now);
TimeSpan span = now - worktimebeginning;
Console.WriteLine($"The hours that he worked equal : {span}");
Console.WriteLine($"Duration : {span.TotalMinutes}");
DateTime datenow = DateTime.Now;
Console.WriteLine($"date and time now is {datenow}");
DateOnly today = DateOnly.FromDateTime(DateTime.Now);
Console.WriteLine($"Date now is : {today}");
Console.WriteLine($"Time now is : {now}");*/

Console.WriteLine("----------------------------------------");


/* int AgeAhmad = 15;
string AgeIslam = "35";
int IntAgeIslam = int.Parse(AgeIslam);
int Sum = AgeAhmad + IntAgeIslam;
Console.WriteLine( "AgeAhmad + AgeIslam is :" + Sum); */

Console.WriteLine("----------------------------------------");

/*double IntIslamAge = 35.5;
string StrIslamAge = Convert.ToString(IntIslamAge);
string statment = "Age of Islam In String Not in Integer is ";
Console.WriteLine(statment + StrIslamAge);
Console.WriteLine("Age of Islam In String Not in Integer is :" + IntIslamAge.ToString());*/

Console.WriteLine("----------------------------------------");
/*

string firstmessage = string.Format("there are {0} live Computers in our company", 100);
Console.WriteLine(firstmessage);

int Total = 200;
string TotalStatment = string.Format(firstmessage + " of {1}",100,Total);
Console.WriteLine(TotalStatment);
Console.WriteLine(firstmessage + " of {1}",100,Total);

Console.WriteLine("first message length is :" + firstmessage.Length);
Console.WriteLine("Total message length is : " + TotalStatment.Length);

string String1 = string.Format("there are {0} live Computers in our company", 100);
string string2 = string.Format(" of {0}",Total);
string finalString = string.Concat(String1, string2);
Console.WriteLine(finalString);*/

Console.WriteLine("----------------------------------------");
/*
int sallary = 1250;
int pounus = 500;
int sum = sallary + pounus;
Console.WriteLine("The sallary in Egy Pound is : " + sallary.ToString("c"));
Console.WriteLine($"The Sallary + ponus in Egy pound = {sallary.ToString("c") + pounus.ToString("c")}");
Console.WriteLine($"The Sallary + ponus in Egy pound : " + sum.ToString("c"));*/

Console.WriteLine("----------------------------------------");
/*
int pounus = int.Parse("$500", NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
int sallary = int.Parse("$1250", NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
int sum = sallary + pounus;
Console.WriteLine($"The Sallary + ponus in $ : " + sum.ToString("c"));*/

Console.WriteLine("----------------------------------------");


/*DateTime datenow = new DateTime(2025, 4, 25);
Console.WriteLine(datenow.DayOfWeek);*/

Console.WriteLine("----------------------------------------");
/*
string[] names1 = { "Ahmad", "ali", "said" };
string[] names2 = { "islam"," alaa","muhammad"};
*/

Console.WriteLine("----------------------------------------");

/*
string[] names1legnth = new string[names1.Length];
string[] names2legnth = new string[names2.Length];*/
/*int intnames1legnth = int.Parse(names1legnth);
int intnames2legnth = int.Parse(names2legnth);*/
/*

var totalCountnames1 = names1.Count();
var totalCountnames2 = names2.Count();
int sum = totalCountnames1 + totalCountnames2;
Array.Resize(ref names1, sum);
names2.CopyTo(names1, totalCountnames1);

/*
Console.WriteLine(names1[0]);
Console.WriteLine(names1[1]);
Console.WriteLine(names1[2]);
Console.WriteLine(names1[3]);
Console.WriteLine(names1[4]);
Console.WriteLine(names1[5]);

for (int i = 0; i < names1.Length; i++)
{
    Console.WriteLine(names1[i]);
}
*/

int[] numbers = new int[5];
for (int i = 0; i < numbers.Length; i++)
{
    while (true) // حلقة لا نهائية حتى إدخال قيمة صالحة
    {
        Console.WriteLine("Enter an integer value: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out numbers[i]))
            break; // الخروج من الحلقة إذا كانت القيمة صالحة
        Console.WriteLine("Invalid input. Please enter a valid number:");
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"the index of {i + 1} is " + numbers[i]);

}

Console.WriteLine("----------------------------------------");


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("أدخل الأرقام مفصولة بمسافات (مثال: 10 20 30):");
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        // طباعة المصفوفة للتأكد
        Console.WriteLine("الأرقام المدخلة:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}

Console.WriteLine("----------------------------------------");

using System.Linq;

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

Console.WriteLine("----------------------------------------");

int[] numbers = new int[3];
Console.WriteLine("أدخل 3 أرقام (رقم لكل سطر):");
for (int i = 0; i < numbers.Length; i++) numbers[i] = int.Parse(Console.ReadLine());

Console.WriteLine("----------------------------------------");


int[] numbers = new int[5];
for (int i = 0; i < numbers.Length; i++)
    while (!int.TryParse(Console.ReadLine(), out numbers[i]))
        Console.WriteLine("إدخال خاطئ! أدخل رقمًا صحيحًا:");

Console.WriteLine("----------------------------------------");




