using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoShop.Data
{
    internal class EcoShopDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
