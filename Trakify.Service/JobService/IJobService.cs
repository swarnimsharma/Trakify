using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;

namespace Trakify.Service.JobService
{
  public  interface IJobService
    {
        IEnumerable<Trakify_Job> GetJobs();
        Trakify_Job GetJob(long id);
        void InsertJob(Trakify_Job job);
        void UpdateJob(Trakify_Job job);
        void DeleteJob(long id);
    }
}
