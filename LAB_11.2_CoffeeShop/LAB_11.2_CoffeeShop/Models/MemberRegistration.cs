using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LAB_11._2_CoffeeShop.Models
{
    public class MemberRegistration
    {
        private string firstName;
        private string lastName;
        private string email;
        private string mobile;
        private bool newsletter;
        private string birthMonth;
        private string birthDay;
        private string birthYear;
        private string gender;
        private string password;
        private string confirmPassword;

        [DisplayName("First Name")]
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string FirstName { get => firstName; set => firstName = value; }

        [DisplayName("Last Name")]
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string LastName { get => lastName; set => lastName = value; }

        [DisplayName("E-mail")]
        [EmailAddress]
        [Required]
        public string Email { get => email; set => email = value; }

        [DisplayName("Mobile")]
        [RegularExpression(@"^((\d).{9,})$")]
        public string Mobile { get => mobile; set => mobile = value; }

        [DisplayName("News Letter")]
        public bool Newsletter { get => newsletter; set => newsletter = value; }

        [Required]
        public string BirthMonth { get => birthMonth; set => birthMonth = value; }

        [Required]
        public string BirthDay { get => birthDay; set => birthDay = value; }

        [Required]
        public string BirthYear { get => birthYear; set => birthYear = value; }

        [DisplayName("Gender")]
        [Required]
        public string Gender { get => gender; set => gender = value; }

        [DisplayName("Password")]
        [RegularExpression(@"^((?=.*[A-Z]).(?=.*\d).{10,})$")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get => password; set => password = value; }

        [DisplayName("Confirm Password")]
        [RegularExpression(@"^((?=.*[A-Z]).(?=.*\d).{10,})$")]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get => confirmPassword; set => confirmPassword = value; }
        
    }
}
