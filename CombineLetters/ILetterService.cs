using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineLetters
{
    public interface ILetterService
    {
        void CombineTwoLetters(string inputFile1, string inputFile2, string resultFile);

    }
}
