using System;

namespace AdventOfCode
{
    public class Day1
    {
        public int Execute(string input)
        {
            var values = input.Split('&');
            for (var i = 0; i < values.Length; i++)
            {
                for (var x = i + 1; x < values.Length; x++)
                {
                    var first = Convert.ToInt32(values[i]);
                    var second = Convert.ToInt32(values[x]);
                    if (first + second == 2020)
                    {
                        return first * second;
                    }
                }
            }

            return 0;
        }

        public int ExecutePart2(string input)
        {
            var values = input.Split('&');
            for (var i = 0; i < values.Length; i++)
            {
                for (var x = i + 1; x < values.Length; x++)
                {
                    for (var y = x + 1; y < values.Length; y++)
                    {
                        var first = Convert.ToInt32(values[i]);
                        var second = Convert.ToInt32(values[x]);
                        var third = Convert.ToInt32(values[y]);
                        if (first + second + third == 2020)
                        {
                            return first * second * third;
                        }
                    }
                }
            }

            return 0;
        }
    }
}
