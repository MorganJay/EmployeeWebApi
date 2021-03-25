using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

#nullable disable

namespace EmployeeWebApi.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }

        [StringLength(500)]
        [Required]
        public string EmployeeName { get; set; }

        [StringLength(500)]
        [Required]
        public string Department { get; set; }

        [Column(TypeName = "date")]
        [Required]
        public DateTime? DateEmployed { get; set; }

        //public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
        //{
        //    public EmployeeConfiguration()
        //    {
        //        Property(b => b.DateEmployed);
        //    }
        //}

        [StringLength(500)]
        public string PhotoFileName { get; set; }
    }
}