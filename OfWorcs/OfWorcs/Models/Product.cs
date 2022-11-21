using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

public class Product
{
        [Key]
        public int Id { get; set; }
        [Unicode]
        [Required]
        [MaxLength(24)]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }

        public override string ToString()
            => $"[{Id}]\tName: {Name}\tPrice: {Price}";
}
