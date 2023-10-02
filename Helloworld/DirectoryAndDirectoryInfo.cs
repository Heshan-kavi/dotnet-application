using System;
namespace Helloworld
{
	public class DirectoryAndDirectoryInfo
	{
        const string path = @"/Users/heshankavinda/Git Repos/dotnet Repos/testing_image.png";


        public static void DirectoryRelatedFunctionalities()                         //in here we are using some of the static functionalites 
        {
            Directory.CreateDirectory(path);
            var files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            foreach(var file in files) {
                Console.WriteLine(file);
            }
            var directories = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);
            foreach(var directory in directories)
            {
                Console.WriteLine(directory);
            }
        }

        public static void DirectoryInfoRelatedFunctionalities()                     //in here we are using the instance functionalities
        {
           //same as the Directory class functions only difference is return a instatnce functions
        }

        //notes
        //the difference between the directory and the directoryinfo is same as the file and fileinfo
    }
}

