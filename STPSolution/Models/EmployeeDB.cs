using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace STPSolution.Models
{
    [Table("EmployeeDB")]
    public class EmployeeDB
    {
        [Key]
        [Column("IdEmployee")]
        public int IdEmployee { get; set; }

        
        [Column("IdCompany")]       
        public int IdCompany { get; set; }
        

        [Column("Experience")]
        [StringLength(1)]
        public string Experience { get; set; }

        [Column("StatrtDate")]
        public DateTime StartDate { get; set; }

        [Column("Salary")]
        public int Salary { get; set; }

        [Column("VacatinsDays")]
        public int VacantionsDays { get; set; }

    }
}