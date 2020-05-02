using System;
using Trakify.Domain;
using Trakify.Domain.Entities;

namespace Trakify.Repository.ContractRepo
{
    public class ContractRepository : IContractRepository
    {
        private readonly TrakifyContext context;

        public ContractRepository(TrakifyContext context)
        {
            this.context = context;
        }
        public int InsertContractType(Trakify_ContractType contractType)
        {
            if (contractType == null)
            {
                throw new ArgumentNullException("Contract Type");
            }
            context.Add(contractType);
            return context.SaveChanges();
        }
        public int DeleteContract(int id)
        {
            Trakify_Contracts contract = context.Trakify_Contracts.Find(id);
            contract.IsDeleted = true;
            return context.SaveChanges();
        }

    }
}
