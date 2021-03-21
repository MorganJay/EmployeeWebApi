using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace EmployeeWebApi.Models
{
    [Table("Department")]
    public partial class Department
    {
        public int DepartmentId { get; set; }

        [StringLength(500)]
        public string DepartmentName { get; set; }
    }
}