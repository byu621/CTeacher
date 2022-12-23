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

        public Form1()
        {
            this.KeyPreview = true;
            InitializeComponent();

            hsk1Unknown.AddRange(File.ReadAllLines("HSK/hsk1unknown.txt"));
            hsk1Easy.AddRange(File.ReadAllLines("HSK/hsk1easy.txt"));
            hsk1Hard.AddRange(File.ReadAllLines("HSK/hsk1hard.txt"));

            Randomise();
            RevealCharacter();
        }

        private void Randomise()
        {
            Random rand = new Random();
            hsk1Unknown = hsk1Unknown.OrderBy(_ => rand.Next()).ToList();
        }

        private void Reveal(object sender, EventArgs e)
        {
            RevealCharacter();
        }

        private void BaseForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                RevealCharacter();
            }
            e.Handled = true;
        }

        private void RevealCharacter()
        {
            Console.WriteLine(iterator);
            character1.Text = hsk1Unknown[iterator++];
        }
    }
}
