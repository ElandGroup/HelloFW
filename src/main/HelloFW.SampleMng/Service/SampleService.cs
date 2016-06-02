using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelloFW.SampleMng.Dao;

namespace HelloFW.SampleMng.Service
{
    public class SampleService : ISampleService
    {
        public ISampleDao SampleDao
        {
            private get; set;
        }
        public DateTime GetDate()
        {
            return SampleDao.GetDate();
        }
    }
}
