using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFormsKargoTakip.Model.Common;

namespace WebFormsKargoTakip.Model
{
    public class Cargo:BaseEntity
    {
        public string SenderName { get; set; }
        public string BuyerName { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; } = false;
    }
}