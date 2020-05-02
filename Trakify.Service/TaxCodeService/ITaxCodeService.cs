using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;

namespace Trakify.Service.TexCodeService
{
  public  interface ITaxCodeService
    {
        IEnumerable<Trakify_TaxCode> GetTaxCode();
        Trakify_TaxCode GetTaxCode(long id);
        void InsertTaxCode(Trakify_TaxCode TaxCode);
        void UpdateTaxCode(Trakify_TaxCode TaxCode);
        void DeleteTaxCode(long id);
    }
}
