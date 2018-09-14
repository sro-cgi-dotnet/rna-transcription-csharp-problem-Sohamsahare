using System;
using System.Text;
namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotides)
        {
            // Making a dummy string which will convert DNA to RNA string
            StringBuilder rnaString = new StringBuilder();
            // Checking each DNA string and appending the corresponding
            // RNA string to rnaString
            foreach(char nucleotide in nucleotides){
                switch(nucleotide){
                    case 'G':
                            rnaString.Append("C");
                            break;
                    case 'C':
                            rnaString.Append("G");
                            break;
                    case 'T':
                            rnaString.Append("A");
                            break;
                    case 'A':
                            rnaString.Append("U");
                            break;
                    default:
                            throw new ArgumentException("Nucleotides can only be G, C, T and A");
                }
            }
            // returning the updated string
            return rnaString.ToString();
        }
    }
}
