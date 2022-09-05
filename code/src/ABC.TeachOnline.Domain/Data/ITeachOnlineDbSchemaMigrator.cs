using System.Threading.Tasks;

namespace ABC.TeachOnline.Data
{
    public interface ITeachOnlineDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
