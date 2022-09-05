using System;
using System.Collections.Generic;
using System.Text;

namespace Diamond_Kata
{
    public interface IDiamondKata
    {
        string CreateSequence(char c);
        string CreateFirstHalfDiamond(int number, char[] c);

        string CreateSecondtHalfDiamond(int number, char[] c);

        string CreateDiamond(char c);

    }
}
