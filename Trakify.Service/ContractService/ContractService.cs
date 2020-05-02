using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;
using Trakify.Repository.Common;
using Trakify.Repository.ContractRepo;

namespace Trakify.Service.ContractService
{
    public class ContractService : IContractService
    {
        private readonly IRepository<Trakify_Contracts> contractRepository;
        private readonly IContractRepository contract;
        private readonly IRepository<Trakify_ContractType> contractType;

        //private readonly IContractRepository _contractRepository;
        public ContractService(IRepository<Trakify_Contracts> contractRepository, IContractRepository contract, IRepository<Trakify_ContractType> contractType)
        {
            this.contractRepository = contractRepository;
            this.contract = contract;
            this.contractType = contractType;
        }

        public int DeleteContract(int id)
        {
            return contract.DeleteContract(id);
        }

        public IEnumerable<Trakify_Contracts> GetContract()
        {
            return contractRepository.GetAll();
        }

        public Trakify_Contracts GetContract(long id)
        {
            return contractRepository.Get(id);
        }

        public int InsertContract(Trakify_Contracts contract)
        {
            return contractRepository.Insert(contract);
        }


        public int UpdateContract(Trakify_Contracts contract)
        {
            return contractRepository.Update(contract);
        }
        public IEnumerable<Trakify_ContractType> GetContractType()
        {
            return contractType.GetAll();
        }
    }
}
