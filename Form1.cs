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
        private List<string> hsk1Unknown = new List<string>();
        private List<string> hsk1Easy = new List<string>();
        private List<string> hsk1Hard = new List<string>();
        private int iterator = 0;
        private bool revealed = false;

        public Form1()
        {
            this.KeyPreview = true;
            InitializeComponent();

            hsk1Unknown.AddRange(File.ReadAllLines("HSK/hsk1unknown.txt"));
            hsk1Easy.AddRange(File.ReadAllLines("HSK/hsk1easy.txt"));
            hsk1Hard.AddRange(File.ReadAllLines("HSK/hsk1hard.txt"));

            Randomise();
            Action();
        }

        private void Randomise()
        {
            Random rand = new Random();
            hsk1Unknown = hsk1Unknown.OrderBy(_ => rand.Next()).ToList();
        }

        private void BaseForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Action();
            }
            e.Handled = true;
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
            pinyin1.Text = "";
            character1.Text = hsk1Unknown[iterator];
            iterator = (iterator + 1) % hsk1Unknown.Count;

            if (iterator == 0)
            {
                Randomise();
            }

            pinyin2.Text = "";
            character2.Text = hsk1Unknown[iterator];
            iterator = (iterator + 1) % hsk1Unknown.Count;

            if (iterator == 0)
            {
                Randomise();
            }

            iterater.Text = iterator.ToString();
        }
    }
}
