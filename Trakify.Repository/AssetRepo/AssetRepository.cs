using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Trakify.Domain;
using Trakify.Domain.Entities;
using Trakify.Repository.Common;

namespace Trakify.Repository.AssetRepo
{
    public class AssetRepository : IAssetRepository
    {
        private readonly TrakifyContext context;
     
        public AssetRepository(TrakifyContext context)
        {
            this.context = context;
        }

        public int DeleteAssets(int id)
        {
            Trakify_Assets asset = context.Trakify_Assets.Find(id);
            asset.IsDeleted = true;
            return context.SaveChanges();
        }

        public List<Trakify_AssetsService> GetAssetServices(int id)
        {
            //int a = 2;
            //context.Trakify_Services.Find(x=>x.)
            return context.Trakify_Services.Where(x => x.Trakify_AssetsServices.Id == id).ToList();
        }
    }
}
