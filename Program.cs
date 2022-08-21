// Dictionary
using System.Linq;
using System.Collections.Generic;
// int is key , syting = value
Dictionary<int,string> dict = new Dictionary<int, string>();
dict.Add(11,"nasr");
dict.Add(22,"Oma");
dict.Add(13,"nar");
dict.Add(44,"nsr");
dict.Add(55,"asr");
// add items to Dictionary
System.Console.WriteLine(dict[11]);
System.Console.WriteLine(dict[22]);
System.Console.WriteLine(dict[13]);
System.Console.WriteLine(dict[44]);
System.Console.WriteLine(dict[55]);
// Can use any key and value data types, such ad char string etc
Dictionary<char,string> c = new Dictionary<char, string>();
c.Add('A',"Ahamd");
c.Add('B',"Bhamd");
c.Add('C',"Chamd");
c.Add('D',"Dhamd");
c.Add('E',"Ehamd");
c.Add('F',"Fhamd");
System.Console.WriteLine(c['A']);
System.Console.WriteLine(c['B']);
System.Console.WriteLine(c['C']);
System.Console.WriteLine(c['D']);
System.Console.WriteLine(c['E']);
System.Console.WriteLine(c['F']);

// different way to declare dictionary

var emps = new Dictionary<string,string>();
emps.Add("n1","kk");
emps.Add("n2","ky");
emps.Add("n3","kt");
System.Console.WriteLine(emps["n1"]);
System.Console.WriteLine(emps["n2"]);
System.Console.WriteLine(emps["n3"]);

//  new way, declare and initilize

var d =new Dictionary<int,char>() {{1,'A'},{2,'B'}};
System.Console.WriteLine(d[1]);
System.Console.WriteLine(d[2]);
System.Console.WriteLine(d.Values.Contains('A'));
System.Console.WriteLine(d.Values.Contains('a'));
System.Console.WriteLine(d.Keys.Contains('2'));
System.Console.WriteLine("===========================");
// You can use the below without importing Linq;
System.Console.WriteLine(d.ContainsValue('A'));
System.Console.WriteLine(d.ContainsValue('a'));
System.Console.WriteLine(d.ContainsKey('2'));
// remove elements

// System.Console.WriteLine("count now : {0}", d.Count);
// d.Remove('B');

// System.Console.WriteLine("count now : {0}", d.Count);
// d.Remove('F');

// System.Console.WriteLine("count now : {0}", d.Count);


