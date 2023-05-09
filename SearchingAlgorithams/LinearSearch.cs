using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithams
{
    /// <summary>
    /// Linar search, go through the element in the collection from the beginning, and check the current element equation with input,
    /// if yes, return true. This algorithams is use for Count and IndexOf function
    /// </summary>
    public class LinearSearch
    {
        public bool LinearSearchAlgoritham(List<string> source, string input)
        {
            foreach (string element in source)
            {
                if(element.ToLower() == input.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
