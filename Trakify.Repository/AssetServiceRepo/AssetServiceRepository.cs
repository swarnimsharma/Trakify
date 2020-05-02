using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using Trakify.Domain;
using Trakify.Domain.Entities;
using Trakify.Repository.Common;

namespace Trakify.Repository.AssetServiceRepo
{
    public class AssetServiceRepository : IAssetServiceRepository
    {
        private readonly TrakifyContext context;
     
        public AssetServiceRepository(TrakifyContext context)
        {
            this.context = context;
        }

        public int InsertAssetService(Trakify_AssetsService assetservice)
        {
            var asset = context.Trakify_Assets.Find(assetservice.Trakify_AssetsServices.Id);
            assetservice.Trakify_AssetsServices = asset;
            context.Trakify_Services.Add(assetservice);
            return context.SaveChanges();
        }

        public int DeleteAssets(int id)
        {
            Trakify_Assets asset = context.Trakify_Assets.Find(id);
            asset.IsDeleted = true;
            return context.SaveChanges();
        }
    }
}
