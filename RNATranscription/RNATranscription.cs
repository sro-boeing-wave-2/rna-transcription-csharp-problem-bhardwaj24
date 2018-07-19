using System;
using System.Collections.Generic;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            Dictionary<char, string> dict = new Dictionary<char, string>();
            dict.Add('G', "C");
            dict.Add('C', "G");
            dict.Add('T', "A");
            dict.Add('A', "U");
            int i;
            string str = "";
                for (i = 0;i< nucleotide.Length;i++)
                {
                str+=dict[nucleotide[i]];
                }
            return str;
            throw new NotImplementedException("You need to implement this function.");
        }
    }
}
