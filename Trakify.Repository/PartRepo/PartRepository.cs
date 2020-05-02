using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain;
using Trakify.Domain.Entities;

namespace Trakify.Repository.PartRepo
{
    public class PartRepository : IPartRepository
    {
        private readonly TrakifyContext context;

        public PartRepository(TrakifyContext context)
        {
            this.context = context;
        }
        public void InsertPartCategory(Trakify_PartCategory PartCategory)
        {
            if (PartCategory == null)
            {
                throw new ArgumentNullException("Contract Type");
            }
            context.Trakify_PartCategory.Add(PartCategory);
            context.SaveChanges();
        }

        

        //public void InsertPartCategoryName(Trakify_PartCategory PartCategory)
        //{
        //    if (PartCategory == null)
        //    {
        //        throw new ArgumentNullException("Contract Type");
        //    }
        //    context.Add(PartCategory);
        //    context.SaveChanges();
        //}
    }
}
