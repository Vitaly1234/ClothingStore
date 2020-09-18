using Entities.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Product
    {
        [Column("ProductId")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(60, ErrorMessage = "Max length is 60 characters.")]
        public string Name { get; set; }

        [MaxLength(300, ErrorMessage = "Max length is 300 characters.")]
        public string Description { get; set; }

        public DateTime? Arrived { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public ProductAvailabilityEnum Availability { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public ProductTypeEnum Type { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public ProductSizeEnum? Size { get; set; }
    }
}