using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LAB_11._2_CoffeeShop.Models
{
    public class ComparePassword
    {
        [Required(ErrorMessage = "Please Enter The Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required(ErrorMessage = "Conform Password Is Required")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string confirmPassword { get; set; }
    }
}
