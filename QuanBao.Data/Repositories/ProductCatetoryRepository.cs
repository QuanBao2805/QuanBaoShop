using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanBao.Data.Infrastructure;
using QuanBao.Model.Models;

namespace QuanBao.Data.Repositories
{
    // neu muon dung them phuong thuc
    public interface IProductCatetoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    public class ProductCatetoryRepository : RepositoryBase <ProductCategory>, IProductCatetoryRepository
    {
        //contructer goi tu RepositoryBase de su dung
        public ProductCatetoryRepository(IDbFactory dbFactory) 
            : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}
