// MIS 3033 002
// September 11 2023
// Abigail Pidgeon
using b;
using a;
using System.Text.Json;
using System.Xml.Linq;

Console.WriteLine("Entity Famework");

StudentDB studb;// complex
studb = new StudentDB();// we connect to database

Student stu;
stu = new Student() { Id="s126",Name="Abigail Pidgeon",Age=21};
//stu.name = "Abigail Pidgeon"

//studb.StudentsTbl.Add(stu);//studb.studentstbl in the computer memoery
//studb.SaveChanges();

// static
Student stu2;//complex
stu2 = new Student() { Id = "S1", Name = "Dolly Parton", Age = 67 };
Console.WriteLine(Student.Instructor);

// anonymos class type
var r1 = new { Id = "s2", Name = "Travis Kelce" };
Console.WriteLine(r1.Name);

// file JSON
string filepath = "data.txt";
File.WriteAllText(filepath, "200");

// {} []
// {}, holds one record
// []: collection, holds multiple records but can be null

string outMesStr;

var opt = new JsonSerializerOptions();
opt.WriteIndented = true;// member field 

outMesStr = JsonSerializer.Serialize(stu2,opt);//static //function overload
Console.WriteLine(outMesStr);
File.WriteAllText(filepath, outMesStr);

//[]
var r2 = studb.StudentsTbl.Take(1);//r2 collection
outMesStr = JsonSerializer.Serialize(r2, opt);//static //function overload
Console.WriteLine(outMesStr);
File.WriteAllText(filepath, outMesStr);

// delegate, lambda expression
// lambda expression: is a way to write a function. it is a shortcut to write said function.
// arrow function

int age1;// int datatype, age1: variable 
int age2;// 

Student stu3;
stu3 = new Student() { Id = "S2", Name = "Jason Kelece", Age = 48 };
//Console.WriteLine(stu3.ToString());

bool CheckAge(Student s)
{
    return s.Age == 21;
}

bool CheckID(Student s)
{
    return s.Id == "s126";
}

Console.WriteLine(CheckAge(stu));