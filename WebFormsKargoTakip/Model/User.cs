using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using WebFormsKargoTakip.Model.Common;

namespace WebFormsKargoTakip.Model
{
    public class User:BaseEntity
    {
        [Required, StringLength(30), Display(Name = "Name")]
        public string Name { get; set; }
        [Required, StringLength(30), Display(Name = "EMail")]
        public string EMail { get; set; }
        [Required, StringLength(30), Display(Name = "UserName")]
        public string UserName { get; set; }
        [Required, StringLength(30), Display(Name = "Password")]
        public string Password { get; set; }
    }
}