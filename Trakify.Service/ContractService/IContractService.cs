using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;

namespace Trakify.Service.ContractService
{
   public  interface IContractService
    {
        IEnumerable<Trakify_Contracts> GetContract();
        Trakify_Contracts GetContract(long id);
        int InsertContract(Trakify_Contracts contract);
        int UpdateContract(Trakify_Contracts contract);
        int DeleteContract(int id);

        IEnumerable<Trakify_ContractType> GetContractType();

        //int InsertContractType(Trakify_ContractType contract);
    }
}
