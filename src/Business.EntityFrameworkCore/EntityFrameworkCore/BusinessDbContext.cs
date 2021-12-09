using Business.Model.Goods;
using Business.Model.RBAC;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Business.EntityFrameworkCore
{
    [ReplaceDbContext(typeof(IIdentityDbContext))]
    [ReplaceDbContext(typeof(ITenantManagementDbContext))]
    [ConnectionStringName("Default")]
    public class BusinessDbContext : 
        AbpDbContext<BusinessDbContext>,
        IIdentityDbContext,
        ITenantManagementDbContext
    {
        /* Add DbSet properties for your Aggregate Roots / Entities here. */
        
        #region Entities from the modules
        
        /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
         * and replaced them for this DbContext. This allows you to perform JOIN
         * queries for the entities of these modules over the repositories easily. You
         * typically don't need that for other modules. But, if you need, you can
         * implement the DbContext interface of the needed module and use ReplaceDbContext
         * attribute just like IIdentityDbContext and ITenantManagementDbContext.
         *
         * More info: Replacing a DbContext of a module ensures that the related module
         * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
         */
        
        //Identity
        public DbSet<IdentityUser> Users { get; set; }
        public DbSet<IdentityRole> Roles { get; set; }
        public DbSet<IdentityClaimType> ClaimTypes { get; set; }
        public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
        public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
        public DbSet<IdentityLinkUser> LinkUsers { get; set; }
        
        // Tenant Management
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

        #endregion
        
        public BusinessDbContext(DbContextOptions<BusinessDbContext> options)
            : base(options)
        {

        }


        public DbSet<MyUserModel> MyUserModel { get; set; }
        public DbSet<PartModel> PartModel { get; set; }
        public DbSet<PowerModel> PowerModel { get; set; }
        public DbSet<UserRoleModel> UserRoleModel { get; set; }
        public DbSet<PowerRoleModel> PowerRoleModel { get; set; }
        public DbSet<TreeModel> TreeModel { get; set; }


        public DbSet<CityModel> CityModel { get; set; }
        public DbSet<GoodsModel> GoodsModel { get; set; }
        public DbSet<LogisticsModel> LogisticsModel { get; set; }
        public DbSet<OrderForm> OrderForm { get; set; }
        public DbSet<ShoppingModel> ShoppingModel { get; set; }
        public DbSet<SpecificationModel> SpecificationModel { get; set; }
        public DbSet<CategoryModel> CategoryModel { get; set; }
        public DbSet<FileImg> FileImg { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Include modules to your migration db context */
            builder.Entity<MyUserModel>(x => x.ToTable("tb _MyUserModel"));
            builder.Entity<PartModel>(x => x.ToTable("tb _PartModel"));
            builder.Entity<PowerModel>(x => x.ToTable("tb _PowerModel"));
            builder.Entity<UserRoleModel>(x => x.ToTable("tb _UserRoleModel"));
            builder.Entity<PowerRoleModel>(x => x.ToTable("tb _PowerRoleModel"));
            builder.Entity<TreeModel>(x => x.ToTable("tb _TreeModel"));

            builder.Entity<CityModel>(x => x.ToTable("tb _CityModel"));
            builder.Entity<GoodsModel>(x => x.ToTable("tb _GoodsModel"));
            builder.Entity<LogisticsModel>(x => x.ToTable("tb _LogisticsModel"));
            builder.Entity<ShoppingModel>(x => x.ToTable("tb _ShoppingModel"));
            builder.Entity<SpecificationModel>(x => x.ToTable("tb _SpecificationModel"));
            builder.Entity<CategoryModel>(x => x.ToTable("tb _CategoryModel"));
            builder.Entity<FileImg>(x => x.ToTable("tb _FileImg"));
            builder.Entity<OrderForm>(x => x.ToTable("tb _OrderForm"));



        builder.ConfigurePermissionManagement();
            builder.ConfigureSettingManagement();
            builder.ConfigureBackgroundJobs();
            builder.ConfigureAuditLogging();
            builder.ConfigureIdentity();
            builder.ConfigureIdentityServer();
            builder.ConfigureFeatureManagement();
            builder.ConfigureTenantManagement();

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(BusinessConsts.DbTablePrefix + "YourEntities", BusinessConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}
