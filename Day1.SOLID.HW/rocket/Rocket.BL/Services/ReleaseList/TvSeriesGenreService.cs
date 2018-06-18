using AutoMapper;
using Rocket.BL.Common.DtoModels.ReleaseList;
using Rocket.BL.Common.Services.ReleaseList;
using Rocket.DAL.Common.UoW;
using System.Collections.Generic;

namespace Rocket.BL.Services.ReleaseList
{
    public class TvSeriesGenreService : BaseService, ITvSeriesGenreService
    {
        public TvSeriesGenreService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<TvSeriesGenreDto> GetTvSeriesGenres()
        {
            return Mapper.Map<IEnumerable<TvSeriesGenreDto>>(_unitOfWork.GenreRepository.Get());
        }
    }
}
