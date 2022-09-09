﻿using System;

namespace Diamond_Kata
{
    public class DiamondKata: IDiamondKata
    {

        public string CreateSequence(char c)
        {
            string charDetails = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            int resultIndex = charDetails.IndexOf(c.ToString().ToUpper());
            return charDetails.Substring(0, resultIndex + 1);

        }

        public string CreateFirstHalfDiamond(int number, char[] c)
        {
            string result = "";
            int charCounter = 0;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= number - i; j++)
                {
                    result = result + "_ ";
                    charCounter++;
                }

                for (int k = 1; k <= i; k++)
                {
                    if((i== number) &&  (k !=1 && k!=i))
                    {
                     result = char.IsWhiteSpace(result,result.Length-1)? result + "_ _" : result + " _ _ ";
                    }
                    else if (i == number && k == number)
                    {
                        result =  result + " " + c[i - 1].ToString(); 
                    }
                    else
                    {
                        result = result + c[i - 1].ToString() + " _ ";
                    }
                    charCounter = charCounter + 2;
                }

                var resultSpace = CalculateSpace(number, charCounter, result);
                result = resultSpace;

                result = result + Environment.NewLine;
                charCounter = 0;
            }

            return result;
        }

        public string CreateSecondHalfDiamond(int number, char[] c)
        {
            string result = "";
            int charCounter = 0;

            for (int i = 1; i <=number-1; i++)
            {

                for (int j = 1; j <=i; j++)
                {
                    result = result + "_ ";
                    charCounter++;
                }
                for (int k = number-1; k >=i; k--)
                {
                    result = result + c[number - (i+1)].ToString() + " _ ";
                    charCounter = charCounter + 2;
                }

                var resultSpace = CalculateSpace(number, charCounter, result);
                result = resultSpace;

                result = result + Environment.NewLine;
                charCounter = 0;
            }
            return result;
        }


        public string CreateDiamond(char c)
        {
            string result;
            string charSequence;
            string resultFirstHalfDiamond;
            string resultSecondHalfDiamond;

            if (!char.IsLetter(c))
            {
              return "Please input valid character.";
            }

            charSequence = CreateSequence(c);
            resultFirstHalfDiamond = CreateFirstHalfDiamond(charSequence.Length, charSequence.ToCharArray());
            resultSecondHalfDiamond = CreateSecondHalfDiamond(charSequence.Length, charSequence.ToCharArray());
            result = string.Concat(resultFirstHalfDiamond, resultSecondHalfDiamond);

            return result;
        }

        private string CalculateSpace(int number, int charCount, string result)
        {
            var spaceCount = (number == 1) ? number + 1 : (number % 2 == 0) ? number + 1 : number + 2;
            if (charCount < spaceCount)
            {
                result = result + "_ ";
            }

            return result ;

        }

    }
}
