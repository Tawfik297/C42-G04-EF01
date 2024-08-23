using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    // 1. By Convension
    ///internal class Employee
    ///{
    ///    public int Id { get; set; }
    ///    public string Name { get; set; }
    ///    public double Salary { get; set; }
    ///    public int? Age { get; set; }
    ///}


    // 2. Data Annotation
    [Table("Employees" ,Schema ="dbo")]
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //[Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50 , MinimumLength =  10)]
        [MinLength(50)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public double Salary { get; set; }

        [Range(22,60)]
        public int? Age { get; set; }

        [EmailAddress]
        //[DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Phone]
        //[DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }


}
