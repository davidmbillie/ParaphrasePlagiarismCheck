using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Plag_Check
{
    public partial class SevenWords : Form
    {
        public SevenWords()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string origText = SevenWordsLib.OnlyWords(txtOrig.Text);
            string[] origTextArr = origText.Split(' ');
            string studentText = SevenWordsLib.OnlyWords(txtStudent.Text);

            if (string.IsNullOrWhiteSpace(origText) | string.IsNullOrWhiteSpace(studentText))
            {
                MessageBox.Show("Please enter text in both boxes");
                return;
            }
            else if (origTextArr.Length < 7)
            {
                MessageBox.Show("Please enter text with more than seven words");
            }

            List<string> sevenWordMatches = SevenWordsLib.FindSevenWordMatches(studentText, origTextArr);

            if (sevenWordMatches.Count == 0)
            {
                MessageBox.Show("No matching seven consecutive words are present");
            }
            else
            {
                MessageBox.Show(sevenWordMatches.Count + " matches found:" + Environment.NewLine + 
                    string.Join(Environment.NewLine, sevenWordMatches));
            }
        }

        private void SevenWords_Load(object sender, EventArgs e)
        {

        }

    }
}
