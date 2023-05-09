using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithams
{
    internal class NaiveStringSearch
    {
        public int NaivStringSearchAlgoritham(string longText, string shortText)
        {
            int matchingCounter = 0;

            for (int i = 0; i< longText.Length; i++ )
            {
                for(int j=0; j< shortText.Length; j++ )
                {
                    if (shortText[j] != longText[i + j])
                    {
                        break;
                    }

                    if(j == shortText.Length-1)
                    {
                        matchingCounter++;
                    }
                }
            }
            return matchingCounter;
        }
    }
}
