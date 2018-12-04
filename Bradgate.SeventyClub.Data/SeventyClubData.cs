using Bradgate.SeventyClub.Data.DbContexts;
using Bradgate.SeventyClub.Data.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bradgate.SeventyClub.Data
{
    public class SeventyClubData : IDisposable
    {
        private readonly SeventyClubContext _context;

        public SeventyClubData()
        {
            _context = new SeventyClubContext();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="dto">70% Club Entry</param>
        /// <exception cref="DbUpdateException"></exception>
        /// <exception cref="DbUpdateConcurrencyException"></exception>
        public void Create(SeventyPercentClubEntryDto dto)
        {
            _context.SeventyPercentClubEntries.Add(dto);
            _context.SaveChanges();
        }

        /// <summary>
        /// Get all 70% Club Entries in reverse chronological order
        /// </summary>
        /// <returns>List of 70% Club Entries</returns>
        public IList<SeventyPercentClubEntryDto> GetClub()
        {
            return _context.SeventyPercentClubEntries
                .OrderBy(x => x.Date)
                .ToList();
        }

        /// <summary>
        /// Get the current holders of the Pam Leeson Trophy
        /// </summary>
        /// <returns>70% Club Entry</returns>
        /// <exception cref="InvalidOperationException"></exception>
        public SeventyPercentClubEntryDto GetPamLeesonTrophyHolders()
        {
            return _context.SeventyPercentClubEntries
                .Where(x => !x.IsPlayer1Visitor)
                .Where(x => !x.IsPlayer2Visitor)
                .OrderByDescending(x => x.Date)
                .First();
        }
    }
}