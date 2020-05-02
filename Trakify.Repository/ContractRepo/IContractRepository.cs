using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;

namespace Trakify.Repository.ContractRepo
{
   public  interface IContractRepository
    {
        int InsertContractType(Trakify_ContractType contractType);
        int DeleteContract(int id);
    }
}
