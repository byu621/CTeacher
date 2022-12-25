using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTeacher
{
    public partial class Form1 : Form
    {
        private List<string> currentSet = new List<string>();
        private List<string> hsk1Unknown = new List<string>();
        private List<string> hsk2Unknown = new List<string>();
        private int iterator = 0;
        private bool revealed = false;
        private int low = 0;
        private int high = int.MaxValue;

        public Form1()
        {
            KeyPreview = true;
            InitializeComponent();

            hsk1Unknown.AddRange(File.ReadAllLines("HSK/hsk1unknown.txt"));
            hsk2Unknown.AddRange(File.ReadAllLines("HSK/hsk2unknown.txt"));
            currentSet.AddRange(hsk1Unknown);

            Randomise();
            Action();
        }

        private void Randomise()
        {
            Random rand = new Random();
            currentSet = currentSet.OrderBy(_ => rand.Next()).ToList();
        }

        private void BaseForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Action();
                e.Handled = true;
            }
        }

        private void Action()
        {
            if (revealed)
            {
                NextCharacter();
            } else
            {
                RevealCharacter();
            }

            revealed = !revealed;
        }

        private void RevealCharacter()
        {
            pinyin1.Text = TinyPinyin.PinyinHelper.GetPinyin(character1.Text);
            pinyin2.Text = TinyPinyin.PinyinHelper.GetPinyin(character2.Text);
        }

        private void NextCharacter()
        {
            if (currentSet.Count == 0)
            {
                return;
            }

            pinyin1.Text = "";
            character1.Text = currentSet[iterator];
            iterator++;
            if (iterator == currentSet.Count)
            {
                iterator = 0;
            }

            if (iterator == 0)
            {
                Randomise();
            }

            pinyin2.Text = "";
            character2.Text = currentSet[iterator];
            iterator++;
            if (iterator == currentSet.Count)
            {
                iterator = 0;
            }

            if (iterator == 0)
            {
                Randomise();
            }

            iterater.Text = iterator.ToString();
        }

        private void hsk1_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = (CheckBox)sender;
            currentSet.Clear();

            if (checkbox.Checked)
            {
                for (int i = low; i <= high; i++)
                {
                    currentSet.Add(hsk1Unknown[i]);
                }
                Randomise();
            } 

            iterator = 0;
        }

        private void hsk2_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = (CheckBox)sender;
            currentSet.Clear();

            if (checkbox.Checked)
            {
                for (int i = low; i <= high; i++)
                {
                    currentSet.Add(hsk2Unknown[i]);
                }
                Randomise();
            }

            iterator = 0;
        }

        private void range_TextChanged(object sender, EventArgs e)
        {
            if (!range.Text.Contains("-"))
            {
                low = 0;
                high = int.MaxValue;
                return;
            }

            low = int.Parse(range.Text.Split('-')[0]);
            high = int.Parse(range.Text.Split('-')[1]);
        }
    }
}
