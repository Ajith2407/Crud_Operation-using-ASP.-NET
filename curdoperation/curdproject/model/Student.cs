using System.ComponentModel.DataAnnotations;

namespace curdproject.model
{
    public class Student   //property, model , entity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; } 

        public string? Address { get; set; }

        public int PhoneNo {  get; set; }

    }
}
