using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class ProductDetail
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string code { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string productName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(MAX)")]
        public string description { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int price { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int discount { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int quantity { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(MAX)")]
        public string image { get; set; }
    }
}
