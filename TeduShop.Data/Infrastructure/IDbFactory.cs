using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    //Giao tiep khoi tao cac entity
    public interface IDbFactory : IDisposable
    {
        TeduShopDbContext Init();
    }
}
