using Rocket.BL.Common.DtoModels.ReleaseList;
using System;
using System.Collections.Generic;

namespace Rocket.BL.Common.Services.ReleaseList
{
    public interface IMusicGenreService : IDisposable
    {
        IEnumerable<MusicGenreDto> GetMusicGenres();
    }
}
