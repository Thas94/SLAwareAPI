using Microsoft.EntityFrameworkCore;
using SLAwareApi.Entities.SLAware;


namespace TFTShuttiAPI.TFTEntities.Helpers
{
    public class ClinicalEntityHelper
    {

        //public async Task<List<T>> ExecuteCommandDataTableAsync<T>(string SQL) where T : class
        //{
        //    try
        //    {
        //        List<T> test = new List<T>();
        //        using (slaware_dataContext db = new slaware_dataContext())
        //        {
        //            List<T> result = await db.Set<T>().FromSqlRaw(SQL).ToListAsync();

        //            return result;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        return null;
        //    }
        //}

        //public int ExecuteCommandScalar(string SQL)
        //{
        //    return 0;

        //    try
        //    {
        //        using (slaware_dataContext db = new slaware_dataContext())
        //        {
        //            return db.Database.ExecuteSqlInterpolated($"{SQL}");
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        return 0;
        //    }
        //}

    }
}
