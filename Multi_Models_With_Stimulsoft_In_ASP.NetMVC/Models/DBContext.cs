using System.Collections.Generic;
using System.Data.Entity;

namespace Multi_Models_With_Stimulsoft_In_ASP.NetMVC.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class DBContext : DbContext
    {
        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public DBContext()
            : base("DefaultConnection")
        {
        }
        /// <summary>
        /// استانها
        /// </summary>
        public DbSet<Province> Provinces { get; set; }
        /// <summary>
        /// شهرستانها
        /// </summary>
        public DbSet<City> Citys { get; set; }
    }
}