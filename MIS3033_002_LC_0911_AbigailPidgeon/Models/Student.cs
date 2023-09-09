using System.ComponentModel.DataAnnotations;

namespace a
{
    public class Student
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
}