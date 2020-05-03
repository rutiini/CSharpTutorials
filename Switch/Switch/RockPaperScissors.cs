using System;

namespace Switch
{
  /// A simple game to display the usage of switch expressions.
  public static class RockPaperScissors
  {
    public static void Main(string[] args)
    {
        // Placeholder...
    }

    /// A simple 2 player game.
    public static string PlayWith2Players(RPS player1, RPS player2)
    {
      var winner = (player1, player2) switch
      {
        // Player 1 win scenarios.
        (RPS.Paper, RPS.Rock) => "Player 1",
        (RPS.Scissors, RPS.Paper) => "Player 1",
        (RPS.Rock, RPS.Scissors) => "Player 1",

        // Draw cases.
        (_, _) when player1 == player2 => "Draw",

        // Someone brings a shotgun to rock paper scissors?
        (_, _) when player1 == RPS.Shotgun | player2 == RPS.Shotgun => throw new Exception("WTF!"),

        // Player 2 win scenarios!
        (_, _) => "Player 2"
      };

      var output = winner + $" ({nameof(winner)})";
      System.Console.WriteLine(output);
      return output;
    }

    /// 3rd player adds some complexity :)
    public static string PlayWith3Players(RPS player1, RPS player2, RPS player3)
    {
      var winner = (player1, player2, player3) switch
      {


        // Draw cases (any combination of the three basic options), shotgun cases are handled by this.
        (_, _, _) => "Draw",
      };

      var output = winner + $" ({nameof(winner)})";
      System.Console.WriteLine(output);
      return output;
    }

  }
}