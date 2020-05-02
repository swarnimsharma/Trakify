using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;
using Trakify.Service.ContractService;

namespace Trakify.Facade.ContractsFacade
{
    public class ContractFacade : IContractFacade
    {
        private readonly IContractService contractservice;
        public ContractFacade(IContractService contractservice)
        {
            this.contractservice = contractservice;
        }

        public int DeleteContract(int id)
        {
            return contractservice.DeleteContract(id);
        }

        public IEnumerable<Trakify_Contracts> GetContract()
        {
            return contractservice.GetContract();
        }

        public Trakify_Contracts GetContract(long id)
        {
            return contractservice.GetContract(id);
        }

        public int InsertContract(Trakify_Contracts contract)
        {
            return contractservice.InsertContract(contract);
        }

        public int UpdateContract(Trakify_Contracts contract)
        {
            return contractservice.UpdateContract(contract);
        }

        public IEnumerable<Trakify_ContractType> GetContractType()
        {
            return contractservice.GetContractType();
        }
    }
}