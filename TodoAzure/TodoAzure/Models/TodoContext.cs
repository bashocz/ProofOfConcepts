using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TodoAzure.Models
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        public TodoContext()
            : base("TodoDB")
        {
            Database.SetInitializer<TodoContext>(new DropCreateDatabaseIfModelChanges<TodoContext>());
        }
    }
}