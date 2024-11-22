using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Lab_5.Models
{
    [Table("Category")]
    internal class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        
        public int CategoryId { get; set; }

        [Required]
        [StringLength(50)]
        [Column("CName")]
        public string CategoryName { get; set; }
        public List<Product> products { get; set; }
    }
}
