using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;
using Trakify.Service.AssetService;

namespace Trakify.Facade.AssetsFacade
{
    public class AssetsFacade : IAssetsFacade
    {
        private readonly IAssetService assetService;
        public AssetsFacade(IAssetService assetService)
        {
            this.assetService = assetService;
        }
        public int DeleteAsset(Trakify_Assets trakify_Assets)
        {
            return assetService.DeleteAsset(trakify_Assets);
        }

        public Trakify_Assets GetAsset(long id)
        {
            return assetService.GetAsset(id);
        }

        public IEnumerable<Trakify_Assets> GetAssets()
        {
            return assetService.GetAssets();
        }

        public int InsertAsset(Trakify_Assets asset)
        {
           return assetService.InsertAsset(asset);
        }

        public int InsertAssetService(Trakify_AssetsService service)
        {
            return assetService.InsertAssetService(service);
        }

        public int UpdateAsset(Trakify_Assets asset)
        {
           return assetService.UpdateAsset(asset);
        }
        public List<Trakify_AssetsService> GetAssetServices(int id)
        {
            return assetService.GetAssetServices(id);
        }
    }
}
