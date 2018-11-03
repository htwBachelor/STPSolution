using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace STPSolution.Models
{
    [Table("CompaniesDB")]
    public class CompaniesDB
    {
        [Key]
        [Column("IdCompany")]
        public int IdCompany { get; set; }

        [Column("CompanyName")]
        [StringLength(50)]
        public string CompanyName { get; set; }

        [Column("Inforamtion")]
        [StringLength(500)]
        public string Information { get; set; }
    }
}