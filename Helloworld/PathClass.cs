using System;
namespace Helloworld
{
	public class PathClass
	{
		public static void pathRelatedFunctionalities()
		{
            const string path = @"/Users/heshankavinda/Git Repos/dotnet Repos/testing_image.png";

            Console.WriteLine("Extension of the file : " + Path.GetExtension(path));
            Console.WriteLine("File name of the file : " + Path.GetFileName(path));
            Console.WriteLine("File name without the extension of the file : " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory of the file : " + Path.GetDirectoryName(path));
        }
	}
}

