using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABC.TeachOnline.Data
{
    /* This is used if database provider does't define
     * ITeachOnlineDbSchemaMigrator implementation.
     */
    public class NullTeachOnlineDbSchemaMigrator : ITeachOnlineDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}