namespace FileReader
{
    public static class Extension
    {
        public static void PrintVar(this object variable, string description)
        {
            Console.WriteLine(description + ": " + variable.ToString());
        }

        //public static bool TryFindParentDirectory(this DirectoryInfo directory, string targetFolder, out DirectoryInfo directoryResult)
        //{
        //    string folderName = new DirectoryInfo(directory.FullName).Name;
        //    bool compareResult = string.Compare(folderName, targetFolder, StringComparison.OrdinalIgnoreCase) == 0;
        //    if (compareResult)
        //    {
        //        directoryResult = ;
        //        return true;
        //    } 
        //}
    }
}
