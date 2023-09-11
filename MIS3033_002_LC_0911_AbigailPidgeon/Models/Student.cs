using System.ComponentModel.DataAnnotations;

namespace a
{
    public class Student
    {
        [Key]
        public string Id { get; set; }//member field
        public string Name { get; set; }
        public int Age { get; set; }

        public static string Instructor { get; set; } = "Xinglong Ju";//static
        // static is not going to write to the database 

        public override string ToString()//member function
        {
            return string.Format($"ID:{Id},Name:{Name}");
        }

    }
}