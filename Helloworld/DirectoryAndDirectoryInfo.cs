using System;
namespace Helloworld
{
	public class DirectoryAndDirectoryInfo
	{
        const string path = @"/Users/heshankavinda/Git Repos/dotnet Repos/testing_image.png";
        const string pathTwo = @"/Users/heshankavinda/Git Repos/dotnet Repos";


        public static void DirectoryRelatedFunctionalities()                         //in here we are using some of the static functionalites 
        {
            File.Copy(path, pathTwo, true);
            File.Delete(path);
            if (File.Exists(path))
            {
                Console.WriteLine("the file exists");
            }
        }

        public static void DirectoryInfoRelatedFunctionalities()                     //in here we are using the instance functionalities
        {
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(pathTwo);
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                Console.WriteLine("the file exists");
            }
        }
    }
}

