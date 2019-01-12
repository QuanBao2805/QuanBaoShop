using System;
using System.Collections.Generic;
using System.Linq;
using QuanBao.Data.Infrastructure;
using QuanBao.Model.Models;

namespace QuanBao.Data.Repositories
{
    
    public interface IProductRepository
    {

    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
}
