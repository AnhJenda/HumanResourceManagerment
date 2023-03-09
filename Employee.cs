using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResourceManagerment
{
    [PrimaryKey("Id")]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public double salary { get; set; }
    }
}
