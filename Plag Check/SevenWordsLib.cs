using System.Collections.Generic;

namespace Plag_Check
{
    public class SevenWordsLib
    {
        public static List<string> FindSevenWordMatches(string studentText, string[] origTextArr)
        {
            List<string> matches = new List<string>();

            for (int x = 0; x < origTextArr.Length - 7; x++)
            {
                string searchString = "";
                for (int y = x; y < x + 7; y++)
                {
                    searchString += origTextArr[y] + " ";
                }
                searchString = searchString.Trim();
                if (studentText.Contains(searchString))
                {
                    matches.Add(searchString);
                    x += 6;
                }
            }

            return matches;
        }

        /// <summary>
        /// Removes all but letters, numbers, and dashes
        /// </summary>
        public static string OnlyWords(string str)
        {
            return System.Text.RegularExpressions.Regex.Replace(str, "[^a-zA-Z0-9- ]", "");
        }
    }
}
