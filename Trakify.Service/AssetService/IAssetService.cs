using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;

namespace Trakify.Service.AssetService
{
    public interface IAssetService
    {
        IEnumerable<Trakify_Assets> GetAssets();
        Trakify_Assets GetAsset(long id);
        int InsertAsset(Trakify_Assets user);
        int InsertAssetService(Trakify_AssetsService service);
        int UpdateAsset(Trakify_Assets user);
        int DeleteAsset(Trakify_Assets trakify_Assets);
        List<Trakify_AssetsService> GetAssetServices(int id);
    }
}
