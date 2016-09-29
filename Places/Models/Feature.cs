using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Places.Models
{
    public class Feature
    {

        public int FeatureID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Display(Name="Image")]
        [DataType(DataType.ImageUrl)]     
        public string ImageUrl { get; set; }
    }
}