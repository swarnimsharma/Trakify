using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;
using Trakify.Repository.Common;

namespace Trakify.Service.CodeService
{
    public class CodeService : ICodeService
    {
        private readonly IRepository<Trakify_Code> _Code;
        public CodeService(IRepository<Trakify_Code> _Code)
        {
            this._Code = _Code;
        }

        public void DeleteCode(long id)
        {
            Trakify_Code userProfile = _Code.Get(id);
            _Code.Remove(userProfile);
            _Code.SaveChanges();
        }

        public IEnumerable<Trakify_Code> GetCode()
        {
            return _Code.GetAll();
        }

        public Trakify_Code GetCode(long id)
        {
            return _Code.Get(id);
        }

        public void InsertCode(Trakify_Code code)
        {
            _Code.Insert(code);
        }

        public void UpdateCode(Trakify_Code code)
        {
            _Code.Update(code);
        }
    }
}
