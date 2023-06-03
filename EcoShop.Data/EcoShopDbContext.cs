using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoShop.Data
{
    public class EcoShopDbContext: DbContext
    {
        public EcoShopDbContext(DbContextOptions<EcoShopDbContext> options ): base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
