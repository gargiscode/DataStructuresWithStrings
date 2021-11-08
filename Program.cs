using System;

namespace DataStructuresWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given a string S, find the longest palindromic substring in S.
            //Input: "babad"
            //Output: "bab"
            string inputStr = "babad";
            string maxSub = string.Empty;
            int i, j;
            int maxLength = 1;
            

            for (i = 0; i < inputStr.Length; i++)
            { 
                for (j = i; j < inputStr.Length; j++)
                {
                    if (inputStr[i] == inputStr[j])
                    { 
                        
                    }
                }
            }




        
        }
    }
}
