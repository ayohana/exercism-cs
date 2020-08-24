using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    public List<int> allScores;
    public HighScores(List<int> list) => allScores = list;

    public List<int> Scores() => allScores;

    public int Latest() => allScores.Last();

    public int PersonalBest() => allScores.Max();

    public List<int> PersonalTopThree()
    {
        List<int> sortedList = this.Scores();
        sortedList.Sort((int a, int b) => b-a);
        return sortedList.Take(3).ToList();
    }
}