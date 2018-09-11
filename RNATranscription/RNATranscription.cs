using System;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotides)
        {
            string rnaString = "";
            foreach(char nucleotide in nucleotides){
                switch(nucleotide){
                    case 'G':
                            rnaString += "C";
                            break;
                    case 'C':
                            rnaString += "G";
                            break;
                    case 'T':
                            rnaString += "A";
                            break;
                    case 'A':
                            rnaString += "U";
                            break;
                    default:
                            throw new ArgumentException("Nucleotides can only be G, C, T and A");
                            break;
                }
            }
            return rnaString;
        }
    }
}
