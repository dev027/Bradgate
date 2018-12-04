using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bradgate.SeventyClub.Interface;
using Bradgate.SeventyClub.Service;

namespace Bradgate.Seed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSeed70Club.Click += BtnSeed70Club_Click;
        }

        /// <summary>
        /// BtnSeed70Club_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="PathTooLongException"></exception>
        /// <exception cref="DirectoryNotFoundException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="System.Security.SecurityException"></exception>
        /// <exception cref="Bradgate.SeventyClub.Domain.Exceptions.SeventyClubServiceException"></exception>
        private void BtnSeed70Club_Click(object sender, EventArgs e)
        {
            Seed70Club();
        }

        /// <summary>
        /// Seed70Club
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="PathTooLongException"></exception>
        /// <exception cref="DirectoryNotFoundException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="System.Security.SecurityException"></exception>
        /// <exception cref="Bradgate.SeventyClub.Domain.Exceptions.SeventyClubServiceException"></exception>
        private void Seed70Club()
        {
            ISeventyClubService service = new SeventyClubService();
            var seventyClub = service.GetClub();

            if (seventyClub.Entries.Any())
            {
                MessageBox.Show(
                    text: @"70% Club is already populated",
                    caption: @"Seed 70% Club",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Stop);
                return;
            }

            const string path = "C:\\Users\\Steve\\Documents\\Visual Studio 2017\\Projects\\Bradgate\\Bradgate.Seed\\Data\\SeventyClub.txt";

            var entryLines = File.ReadAllLines(path);

            foreach (var entryLine in entryLines)
            {
                var entryParts = entryLine.Split(',');

                Console.WriteLine(entryLine);

                var date = DateTime.Parse(entryParts[0]);

                string player1;
                bool isPlayer1Visitor;
                (player1, isPlayer1Visitor) = ParsePlayer(entryParts[1]);

                string player2;
                bool isPlayer2Visitor;
                (player2, isPlayer2Visitor) = ParsePlayer(entryParts[2]);

                var score = decimal.Parse(entryParts[3]);

                var sessionDescription = entryParts[4];

                service.Create(
                    date: date,
                    player1: player1,
                    isPlayer1Visitor: isPlayer1Visitor,
                    player2: player2,
                    isPlayer2Visitor: isPlayer2Visitor,
                    score: score, sessionDescription: sessionDescription);
            }

            MessageBox.Show(
                text: @"70% Club populated",
                caption: @"Seed 70% Club",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Information);
        }

        private static (string playerName, bool isVisitor) ParsePlayer(string entryPart) => entryPart.StartsWith("#")
                ? (entryPart.Replace("#", string.Empty), true)
                : (entryPart, false);
    }
}
