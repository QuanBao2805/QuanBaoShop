using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanBao.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        QuanBaoShopDbContext dbContext;

        public QuanBaoShopDbContext Init()
        {
            return dbContext ?? (dbContext = new QuanBaoShopDbContext()); //neu no null thi khoi tao db
        }
        protected override void DisposeCore()
        {
            if(dbContext !=null)
            {
                dbContext.Dispose();
            }
        }
    }
}
