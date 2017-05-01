using RaysHotDogs.Core.Models;
using RaysHotDogs.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaysHotDogs.Core.Services
{
    public class HotDogDataService
    {
        private readonly HotDogRepository _hotDogRepository;

        public HotDogDataService(HotDogRepository hotDogRepository)
        {
            _hotDogRepository = hotDogRepository;
        }

        public List<HotDog> GetAllHotDogs()
        {
            return _hotDogRepository.GetAllHotDogs();
        }

        public List<HotDogGroup> GetGroupedHotDogs()
        {
            return _hotDogRepository.GetGroupedHotDogs();
        }

        public List<HotDog> GetHotDogForGroup(int hotDogGroupId)
        {
            return _hotDogRepository.GetHotDogsForGroup(hotDogGroupId);
        }

        public List<HotDog> GetFavoriteHotDogs()
        {
            return _hotDogRepository.GetFavoriteHotDogs();
        }

        public HotDog GetHOtDogById(int hotDogId)
        {
            return _hotDogRepository.GetHotDogById(hotDogId);
        }
    }
}
