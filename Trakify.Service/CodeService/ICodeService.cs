using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;

namespace Trakify.Service.CodeService
{
   public  interface ICodeService
    {
        IEnumerable<Trakify_Code> GetCode();
        Trakify_Code GetCode(long id);
        void InsertCode(Trakify_Code code);
        void UpdateCode(Trakify_Code code);
        void DeleteCode(long id);
    }
}
