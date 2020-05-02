using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;
using Trakify.Repository.Common;

namespace Trakify.Service.TexCodeService
{
 
   public class TaxCodeService : ITaxCodeService
    {
        private readonly IRepository<Trakify_TaxCode> taxCode;
        public TaxCodeService(IRepository<Trakify_TaxCode> taxCode)
        {
            this.taxCode = taxCode;
        }

        public void DeleteTaxCode(long id)
        {
            Trakify_TaxCode userProfile = taxCode.Get(id);
            taxCode.Remove(userProfile);
            taxCode.SaveChanges();
        }

        public IEnumerable<Trakify_TaxCode> GetTaxCode()
        {
            return taxCode.GetAll();
        }

        public Trakify_TaxCode GetTaxCode(long id)
        {
            return taxCode.Get(id);
        }

        public void InsertTaxCode(Trakify_TaxCode TaxCode)
        {
            taxCode.Insert(TaxCode);
        }

        public void UpdateTaxCode(Trakify_TaxCode TaxCode)
        {
            taxCode.Update(TaxCode);
        }
    }
}
