using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode._2020
{
    public class Day3
    {
        public int Execute(string input, int xStep = 3, int yStep = 1)
        {
            var values = input.Split('&');
            var length = values[0].Length;
            var y = yStep;
            var x = xStep;
            var trees = 0;
            do
            {
                if (values[y][x] == '#')
                {
                    trees++;
                }

                y += yStep;
                x += xStep;
                if (x >= length)
                {
                    x -= length;
                }
            } while (y < values.Length);

            return trees;
        }
    }
}
