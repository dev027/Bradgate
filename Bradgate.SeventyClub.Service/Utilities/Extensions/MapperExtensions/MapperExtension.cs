using AutoMapper;
using Bradgate.SeventyClub.Data.Dtos;
using Bradgate.SeventyClub.Domain;
using System.Collections.Generic;

namespace Bradgate.SeventyClub.Service.Utilities.Extensions.MapperExtensions
{
    public static class Extensions
    {
        private static IMapper _mapper;

        #region SeventyPercentClub

        public static SeventyPercentClubEntry MapToDomain(this SeventyPercentClubEntryDto dto) => ServiceMapper.Map<SeventyPercentClubEntry>(dto);

        public static SeventyPercentClubEntryDto MapToDto(this SeventyPercentClubEntry domain) => ServiceMapper.Map<SeventyPercentClubEntryDto>(domain);

        public static List<SeventyPercentClubEntry> MapToDomain(this IList<SeventyPercentClubEntryDto> dtos) => ServiceMapper.Map<List<SeventyPercentClubEntry>>(dtos);

        public static List<SeventyPercentClubEntryDto> MapToDto(this IList<SeventyPercentClubEntry> domains) => ServiceMapper.Map<List<SeventyPercentClubEntryDto>>(domains);

        #endregion SeventyPercentClub

        #region Mapper Configuration

        private static IMapper ServiceMapper => _mapper ?? (_mapper = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<SeventyPercentClubEntryDto, SeventyPercentClubEntry>().ReverseMap();
        }).CreateMapper());

        #endregion Mapper Configuration
    }
}