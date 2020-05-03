using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Switch.Tests
{
    [TestClass]
    public class RockPaperScissors2PlayersTests
    {
        [DataTestMethod]
        [DataRow(RPS.Paper, RPS.Rock, "Player 1")]
        [DataRow(RPS.Rock, RPS.Paper, "Player 2")]
        public void PaperShouldWinRock(RPS player1, RPS player2, string winner)
        {
            // Arrange -> See data rows.

            // Act
            var result = RockPaperScissors.PlayWith2Players(player1, player2);

            // Assert
            Assert.IsTrue(result.Contains(winner));
        }

        [DataTestMethod]
        [DataRow(RPS.Rock, RPS.Scissors, "Player 1")]
        [DataRow(RPS.Scissors, RPS.Rock, "Player 2")]
        public void RockShouldWinScissors(RPS player1, RPS player2, string winner)
        {
            // Arrange -> See data rows.

            // Act
            var result = RockPaperScissors.PlayWith2Players(player1, player2);

            // Assert
            Assert.IsTrue(result.Contains(winner));
        }

        [DataTestMethod]
        [DataRow(RPS.Scissors, RPS.Paper, "Player 1")]
        [DataRow(RPS.Paper, RPS.Scissors, "Player 2")]
        public void ScissorsShouldWinPaper(RPS player1, RPS player2, string winner)
        {
            // Arrange -> See data rows.

            // Act
            var result = RockPaperScissors.PlayWith2Players(player1, player2);

            // Assert
            Assert.IsTrue(result.Contains(winner));
        }

        [DataTestMethod]
        [DataRow(RPS.Rock)]
        [DataRow(RPS.Paper)]
        [DataRow(RPS.Scissors)]
        [DataRow(RPS.Shotgun)]
        public void SameShouldDraw(RPS choise)
        {
            // Arrange -> See data rows.

            // Act
            var result = RockPaperScissors.PlayWith2Players(choise, choise);

            // Assert
            Assert.IsTrue(result.Contains("Draw"));
        }

        [DataTestMethod]
        [DataRow(RPS.Shotgun, RPS.Rock)]
        [DataRow(RPS.Shotgun, RPS.Paper)]
        [DataRow(RPS.Shotgun, RPS.Scissors)]
        [DataRow(RPS.Rock, RPS.Shotgun)]
        [DataRow(RPS.Paper, RPS.Shotgun)]
        [DataRow(RPS.Scissors, RPS.Shotgun)]
        [ExpectedException(typeof(Exception), "WTF!")]

        public void ShotgunShouldThrow(RPS player1, RPS player2)
        {
            // Arrange -> see data rows.

            // Act
            var result = RockPaperScissors.PlayWith2Players(player1, player2);

            // Assert -> unhappy path testing :(
            Assert.Fail();
        }
    }
}
