using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPNET_todo_api.Models;

namespace ASPNET_todo_api.Data
{
    public class ASPNET_todo_apiContext : DbContext
    {
        public ASPNET_todo_apiContext (DbContextOptions<ASPNET_todo_apiContext> options)
            : base(options)
        {
        }

        public DbSet<Todo> Todo { get; set; }
    }
}
