﻿using Ekurhuleni.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ekurhuleni.Models
{
    public partial class Residents
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Home Or Business")]
        public string UserType { get; set; }
        [Display(Name="Meter Type")]
        public meterType meterType { get; set; }
        [Display(Name = "Name/Company Name")]
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        [Display(Name = "ID OR Passport")]
        public Identification IdType { get; set; }
        [Display(Name = "Company Email")]
        [Required(ErrorMessage = "Email is Required")]
        public string email { get; set; }
        [Display(Name = "Company Registration Number")]
        [Required(ErrorMessage = "VAT is Required")]
        public string vat { get; set; }
        [Display(Name = "Voltage")]
       [Required(ErrorMessage = "Voltage is Required")]
        public Voltages voltage { get; set; }
        [Display(Name = "Circut Breaker")]
        [Required(ErrorMessage = "Circuit Size is Required")]
        //[ForeignKey("Id")]
        public string size { get; set; }
        public virtual CircuitBreaker CircuitBreaker { get; set; }
        [Display(Name = "Type of Tarrif")]
        [Required(ErrorMessage = "Tarrif is Required")]
        public ResTarrifs resTarrif { get; set; }
        [Display(Name="Application Status")]
        public string AppStatus { get; set; }
        public CustomerProfile CustomerProfile { get; set; }
        [Required]
        [Display(Name = "Type Of Application")]
        public string TypeOfApplication { get; set; }
        public virtual ApplicationType ApplicationType { get; set; }
    }
}
