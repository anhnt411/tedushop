using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    public class DbFactory:Disposable,IDbFactory
    {
        private RealMVCDbContext dbContext;

        public RealMVCDbContext Init()
        {
            return dbContext ?? (dbContext = new RealMVCDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }

    }
}
