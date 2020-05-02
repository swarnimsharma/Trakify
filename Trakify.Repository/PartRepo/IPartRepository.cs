using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;

namespace Trakify.Repository.PartRepo
{
    public interface IPartRepository
    {
        void InsertPartCategory(Trakify_PartCategory PartCategory);
        //void InsertPartCategoryName(Trakify_PartCategory PartCategory);
    }
}
