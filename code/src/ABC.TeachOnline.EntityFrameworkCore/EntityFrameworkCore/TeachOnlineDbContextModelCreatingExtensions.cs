using ABC.TeachOnline.Books;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ABC.TeachOnline.EntityFrameworkCore
{
    public static class TeachOnlineDbContextModelCreatingExtensions
    {
        public static void ConfigureTeachOnline(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(TeachOnlineConsts.DbTablePrefix + "YourEntities", TeachOnlineConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
            builder.Entity<Book>(b =>
            {
                b.ToTable(TeachOnlineConsts.DbTablePrefix + "Books",
                          TeachOnlineConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            });
            builder.Entity<User>(b =>
            {
                b.ToTable(TeachOnlineConsts.DbTablePrefix + "User",
                          TeachOnlineConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            });
            builder.Entity<Apis>(b =>
            {
                b.ToTable(TeachOnlineConsts.DbTablePrefix + "Api",
                          TeachOnlineConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
            });
            builder.Entity<UserAuthority>(b =>
            {
                b.ToTable(TeachOnlineConsts.DbTablePrefix + "UserAuthority",
                          TeachOnlineConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
            });
            builder.Entity<Authorities>(b =>
            {
                b.ToTable(TeachOnlineConsts.DbTablePrefix + "Authorities",
                          TeachOnlineConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props                
            });
            builder.Entity<BaseMenus>(b =>
            {
                b.ToTable(TeachOnlineConsts.DbTablePrefix + "BaseMenu",
                          TeachOnlineConsts.DbSchema);
                b.ConfigureByConvention();             
            });
            builder.Entity<BaseMenuParameters>(b =>
            {
                b.ToTable(TeachOnlineConsts.DbTablePrefix + "BaseMenuParameters",
                          TeachOnlineConsts.DbSchema);
                b.ConfigureByConvention();
            });
            builder.Entity<BaseMenuBtns>(b =>
            {
                b.ToTable(TeachOnlineConsts.DbTablePrefix + "BaseMenuBtn",
                          TeachOnlineConsts.DbSchema);
                b.ConfigureByConvention();
            });
            builder.Entity<DataAuthorityId>(b =>
            {
                b.ToTable(TeachOnlineConsts.DbTablePrefix + "DataAuthorityId",
                          TeachOnlineConsts.DbSchema);
                b.ConfigureByConvention();
            });
            ///
        }
    }
}