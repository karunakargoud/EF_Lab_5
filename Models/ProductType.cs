using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Lab_5.Models
{
    [Table("ProductType")]
    internal class ProductType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int ProductTypeId { get; set; }
        [Required]
        [StringLength(15)]
        [Column("PTName")]
        public string ProductTypeName { get; set; }
        public List<Product> products { get; set; }
    }
}
