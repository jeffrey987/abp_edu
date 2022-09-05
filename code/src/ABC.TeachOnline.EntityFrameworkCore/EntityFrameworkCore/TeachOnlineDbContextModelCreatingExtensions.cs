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
        }
    }
}