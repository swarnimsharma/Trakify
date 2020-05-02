using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;

namespace Trakify.Facade.AssetsFacade
{
  public  interface IAssetsFacade
    {
        IEnumerable<Trakify_Assets> GetAssets();
        Trakify_Assets GetAsset(long id);
        int InsertAsset(Trakify_Assets asset);
        int InsertAssetService(Trakify_AssetsService service);
        int UpdateAsset(Trakify_Assets asset);
        int DeleteAsset(Trakify_Assets trakify_Assets);
        List<Trakify_AssetsService> GetAssetServices(int id);
    }
}
