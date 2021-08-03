using System.Collections.Generic;
using System.Linq;
using System;
public class Finder
{
    public static int PathFinder(string maze)
    {
        var map = maze.Split("\n");
        var length = map.Length;
        var arr = new int[length][];
        for (int i = 0; i < length; i++)
        {
            arr[i] = new int[length];
            for(int j = 0; j < length; j++) {
                arr[i][j] = -1;
            }
        }
        void Spoil(int i, int j, int step)
        {
            arr[i][j] = step;
            //i, j+
            if ((j < length - 1) && (arr[i][j + 1] == -1 || arr[i][j + 1] > step + 1) && map[i][j + 1] == '.')
            {
                Spoil(i, j + 1, step + 1);
            }
            //i, j-
            if (j > 0 && (arr[i][j - 1] == -1 || arr[i][j - 1] > step + 1) && map[i][j - 1] == '.')
            {
                Spoil(i, j - 1, step + 1);
            }
            //i+, j
            if ((i < length - 1) && (arr[i + 1][j] == -1 || arr[i + 1][j] > step + 1) && map[i + 1][j] == '.')
            {
                Spoil(i + 1, j, step + 1);
            }
            //i-, j
            if (i > 0 && (arr[i - 1][j] == -1 || arr[i - 1][j] > step + 1) && map[i - 1][j] == '.')
            {
                Spoil(i - 1, j, step + 1);
            }
        }
        Spoil(0, 0, 0);

        foreach(var item in arr) {
            foreach(var dot in item) {
                System.Console.Write($" {dot:D2} ");
            }
            System.Console.WriteLine();
        }
        return arr[length - 1][length - 1];
    }
}
