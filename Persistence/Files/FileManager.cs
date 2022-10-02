using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Recruitment.Persistence.Files
{
    internal static class FileManager
    {        
        /// <summary>
        /// Read a file
        /// </summary>
        /// <param name="fileName">File name to read</param>
        /// <returns>Stream with the read file</returns>
        internal static StreamReader ReadFromFile(string fileName)
        {
            FileStream fileStream = new FileStream(Path(fileName), FileMode.Open);
            StreamReader reader = new StreamReader(fileStream);
            return reader;
        }
        /// <summary>
        /// Add new line to a file
        /// </summary>
        /// <param name="fileName">File name to add line</param>
        /// <param name="newLine">New line to add</param>        
        internal static async Task AddLine(string fileName, string newLine)
        {
            TextWriter textWriter = new StreamWriter(Path(fileName));
            await textWriter.WriteLineAsync(newLine);
            textWriter.Close();
        }
        static string Path(string fileName) => Directory.GetCurrentDirectory() + $"/Files/" + fileName;
    }
}
