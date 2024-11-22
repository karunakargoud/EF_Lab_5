using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Lab_5.Models
{
    [Table("Product")]
    internal class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId {  get; set; }
        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(15)]
        public string Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        
        [ForeignKey("Category")]
        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("Brand")]
        [Required]
        public int BranndId {  get; set; }

        [ForeignKey("ProductType")]
        [Required]
        public int ProductTypeId { get; set; }

        //Navigation Properties

        public Category Category { get; set; }  

        public Brand Brand {  get; set; }

        public ProductType ProductType { get; set; }


    }
}
