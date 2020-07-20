using System.Collections.Generic;
using NUnit.Framework;

namespace Plag_Check
{
    public class SevenWordsTest
    {
        public const string OrigText = "Long ago, when there was no written history, these islands were the home of millions of happy birds; the resort of a hundred times more millions of fishes, sea lions, and other creatures. Here lived innumerable creatures predestined from the creation of the world to lay up a store of wealth for the British farmer, and a store of quite another sort for an immaculate Republican government.";
        public const string PlagStudText = "In ages which have no record these islands were the home of millions of happy birds, the resort of a hundred times more millions of fishes, of sea lions, and other creatures whose names are not so common; the marine residence, in fact, of innumerable creatures predestined from the creation of the world to lay up a store of wealth for the British farmer, and a store of quite another sort for an immaculate Republican government.";
        public const string ParaphraseStudText = "Old islands had a bunch of happy birds, fishes, sea lions, etc. These creatures led to weathy farmers and a happy government.";

        [Test]
        public void FindSevenWordMatches_ReturnsCorrectCount()
        {
            string[] arrOrigText = SplitText(OrigText);
            List<string> result = SevenWordsLib.FindSevenWordMatches(PlagStudText, arrOrigText);
            Assert.AreEqual(6, result.Count);
        }

        [Test]
        public void FindSevenWordMatches_ReturnsNoMatches()
        {
            string[] arrOrigText = SplitText(OrigText);
            List<string> result = SevenWordsLib.FindSevenWordMatches(ParaphraseStudText, arrOrigText);
            Assert.IsEmpty(result);
        }

        private string[] SplitText (string text)
        {
            return text.Split(' ');
        }
    }
}