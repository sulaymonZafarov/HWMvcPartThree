using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HWMvcPartThree.Models.ViewModels
{
    public class FoodViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage= "Can not be null")]
        public string NameP { get; set; }
        [Required(ErrorMessage ="Can not be null")]
        public decimal Cost { get; set; }
        public DateTime InsertDate { get; set; }
        [Required]
        public int FoodCotegoryId { get; set; }
        public string FoodCotegoryName { get; set; }
        public List<SelectListItem> Cotegories { get; set; } = new List<SelectListItem>();

    }
}
