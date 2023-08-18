using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineLetters
{
    public class LetterService: ILetterService
    {
        public void CombineTwoLetters(string inputFile1, string inputFile2, string resultFile)
        {

            // Read the contents of the input files
            string content1 = File.ReadAllText(inputFile1);
            string content2 = File.ReadAllText(inputFile2);

            // Make sure these 2 file paths matches the path in your own environment
            string outputFolderPath = "C:\\CombineLettersExercise\\CombineLetters\\Output\\";
            string archiveFolderPath = "C:\\CombineLettersExercise\\CombineLetters\\Archive\\";

            string reportFilePath = Path.Combine(outputFolderPath, "report.txt");

            // Combine the contents
            string combinedContent = content1 + "\n" + "-------------------------------------------------------------------------------------------------------" + "\n" + content2;
            string outputFile = Path.Combine(outputFolderPath, resultFile);


            File.WriteAllText(outputFile, combinedContent);
            Console.WriteLine("Files combined and saved to the output folder.");


            // Move input files to the archive folder
            string archivedFile1 = Path.Combine(archiveFolderPath, Path.GetFileName(inputFile1));
            string archivedFile2 = Path.Combine(archiveFolderPath, Path.GetFileName(inputFile2));

            File.Copy(inputFile1, archivedFile1);
            File.Copy(inputFile2, archivedFile2);
            Console.WriteLine("Input files moved to the archive folder.");


            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            string[] outputFiles = Directory.GetFiles(outputFolderPath, "*.txt")
                                            .Select(file => Path.GetFileNameWithoutExtension(file))
                                            .ToArray();
            string reportContent = $"{currentDate} Report \n--------------------------- \n\nNumber of Combined Letters: {outputFiles.Length}\n";
            reportContent += string.Join("\n", outputFiles);

            // Write report content to report file
            File.WriteAllText(reportFilePath, reportContent);
            Console.WriteLine("Report file created with current date, number of Combines Letters, and University Letters.");








        }
    }
}
