using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolvingPatterns
{
    public class FrequencyCounters
    {
        #region Two arrys check

        // Example: inputs: two array, output true/false if every value in the first array/list has corresponding 
        // value squared in the second array. The frequency of the values must be same
        // [1,1,2,3] [1,1,9,4] true
        // [2,3,2,3] [4,4,4,4] false
        // [2,3,4,1] [1,16,9,4] true
        // [2,2,2] [4,4,5] false

        public bool CheckCorrespondingSquaredElementsInTwoArrays(List<int> firstArray, List<int> secondArray)
        {
            if (firstArray.Count != secondArray.Count)
            {
                return false;
            }

            Dictionary<int, int> frequencyCounter1 = new Dictionary<int, int>();

            Dictionary<int, int> frequencyCounter2 = new Dictionary<int, int>();

            for (int i = 0; i < firstArray.Count; i++)
            {
                if (frequencyCounter1.TryGetValue(firstArray[i], out int value))
                {
                    frequencyCounter1[firstArray[i]]++;
                }
                else
                {
                    frequencyCounter1[firstArray[i]] = 1;
                }
            }

            for (int i = 0; i < secondArray.Count; i++)
            {
                if (frequencyCounter2.TryGetValue(secondArray[i], out int value))
                {
                    frequencyCounter2[secondArray[i]]++;
                }
                else
                {
                    frequencyCounter2[secondArray[i]] = 1;
                }
            }

            foreach (var key in frequencyCounter1.Keys)
            {
                if (!frequencyCounter2.Keys.Contains(key * key))
                {
                    return false;
                }

                if (frequencyCounter1[key] != frequencyCounter2[key * key])
                {
                    return false;
                }
            }

            return true;
        }

        #endregion


        #region Anagram

        // Example, input two strings, output, check is second string anagram of the first one
        // An anagram is word, phrase, or name formed by rearranging letters of another
        // Example: cinema iceman true
        // '' '' trues
        // aaz zza false
        // aaz aza true

        public bool CheckIsAnagram(string textOne, string textTwo)
        {
            if (textOne.Length != textTwo.Length)
            {
                return false;
            }

            Dictionary<char, int> frequencyCounter1 = new Dictionary<char, int>();

            Dictionary<char, int> frequencyCounter2 = new Dictionary<char, int>();

            foreach (var character in textOne)
            {
                if (!frequencyCounter1.TryGetValue(character, out int value))
                {
                    frequencyCounter1.Add(character,1);
                }
                else
                {
                    frequencyCounter1[character]++;
                }
            }

            foreach (var character in textTwo)
            {
                if (!frequencyCounter2.TryGetValue(character, out int value))
                {
                    frequencyCounter2.Add(character, 1);
                }
                else
                {
                    frequencyCounter2[character]++;
                }
            }

            foreach (var key in frequencyCounter1.Keys)
            {
                if (!frequencyCounter2.Keys.Contains(key))
                {
                    return false;
                }

                if (frequencyCounter2[key] != frequencyCounter1[key])
                {
                    return false;
                }
            }

            return true;
        }

        #endregion

    }
}
