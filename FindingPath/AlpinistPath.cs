using System.Collections.Generic;
using System.Linq;
using System;
public static class Alpinist
{
    public static int PathFinder(string maze)
    {
        int GetHeight(char source)
        {
            return source - 48;
        }

        int GetDiff(char source, char height)
        {
            return Math.Abs(source - height);
        }

        var map = maze.Split("\n");
        var length = map.Length;
        var arr = new int[length][];
        for (int i = 0; i < length; i++)
        {
            arr[i] = new int[length];
            for (int j = 0; j < length; j++)
            {
                arr[i][j] = -1;
            }
        }
        void Spoil(int i, int j, int diff)
        {
            arr[i][j] = diff;
            //i, j+
            if ((j < length - 1) && (arr[i][j + 1] == -1 || arr[i][j + 1] - diff > GetDiff(map[i][j + 1], map[i][j])))
            {
                Spoil(i, j + 1, GetDiff(map[i][j + 1], map[i][j]) + diff);
            }
            //i, j-
            if (j > 0 && (arr[i][j - 1] == -1 || arr[i][j - 1] - diff > GetDiff(map[i][j - 1], map[i][j])))
            {
                Spoil(i, j - 1, GetDiff(map[i][j - 1], map[i][j]) + diff);
            }
            //i+, j
            if ((i < length - 1) && (arr[i + 1][j] == -1 || arr[i + 1][j] - diff > GetDiff(map[i + 1][j], map[i][j])))
            {
                Spoil(i + 1, j, GetDiff(map[i + 1][j], map[i][j]) + diff);
            }
            //i-, j
            if (i > 0 && (arr[i - 1][j] == -1 || arr[i - 1][j] - diff > GetDiff(map[i - 1][j], map[i][j])))
            {
                Spoil(i - 1, j, GetDiff(map[i - 1][j], map[i][j]) + diff);
            }
        }
        Spoil(0, 0, GetHeight(map[0][0]));
        return arr[length - 1][length - 1] - arr[0][0];
    }

   private static void PrintMaze(int[][] arr)
    {
        foreach (var item in arr)
        {
            foreach (var dot in item)
            {
                System.Console.Write($" {dot:D2} ");
            }
            System.Console.WriteLine();
        }
    }
}
