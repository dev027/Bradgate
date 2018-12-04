using Bradgate.SeventyClub.Data;
using Bradgate.SeventyClub.Data.Dtos;
using Bradgate.SeventyClub.Domain;
using Bradgate.SeventyClub.Domain.Exceptions;
using Bradgate.SeventyClub.Interface;
using Bradgate.SeventyClub.Service.Utilities.Extensions.MapperExtensions;
using System;
using System.Collections.Generic;

namespace Bradgate.SeventyClub.Service
{
    public class SeventyClubService : ISeventyClubService
    {
        /// <summary>
        /// Create
        /// </summary>
        /// <param name="date"></param>
        /// <param name="player1"></param>
        /// <param name="isPlayer1Visitor"></param>
        /// <param name="player2"></param>
        /// <param name="isPlayer2Visitor"></param>
        /// <param name="score"></param>
        /// <param name="sessionDescription"></param>
        /// <returns>Id of created record</returns>
        /// <exception cref="SeventyClubServiceException"></exception>
        public long Create(
            DateTime date,
            string player1,
            bool isPlayer1Visitor,
            string player2,
            bool isPlayer2Visitor,
            decimal score,
            string sessionDescription)
        {
            try
            {
                using (var data = new SeventyClubData())
                {
                    var dto = new SeventyPercentClubEntryDto(
                        date: date,
                        player1: player1,
                        isPlayer1Visitor: isPlayer1Visitor,
                        player2: player2,
                        isPlayer2Visitor: isPlayer2Visitor,
                        score: score,
                        sessionDescription: sessionDescription);
                    data.Create(dto);

                    return dto.Id;
                }
            }
            catch (Exception ex)
            {
                var seventyClubServiceException = new SeventyClubServiceException(ex);
                throw seventyClubServiceException;
            }
        }

        /// <summary>
        /// GetClub
        /// </summary>
        /// <returns></returns>
        /// <exception cref="SeventyClubServiceException"></exception>
        public SeventyPercentClub GetClub()
        {
            try
            {
                using (var data = new SeventyClubData())
                {
                    var entries = data.GetClub();

                    var club = new SeventyPercentClub();

                    foreach (var entry in entries)
                    {
                        club.Entries.Add(entry.MapToDomain());
                    }

                    return club;
                }
            }
            catch (Exception ex)
            {
                var seventyClubServiceException = new SeventyClubServiceException(ex);
                throw seventyClubServiceException;
            }
        }

        /// <summary>
        /// Get the current holders of the Pam Leeson Trophy
        /// </summary>
        /// <returns>List of player names</returns>
        /// <exception cref="SeventyClubServiceException"></exception>
        public IList<string> GetPamLeesonTrophyHolders()
        {
            try
            {
                using (var data = new SeventyClubData())
                {
                    SeventyPercentClubEntryDto dto = data.GetPamLeesonTrophyHolders();

                    return new List<string>
                    {
                        dto.Player1,
                        dto.Player2
                    };
                }
            }
            catch (Exception ex)
            {
                var seventyClubServiceException = new SeventyClubServiceException(ex);
                throw seventyClubServiceException;
            }
        }
    }
}