using a;
using b;
using System.Text.Json;

Console.WriteLine("Sep 13, student db");
// db manipulations => LINQ (collection extension funtions)=> lambda expression=>delegate
// lamda expression, arrow function => function, shortcut way to write a function

//assignment(accumulator assignment)
//how to define functions
//simple vs complex 

StudentDB db;//complex 
db = new StudentDB();

string filepath = "data.txt";

var opt = new JsonSerializerOptions();
opt.WriteIndented= true;

string jsonstr;

//collection extension functions 
var r1 = db.StudentsTbl.Take(3).FirstOrDefault();//student

//var r3 = db.StudentsTbl.Min(x=>x.Age);//student ctrl d

var r3 = db.StudentsTbl.ToList().MinBy(x=>x.Age);//student ctrl d

jsonstr = JsonSerializer.Serialize(r3, opt);
File.WriteAllText(filepath, jsonstr);

bool r2;
r2 = checkage(r1);
Console.WriteLine(r2);

r2 = checkid(r1);
Console.WriteLine(r2);

funtype1 funcard1;//funtype1 complex

funcard1 = checkage;
r2 = funcard1(r1);
Console.WriteLine(r2);

funcard1 = checkid;
r2 = funcard1(r1);
Console.WriteLine(r2);

funtype1 funcard2;// complex, null
funcard2 = (Student x) => { return x.Name.ToLower() == "david"; };//arrow function,anonymous function lambda expresion shorcut way to write function

funcard2 = (x) => { return x.Name.ToLower() == "david"; };//arrow function,anonymous function

funcard2 = x => { return x.Name.ToLower() == "david"; };//arrow function,anonymous function, only applys when u have one paramater

funcard2 = x => x.Name.ToLower() == "david";//arrow function,anonymous function only applies when u have one line of code in the function bidy

funcard2 = x => x.Age == 20; //arrow function,anonymous function 

r2 = funcard2(r1);
Console.WriteLine(r2);


// the above code is for database manipulation
// the below code is function definition 

bool checkage(Student s)
{
    return s.Age == 20;
}

bool checkid(Student s)
{
    return s.Id.ToLower() == "s126";
}

// delegate to define a function type 

delegate bool funtype1(Student x);//funtype1 car,complex 