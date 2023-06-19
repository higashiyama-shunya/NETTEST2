using System.ComponentModel.DataAnnotations;

namespace Test2.Models
{
    public class Class
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        public int Time { get; set; }
        public string? SurName { get; set; }
    }
}
