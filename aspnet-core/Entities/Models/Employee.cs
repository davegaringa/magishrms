using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    public class Employee : IEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string EmployeeNumber { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "Last Name can't be longer than 60 characters")]
        public string LastName { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "First Name can't be longer than 60 characters")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "Middle Name can't be longer than 60 characters")]
        public string MiddleName { get; set; }

        [StringLength(100, ErrorMessage = "Address can't be longer than 100 characters")]
        public string Address { get; set; }

        public DateTime? Birthday { get; set; }

        public byte? Gender { get; set; }

        public byte? MaritalStatus { get; set; }
    }
}
