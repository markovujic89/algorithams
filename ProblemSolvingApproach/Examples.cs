using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingApproach
{
    public class Examples
    {
        public Dictionary<char, int> CountCharactests(string text)
        {
            Dictionary<char, int> charactersCountMap = new Dictionary<char, int>();

            if (String.IsNullOrEmpty(text))
            {
                return charactersCountMap;
            }
            

            foreach (var character in text.ToLower())
            {
                if (!char.IsLetterOrDigit(character))
                {
                    continue;
                }

                if (!charactersCountMap.TryGetValue(character, out int count))
                {
                    charactersCountMap.Add(character,1);
                }
                else
                {
                    charactersCountMap[character]++;
                }
            }

            return charactersCountMap;
        }

        public void PrintCountCharactests(Dictionary<char, int> charactersCountMap)
        {
            if (charactersCountMap.Count == 0)
            {
                Console.WriteLine("Incorrect input, text is not defined!!");
                return;
            }
            StringBuilder sb = new StringBuilder();

            foreach (var charactersCount in charactersCountMap)
            {
                sb.AppendLine($"Characters {charactersCount.Key} has count {charactersCount.Value}");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
