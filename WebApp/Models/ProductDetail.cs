using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ProductDetail
    {   [Key]
        public int Pid { get; set; }
        [Required]
        [Column(TypeName="nvarchar(100)")]
        public string Product { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public string Cid { get; set; }
    }
}
