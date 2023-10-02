using System;
namespace Helloworld
{
	public class FileAndFileInfo
	{

		const string path = @"/Users/heshankavinda/Git Repos/dotnet Repos/testing_image.png";
        const string pathTwo = @"/Users/heshankavinda/Git Repos/dotnet Repos";


        public static void FileRelatedFunctionalities()							//in here we are using some of the static functionalites 
		{
			File.Copy(path, pathTwo, true);
			File.Delete(path);
			if (File.Exists(path))
			{
				Console.WriteLine("the file exists");
			}
		}

		public static void FileInfoRelatedFunctionalities()						//in here we are using the instance functionalities
		{
			var fileInfo = new FileInfo(path);
			fileInfo.CopyTo(pathTwo);
			fileInfo.Delete();
			if (fileInfo.Exists)
			{
                Console.WriteLine("the file exists");
            }
        }

		//notes
		//if we use static functionalities more often it will effect the performance because in that occasion there will be a security check by the OS regarding the user access when a function called
		//in fileinfo since we creating a instance once so there are no user access checks so it will improve the perfomance but in fileinfo there are some limitaions like we cannot real the file easily
		//because it returns a filestream not a string content
	}
}

