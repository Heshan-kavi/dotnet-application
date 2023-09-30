using System;
namespace Helloworld
{
	public class StringUtilization
	{
		public static string SummerizingText(string sentence, int maxLength = 20)
        {
            if (sentence.Length < maxLength)
            {
                return sentence;
            }

            var words = sentence.Split(' ');
            var totalCharacters = 0;
            var summaryTextList = new List<string>();

            foreach (var word in words)
            {
                totalCharacters += word.Length + 1;
                summaryTextList.Add(word);
                if (totalCharacters > maxLength)
                {
                    break;
                }
            }

            return string.Join(' ', summaryTextList) + " ...";
        }
    }
}

