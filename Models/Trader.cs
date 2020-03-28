using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TradersPortal.Models
{
    public class Trader
    {
        public int TraderId { get; set; }

        [Display(Name = "Business Name")]
        public string BusinessName { get; set; }

        public string ContactFirstName { get; set; }

        public string ContactLastName { get; set; }

        public string Telephone { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }


        [Display(Name = "Registration Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? RegistrationDate { get; set; }


        [Display(Name = "Trade")]
        public int TradeId { get; set; }
        public Trade Trade { get; set; }

        [Display(Name = "State")]
        public int StateId { get; set; }
        public State State { get; set; }





    }       
}