using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;
using Trakify.Repository.Common;

namespace Trakify.Service.PaymentTermsService
{
    public class PaymentTermsService : IPaymentTermsService
    {
        private readonly IRepository<Trakify_PaymentTerms> paymentTerm;
        public PaymentTermsService(IRepository<Trakify_PaymentTerms> paymentTerm)
        {
            this.paymentTerm = paymentTerm;
        }
        public void DeletePaymentTerm(long id)
        {
            Trakify_PaymentTerms userProfile = paymentTerm.Get(id);
            paymentTerm.Remove(userProfile);
            paymentTerm.SaveChanges();
        }

        public IEnumerable<Trakify_PaymentTerms> GetPaymentTerm()
        {
            return paymentTerm.GetAll();
        }

        public Trakify_PaymentTerms GetPaymentTerm(long id)
        {
            return paymentTerm.Get(id);
        }

        public void InsertPaymentTerm(Trakify_PaymentTerms job)
        {
            paymentTerm.Insert(job);
        }

        public void UpdatePaymentTerm(Trakify_PaymentTerms job)
        {
            paymentTerm.Update(job);
        }
    }
}
