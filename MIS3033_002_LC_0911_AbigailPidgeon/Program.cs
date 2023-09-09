// MIS 3033 002
// September 11 2023
// Abigail Pidgeon
using b;
using a;

Console.WriteLine("Entity Famework");

StudentDB studb;// complex
studb = new StudentDB();// we connect to database

Student stu;
stu = new Student() { Id="s126",Name="Abigail Pidgeon",Age=21};
//stu.name = "Abigail Pidgeon"

studb.StudentsTbl.Add(stu);//studb.studentstbl in the computer memoery

studb.SaveChanges();