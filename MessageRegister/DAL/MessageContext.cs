using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MessageRegister.DAL
{
    public class MessageContext : DbContext
    {
        public MessageContext() : base("TestMessageConnection")
        { }

        public DbSet<Models.Message> Messages { get; set; }
    }
}