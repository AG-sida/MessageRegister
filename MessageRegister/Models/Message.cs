using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageRegister.Models
{
    public class Message
    {
        public int Id { get; set; }
        public DateTime MesaggeTime { get; set; }
        public String MessageUser { get; set; }
    }
}