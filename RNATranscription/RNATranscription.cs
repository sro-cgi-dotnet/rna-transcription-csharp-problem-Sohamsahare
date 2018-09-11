using System;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotides)
        {
            // Making a dummy string which will convert DNA to RNA string
            string rnaString = "";
            // Checking each DNA string and appending the corresponding
            // RNA string to rnaString
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
