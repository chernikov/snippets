using System;

namespace FindingPath
{
    public class Finder {

        public static bool PathFinder(string maze) 
        {
            var map = maze.Split("\n");
            var length = map.Length;
            var arr = new bool [length][];
            for(int i = 0; i < length; i++) {
                arr[i] = new bool[length];
            }

            void Spoil(int i, int j) 
            {
                arr[i][j] = true;
                //i, j+
                if ((j < length - 1) && !arr[i][j+1] && map[i][j+1] == '.') {
                    Spoil(i, j+1);
                }
                //i, j-
                if (j > 0 && !arr[i][j-1] && map[i][j-1] == '.') {
                    Spoil(i, j-1);
                }
                //i+, j
                if ((i < length - 1)  && !arr[i+1][j] && map[i+1][j] == '.') {
                    Spoil(i+1, j);
                }
                //i-, j
                if (i > 0 && !arr[i-1][j] && map[i-1][j] == '.') {
                    Spoil(i-1, j);
                }
            }
            Spoil(0, 0);
            return arr[length-1][length-1];
        }
    }
}
