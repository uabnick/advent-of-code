using System;
using System.Linq;

namespace AdventOfCode._2020
{
    public class Day2
    {
        public int Execute(string input)
        {
            var values = input.Split('&');
            var policies = values.Select(CreatePolicy);
            var result = policies.Where(IsPolicyValidForPartTwo);
            return result.Count();
        }

        private Policy CreatePolicy(string input)
        {
            var parts = input.Split(' ');
            var firstParts = parts[0].Split('-');
            return new Policy
            {
                Min = Convert.ToInt32(firstParts[0]),
                Max = Convert.ToInt32(firstParts[1]),
                Character = parts[1][0],
                Value = parts[2]
            };
        }

        private bool IsPolicyValid(Policy policy)
        {
            var count = policy.Value.ToCharArray().Count(v => v == policy.Character);
            return count >= policy.Min & count <= policy.Max;
        }

        private bool IsPolicyValidForPartTwo(Policy policy)
        {
            return (policy.Value[policy.Min - 1] == policy.Character || policy.Value[policy.Max - 1] == policy.Character) &&
                   !(policy.Value[policy.Min - 1] == policy.Character && policy.Value[policy.Max - 1] == policy.Character);
        }
    }

    public class Policy
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public char Character { get; set; }
        public string Value { get; set; }
    }
}
