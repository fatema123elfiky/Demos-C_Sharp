using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Models
{
    [Table("Students",Schema ="edu")]
    internal class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// no control on the identity moves
        public int Id { get; set; }
        
        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(100)]
        [Column("StdFirstName")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required.")]
        [MaxLength(100)]
        [Column("StdLastName")]
        public string LastName { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "Invalid email address.")]// validation only
        [MaxLength(100)]
        public string? Email { get; set; }

        [Range(16,80,ErrorMessage = "Age must be between 16 and 80.")] // validation only
        public int Age { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";
    }
}
