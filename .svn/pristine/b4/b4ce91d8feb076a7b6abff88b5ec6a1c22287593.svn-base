using Ekurhuleni.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ekurhuleni.Models
{
    public partial class Contractor
    {
        [Key]
        public int contractorID { get; set; }
        [Display(Name = "Title")]
        [Required(ErrorMessage = "Title is Required")]
        public Title title { get; set; }

        [Display(Name = "Initials")]
        [Required(ErrorMessage = "Initials is Required")]
        public string initials { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is Required")]
        public string name { get; set; }

        [Display(Name = "Surname")]
        [Required(ErrorMessage = "Surname is Required")]
        public string surname { get; set; }

        [Display(Name = "Business Name")]
        [Required(ErrorMessage = "Business name is Required")]
        public string businessName { get; set; }

        [Display(Name = "Contact Person")]
        [Required(ErrorMessage = "Contact Person is Required")]
        public string contactPerson { get; set; }

        [Display(Name = "Office Number")]
        [Required(ErrorMessage = "Office number is Required")]
        public string officeNumber { get; set; }

        [Display(Name = "Cellphone Number")]
        [Required(ErrorMessage = "Cellphone number is Required")]
        public string cellNumber { get; set; }

        [Display(Name = "ID type")]
        [Required(ErrorMessage = "ID type is Required")]
        public Identification IDNumberType { get; set; }

        [Display(Name = "ID Number")]
        [Required(ErrorMessage = "ID number is Required")]
        public string IDNumber { get; set; }

        public string faxNumber { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is Required")]
        public string email { get; set; }
        [Display(Name = "Registration Number")]
        [Required(ErrorMessage = "Registration number is Required")]
        public string RegNo { get; set; }

    }
}