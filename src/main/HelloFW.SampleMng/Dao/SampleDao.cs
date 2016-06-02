using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spring.Data.NHibernate.Generic.Support;

namespace HelloFW.SampleMng.Dao
{
    public class SampleDao :HibernateDaoSupport, ISampleDao
    {
        public DateTime GetDate()
        {
            return Session.CreateSQLQuery("SELECT GETDATE()")
                .UniqueResult<DateTime>();
        }
    }
}
