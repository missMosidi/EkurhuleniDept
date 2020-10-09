using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ekurhuleni.Models
{
    public partial class Tarrifs
    {
        [Key]
        public string tarrifID { get; set; }
        public string Btarrif { get; set; }
        public string ResTarrif { get; set; }
    }
}