using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HWMvcPartThree.Models
{
    public class Food
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Cant be null")]
        public string NameP { get; set; }
        [Required(ErrorMessage = "Cant be null")]
        public decimal Cost { get; set; }
        [Required(ErrorMessage = "Cost can not be zero")]
        public DateTime InsertDate { get; set; }
        public int FoodCategoryId { get; set; }
        [ForeignKey("FoodCategoryId")]
        public virtual FoodCategory FoodCategory { get; set; }
    }
}
