using KinoPolis.Data.Common.Repositories;
using KinoPolis.Data.Models;
using KinoPolis.Services.Mapping;
using KinoPolis.Web.ViewModels.Projections;
using System;
using System.Linq;

namespace KinoPolis.Services.Data
{
    public class ProjectionsService : IProjectionsService
    {
        private readonly IDeletableEntityRepository<Projection> projectionRepository;

        public ProjectionsService(IDeletableEntityRepository<Projection> projectionRepository)
        {
            this.projectionRepository = projectionRepository;
        }

        public ByIdViewModel GetProjectionById(int id)
        {
            var byIdViewModel = this.projectionRepository.All().To<ByIdViewModel>().FirstOrDefault(x => x.Id == id);
            return byIdViewModel;
        }
    }
}
