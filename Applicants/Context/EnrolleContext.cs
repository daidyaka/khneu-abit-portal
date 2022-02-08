using Enrollee.Models;
using Microsoft.EntityFrameworkCore;

namespace Enrollee.Context
{
    public class EnrolleContext:DbContext
    {
        public DbSet<Feedback> Feedbacks { get; set; }
        public EnrolleContext(DbContextOptions<EnrolleContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
