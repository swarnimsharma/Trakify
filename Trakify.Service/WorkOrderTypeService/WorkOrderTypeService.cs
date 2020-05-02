using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;
using Trakify.Repository.Common;
namespace Trakify.Service.WorkOrderTypeService
{
    public class WorkOrderTypeService : IWorkOrderTypeService
    {
        private readonly IRepository<Trakify_WorkOrderType> _workorderType;
        public WorkOrderTypeService(IRepository<Trakify_WorkOrderType> _workorderType)
        {
            this._workorderType = _workorderType;
        }
        public void DeleteWorkOrderType(long id)
        {
            Trakify_WorkOrderType userProfile = _workorderType.Get(id);
            _workorderType.Remove(userProfile);
            _workorderType.SaveChanges();
        }

        public IEnumerable<Trakify_WorkOrderType> GetWorkOrderType()
        {
            return _workorderType.GetAll();
        }

        public Trakify_WorkOrderType GetWorkOrderType(long id)
        {
            return _workorderType.Get(id);
        }

        public void InsertWorkOrderType(Trakify_WorkOrderType workorderType)
        {
            _workorderType.Insert(workorderType);
        }

        public void UpdateWorkOrderType(Trakify_WorkOrderType workorderType)
        {
            _workorderType.Update(workorderType);
        }
    }
}
