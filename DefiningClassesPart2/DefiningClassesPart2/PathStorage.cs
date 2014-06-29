namespace DefiningClassesPart2
{
    using System;
    using System.IO;

    public static class PathStorage
    {
        public static void SavePath(string fileName, string buffer)
        {
            try
            {
                StreamWriter writer = new StreamWriter(fileName);
                using (writer)
                {
                    writer.Write(buffer);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You do not have the required permission for file: {0}", fileName);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File {0} not found", fileName);
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occured while opening file: {0}", fileName);
            }
        }

        public static string LoadPath(string fileName)
        {
            string buffer = string.Empty;
            try
            {
                StreamReader reader = new StreamReader(fileName);
                using (reader)
                {
                    buffer = reader.ReadToEnd();
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You do not have the required permission for file: {0}", fileName);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File {0} not found", fileName);
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occured while opening file: {0}", fileName);
            }

            return buffer;
        }
    }
}