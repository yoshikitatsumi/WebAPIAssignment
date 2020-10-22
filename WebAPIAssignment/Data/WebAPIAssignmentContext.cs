using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIAssignment.Models;

namespace WebAPIAssignment.Data
{
    public class WebAPIAssignmentContext : DbContext
    {
        public WebAPIAssignmentContext (DbContextOptions<WebAPIAssignmentContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPIAssignment.Models.TodoItem> TodoItem { get; set; }
    }
}
