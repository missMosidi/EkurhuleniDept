using Ekurhuleni.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ekurhuleni.Models
{
    public partial class CustomerProfile
    {

        public Guid Id { get; set; }
        [Display(Name ="Type of Customer"),Required]
        public TypeOfCustomer TypeOfCustomer { get; set; }
        [Display(Name ="First Name"),Required]
        [StringLength(50,MinimumLength =3)]
        public string FName { get; set; }
        [Display(Name = "Last Name"), Required]
        [StringLength(50, MinimumLength = 3)]
        public string LName { get; set; }
        [Required]
        public Title Title { get; set; }
        [Display(Name ="ID Number"),StringLength(13,MinimumLength =13),Required]
        [RegularExpression("^[0-9]*$",ErrorMessage ="Identity Number Invalid")]
        public string IDNumber { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Display(Name = "Cell Phone Number"),StringLength(10,MinimumLength =10),Required]
        [DataType(DataType.PhoneNumber)]
        public string Cell_Phone { get; set; }
        [Display(Name ="Work Phone Number"),StringLength(10,MinimumLength =10)]
        [DataType(DataType.PhoneNumber)]
        public string Work_Phone { get; set; }
        [Display(Name ="Unit Number")]
        public string Unit_Number { get; set; }
        [Display(Name="Block/Complex Name")]
        public string Block_Complex_Name { get; set; }
        [Display(Name ="Street Name"),Required]
        public string Street_Name { get; set; }
        [Display(Name ="Suburb"),Required]
        public string Suburb { get; set; }
        [Display(Name ="Postal Code"),Required]
        [DataType(DataType.PostalCode)]
        public string Postal_Code { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }



    }
}