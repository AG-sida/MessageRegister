using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MessageRegister.Models
{
    public class Message
    {
        public int Id { get; set; }

           
        public DateTime MesaggeTime { get; set; } = DateTime.Now;

       
        [StringLength(160, ErrorMessage = "Your message cannot contain mora than 160 characters")]
        public String MessageUser { get; set; }
    }
}


