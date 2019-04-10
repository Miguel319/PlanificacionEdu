using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using BOL;

namespace DAL
{
    public class DbBase
    {
        protected PlanificacionDbEntities db;

        public DbBase() => db = new PlanificacionDbEntities();
    }
}
