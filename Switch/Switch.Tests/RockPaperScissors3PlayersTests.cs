using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Switch.Tests
{
    [TestClass]
    public class RockPaperScissors3PlayersTests
    {
        [DataTestMethod]
        [DataRow(RPS.Paper, RPS.Rock, RPS.Rock, "Player 1")]
        [DataRow(RPS.Rock, RPS.Paper, RPS.Rock, "Player 2")]
        [DataRow(RPS.Rock, RPS.Rock, RPS.Paper, "Player 3")]
        public void PaperShouldWinRock(RPS player1, RPS player2, RPS player3, string winner)
        {
            // Arrange -> See data rows.

            // Act
            var result = RockPaperScissors.PlayWith3Players(player1, player2, player3);

            // Assert
            Assert.IsTrue(result.Contains(winner));
        }

        [DataTestMethod]
        [DataRow(RPS.Rock, RPS.Scissors, RPS.Scissors, "Player 1")]
        [DataRow(RPS.Scissors, RPS.Rock, RPS.Scissors, "Player 2")]
        [DataRow(RPS.Scissors, RPS.Scissors, RPS.Rock, "Player 3")]
        public void RockShouldWinScissors(RPS player1, RPS player2, RPS player3, string winner)
        {
            // Arrange -> See data rows.

            // Act
            var result = RockPaperScissors.PlayWith3Players(player1, player2, player3);

            // Assert
            Assert.IsTrue(result.Contains(winner));
        }

        [DataTestMethod]
        [DataRow(RPS.Scissors, RPS.Paper, RPS.Paper, "Player 1")]
        [DataRow(RPS.Paper, RPS.Scissors, RPS.Paper, "Player 2")]
        [DataRow(RPS.Paper, RPS.Paper, RPS.Scissors, "Player 3")]
        public void ScissorsShouldWinPaper(RPS player1, RPS player2, RPS player3, string winner)
        {
            // Arrange -> See data rows.

            // Act
            var result = RockPaperScissors.PlayWith3Players(player1, player2, player3);

            // Assert
            Assert.IsTrue(result.Contains(winner));
        }

        [DataTestMethod]
        [DataRow(RPS.Rock, RPS.Rock, RPS.Rock)]
        [DataRow(RPS.Rock, RPS.Rock, RPS.Scissors)]
        [DataRow(RPS.Paper, RPS.Paper, RPS.Paper)]
        [DataRow(RPS.Paper, RPS.Paper, RPS.Rock)]
        [DataRow(RPS.Scissors, RPS.Scissors, RPS.Scissors)]
        [DataRow(RPS.Scissors, RPS.Scissors, RPS.Paper)]
        [DataRow(RPS.Shotgun, RPS.Shotgun, RPS.Shotgun)]
        [DataRow(RPS.Shotgun, RPS.Shotgun, RPS.Rock)]
        [DataRow(RPS.Shotgun, RPS.Shotgun, RPS.Paper)]
        [DataRow(RPS.Shotgun, RPS.Shotgun, RPS.Scissors)]
        public void TwoOrMoreSameShouldDraw(RPS player1, RPS player2, RPS player3)
        {
            // Arrange -> See data rows.

            // Act
            var result = RockPaperScissors.PlayWith3Players(player1, player2, player3);

            // Assert
            Assert.IsTrue(result.Contains("Draw"));
        }

        [TestMethod]
        [DataRow(RPS.Rock, RPS.Paper, RPS.Scissors)]
        [DataRow(RPS.Rock, RPS.Scissors, RPS.Paper)]
        [DataRow(RPS.Paper, RPS.Scissors, RPS.Rock)]
        [DataRow(RPS.Paper, RPS.Rock, RPS.Scissors)]
        [DataRow(RPS.Scissors, RPS.Rock, RPS.Paper)]
        [DataRow(RPS.Scissors, RPS.Paper, RPS.Rock)]
        public void RockPaperScissorsShouldDraw(RPS player1, RPS player2, RPS player3)
        {
            // Arrange-> See data rows

            // Act
            var result = RockPaperScissors.PlayWith3Players(player1, player2, player3);

            // Assert
            Assert.IsTrue(result.Contains("Draw"));
        }

        [DataTestMethod]
        [DataRow(RPS.Shotgun, RPS.Rock, RPS.Scissors)]
        [DataRow(RPS.Shotgun, RPS.Paper, RPS.Scissors)]
        [DataRow(RPS.Rock, RPS.Shotgun, RPS.Paper)]
        [DataRow(RPS.Scissors, RPS.Shotgun, RPS.Paper)]
        [DataRow(RPS.Paper, RPS.Rock, RPS.Shotgun)]
        [DataRow(RPS.Scissors, RPS.Rock, RPS.Shotgun)]
        [ExpectedException(typeof(Exception), "WTF!")]

        public void OneShotgunShouldThrow(RPS player1, RPS player2, RPS player3)
        {
            // Arrange -> see data rows.

            // Act
            var result = RockPaperScissors.PlayWith3Players(player1, player2, player3);

            // Assert -> unhappy path testing :(
            Assert.Fail();
        }
    }
}