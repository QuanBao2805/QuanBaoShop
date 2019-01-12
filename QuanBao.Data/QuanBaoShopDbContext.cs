using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using QuanBao.Model.Models;

namespace QuanBao.Data
{
    public class QuanBaoShopDbContext: DbContext
    {
        // create contructer
        public QuanBaoShopDbContext()  : base("QuanBaoShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false; // khoa load bang cha thi khong load bang con nua
        }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menus{ get; set; }
        public DbSet<MenuGroup> MenuGroups{ get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<OrderDetail> OrderDetails{ get; set; }
        public DbSet<Page> Pages{ get; set; }
        public DbSet<Post> Posts{ get; set; }
        public DbSet<PostCategory> PostCategories{ get; set; }
        public DbSet<PostTag> PostTags{ get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<ProductCategory> ProductCategories{ get; set; }
        public DbSet<ProductTag> ProductTags{ get; set; }
        public DbSet<Slide> Slides{ get; set; }
        public DbSet<SupportOnline> SupportOnlines{ get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<Tag> Tags{ get; set; }
        public DbSet<VisitorStatistic> VisitorStatistics { get; set; }

        // ghi dde dung cho null. vi khong ghi de no se chay trong DbContext
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
