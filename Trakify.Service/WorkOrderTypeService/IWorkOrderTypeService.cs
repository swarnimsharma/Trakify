using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;

namespace Trakify.Service.WorkOrderTypeService
{
   public  interface IWorkOrderTypeService
    {
        IEnumerable<Trakify_WorkOrderType> GetWorkOrderType();
        Trakify_WorkOrderType GetWorkOrderType(long id);
        void InsertWorkOrderType(Trakify_WorkOrderType workorderType);
        void UpdateWorkOrderType(Trakify_WorkOrderType workorderType);
        void DeleteWorkOrderType(long id);
    }
}
