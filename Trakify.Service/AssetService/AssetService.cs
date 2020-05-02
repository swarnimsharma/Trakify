using System.Collections.Generic;
using Trakify.Domain.Entities;
using Trakify.Repository.AssetRepo;
using Trakify.Repository.AssetServiceRepo;
using Trakify.Repository.Common;

namespace Trakify.Service.AssetService
{
    public class AssetService : IAssetService
    {

        private readonly IRepository<Trakify_Assets> assetRepository;
        private readonly IRepository<Trakify_AssetsService> serviceRepository;
        private readonly IAssetRepository asset;

        public AssetService(IRepository<Trakify_Assets> assetRepository , IAssetRepository asset, IRepository<Trakify_AssetsService> serviceRepository)
        {
            this.assetRepository = assetRepository;
            this.serviceRepository = serviceRepository;
            this.asset = asset;
        }

        public int DeleteAsset(Trakify_Assets trakify_Assets)
        {
            return assetRepository.Delete(trakify_Assets);
        }

        public Trakify_Assets GetAsset(long id)
        {
            return assetRepository.Get(id);
        }

        public IEnumerable<Trakify_Assets> GetAssets()
        {
            return assetRepository.GetAll();
        }


        public int InsertAsset(Trakify_Assets user)
        {
          return  assetRepository.Insert(user);
        }

        public int InsertAssetService(Trakify_AssetsService service)
        {
            var assetservicerepository = new AssetServiceRepository(new Domain.TrakifyContext());
            return assetservicerepository.InsertAssetService(service);
        }

        public int UpdateAsset(Trakify_Assets user)
        {
           return assetRepository.Update(user);
        }
        public List<Trakify_AssetsService> GetAssetServices(int id)
        {
            return asset.GetAssetServices(id);
        }
    }
}
