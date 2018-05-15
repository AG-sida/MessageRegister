namespace MessageRegister.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MessageRegister.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MessageRegister.DAL.MessageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MessageRegister.DAL.MessageContext context)
        {
            context.Messages.AddOrUpdate(x => x.Id,
          new Message() { Id = 1, MesaggeTime = new DateTime(2012, 06, 15, 13, 45, 00), MessageUser = "Jane Austen" },
          new Message() { Id = 2, MesaggeTime = new DateTime(2013, 06, 15, 13, 45, 00), MessageUser = "Charles Dickens" },
          new Message() { Id = 3, MesaggeTime = new DateTime(2017, 06, 15, 13, 45, 00), MessageUser = "Miguel de Cervantes" }
          );
        }
    }
}

