using BOL;

namespace DAL
{
    public class DbBase
    {
        protected PlanificacionDbEntities db;

        public DbBase() => db = new PlanificacionDbEntities();
    }
}
