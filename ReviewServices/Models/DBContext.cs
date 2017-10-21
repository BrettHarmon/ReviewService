namespace ReviewServices.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using ReviewServices.Models.Classes;

    public class DBContext : DbContext
    {
        public DBContext()
            : base("name=ReviewPage")
        {
        }

        
         public virtual DbSet<Series> Series { get; set; }
    }
}