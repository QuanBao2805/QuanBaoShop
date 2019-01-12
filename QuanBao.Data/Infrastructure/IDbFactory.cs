using System;

namespace QuanBao.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        QuanBaoShopDbContext Init();
    }
}
