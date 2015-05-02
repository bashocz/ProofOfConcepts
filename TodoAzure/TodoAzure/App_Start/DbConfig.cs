using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoAzure.Models;

namespace TodoAzure
{
    public class DbConfig
    {
        public static void Configure()
        {
            using (var db = new TodoContext())
            {

            }
        }
    }
}