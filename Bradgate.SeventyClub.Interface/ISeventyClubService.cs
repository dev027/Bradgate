using System;
using Bradgate.SeventyClub.Domain;
using Bradgate.SeventyClub.Domain.Exceptions;

namespace Bradgate.SeventyClub.Interface
{
    public interface ISeventyClubService
    {
        /// <summary>
        /// Create entry in 70% Club
        /// </summary>
        /// <param name="date">Date</param>
        /// <param name="player1">Player 1 Name</param>
        /// <param name="isPlayer1Visitor">True if Player 1 is a visitor</param>
        /// <param name="player2">Player 2 Name</param>
        /// <param name="isPlayer2Visitor">True if Player 2 is a visitor</param>
        /// <param name="score">Score (Percentage)</param>
        /// <param name="sessionDescription">Session Description</param>
        /// <returns>Id of created record</returns>
        /// <exception cref="SeventyClubServiceException"></exception>
        long Create(
            DateTime date,
            string player1,
            bool isPlayer1Visitor,
            string player2,
            bool isPlayer2Visitor,
            decimal score,
            string sessionDescription);

        /// <summary>
        /// Get all entries for the 70% Club
        /// </summary>
        /// <returns>70% Club Entry Collection</returns>
        /// <exception cref="SeventyClubServiceException"></exception>
        SeventyPercentClub GetClub();

        /// <summary>
        /// Get the current holders of the Pam Leeson Trophy
        /// </summary>
        /// <returns>70% Club Entry of Holders</returns>
        /// <exception cref="SeventyClubServiceException"></exception>
        SeventyPercentClubEntry GetPamLeesonTrophyHolders();
    }
}