namespace aoc_2023.Days;
public class Day2
{
    private static readonly int StartingRed = 12;
    private static readonly int StartingGreen = 13;
    private static readonly int StartingBlue = 14;

    public static bool IsGamePossible(int numRed, int numGreen, int numBlue, List<List<KeyValuePair<string, int>>> gameSequence)
    {
        var isPossible = true;
        foreach (var game in gameSequence)
        {
            foreach (var cube in game)
            {
                switch (cube.Key)
                {
                    case "red":
                        if (cube.Value > numRed)
                            isPossible = false;
                        break;
                    case "green":
                        if (cube.Value > numGreen)
                            isPossible = false;
                        break;
                    case "blue":
                        if (cube.Value > numBlue)
                            isPossible = false;
                        break;
                }
            }
        }

        return isPossible;
    }

    public static int SumPossibleGameIDs(Dictionary<int, List<List<KeyValuePair<string, int>>>> games)
    {
        var total = 0;
        var debug = new List<int>();
        foreach (var game in games)
        {
            if (IsGamePossible(StartingRed, StartingGreen, StartingBlue, game.Value))
            {
                total += game.Key;
                debug.Add(game.Key);
            }
        }

        return total;
    }

    public static KeyValuePair<int, List<List<KeyValuePair<string, int>>>> ParseGameFromString(string inputString)
    {
        var gameId = int.Parse(inputString.Split(':')[0].Trim().Split(' ')[1]);
        var gameStringList = inputString.Split(':')[1].Split(';');
        var gameList = new List<List<KeyValuePair<string, int>>>();
        foreach (var gameString in gameStringList)
        {
            var bag = new List<KeyValuePair<string, int>>();
            foreach (var cube in gameString.Split(','))
            {
                var cubeEntry = new KeyValuePair<string, int>(cube.Trim().Split(' ')[1], int.Parse(cube.Trim().Split(' ')[0]));
                bag.Add(cubeEntry);
            }

            gameList.Add(bag);
        }

        return new KeyValuePair<int, List<List<KeyValuePair<string, int>>>>(gameId, gameList);
    }

    public static Dictionary<int, List<List<KeyValuePair<string, int>>>> ReadGameInput(string[] lines)
    {
        var gameInput = new Dictionary<int, List<List<KeyValuePair<string, int>>>>();
        foreach (var line in lines)
        {
            var game = ParseGameFromString(line);
            gameInput.Add(game.Key, game.Value);
        }

        return gameInput;
    }
}