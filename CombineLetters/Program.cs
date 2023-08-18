// Modified by Tamer Ayoub 8/17/2023

using CombineLetters;
public class Program
{
    public static void Main(string[] args)
    {

        // Make sure these 2 file paths matches the path in your own environment
        string inputFile1 = "C:\\CombineLettersExercise\\CombineLetters\\Input\\Admission\\20230817\\admission-22226666.txt";
        string inputFile2 = "C:\\CombineLettersExercise\\CombineLetters\\Input\\Scholarship\\20230817\\scholarship-22226666.txt";

        string resultFile = "22226666.txt";

        ILetterService letterService = new LetterService();
        letterService.CombineTwoLetters(inputFile1, inputFile2, resultFile);
    }
}