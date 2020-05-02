using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;

namespace Trakify.Repository.AssetServiceRepo
{
    public interface IAssetServiceRepository
    {
        int DeleteAssets(int id);
    }
}
