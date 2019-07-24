using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace Lanny.Web.EF.Test.CommService
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //public DbSet<Student>    Student      { get; set; }
        //public DbSet<ClassEntiy> ClassEntitys { get; set; }
    }
}
