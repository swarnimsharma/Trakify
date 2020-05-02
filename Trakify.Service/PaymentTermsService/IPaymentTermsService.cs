using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;

namespace Trakify.Service.PaymentTermsService
{
   public interface IPaymentTermsService
    {
        IEnumerable<Trakify_PaymentTerms> GetPaymentTerm();
        Trakify_PaymentTerms GetPaymentTerm(long id);
        void InsertPaymentTerm(Trakify_PaymentTerms PaymentTerm);
        void UpdatePaymentTerm(Trakify_PaymentTerms PaymentTerm);
        void DeletePaymentTerm(long id);
    }
}
