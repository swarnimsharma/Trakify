using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;

namespace Trakify.Repository.AssetRepo
{
    public interface IAssetRepository
    {
        int DeleteAssets(int id);
        List<Trakify_AssetsService> GetAssetServices(int id);
    }
}
