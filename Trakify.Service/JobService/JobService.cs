using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;
using Trakify.Repository;
using Trakify.Repository.Common;

namespace Trakify.Service.JobService
{
   public class JobService : IJobService
    {
        private readonly IRepository<Trakify_Job> jobRepository;
        public JobService(IRepository<Trakify_Job> jobRepository)
        {
            this.jobRepository = jobRepository;
        }

        public void DeleteJob(long id)
        {
            Trakify_Job userProfile = jobRepository.Get(id);
            jobRepository.Remove(userProfile);
            jobRepository.SaveChanges();
        }

        public Trakify_Job GetJob(long id)
        {
            return jobRepository.Get(id);
        }

        public IEnumerable<Trakify_Job> GetJobs()
        {
            return jobRepository.GetAll();
        }

        public void InsertJob(Trakify_Job job)
        {
            jobRepository.Insert(job);
        }

        public void UpdateJob(Trakify_Job job)
        {
            jobRepository.Update(job);
        }
    }
}
