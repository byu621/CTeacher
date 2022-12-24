
namespace CTeacher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.character1 = new System.Windows.Forms.Label();
            this.pinyin1 = new System.Windows.Forms.Label();
            this.character2 = new System.Windows.Forms.Label();
            this.pinyin2 = new System.Windows.Forms.Label();
            this.iterater = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // character1
            // 
            this.character1.AutoSize = true;
            this.character1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.character1.Location = new System.Drawing.Point(24, 52);
            this.character1.Name = "character1";
            this.character1.Size = new System.Drawing.Size(162, 153);
            this.character1.TabIndex = 1;
            this.character1.Text = "C";
            // 
            // pinyin1
            // 
            this.pinyin1.AutoSize = true;
            this.pinyin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pinyin1.Location = new System.Drawing.Point(77, 227);
            this.pinyin1.Name = "pinyin1";
            this.pinyin1.Size = new System.Drawing.Size(63, 25);
            this.pinyin1.TabIndex = 2;
            this.pinyin1.Text = "pinyin";
            // 
            // character2
            // 
            this.character2.AutoSize = true;
            this.character2.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.character2.Location = new System.Drawing.Point(24, 263);
            this.character2.Name = "character2";
            this.character2.Size = new System.Drawing.Size(162, 153);
            this.character2.TabIndex = 3;
            this.character2.Text = "C";
            // 
            // pinyin2
            // 
            this.pinyin2.AutoSize = true;
            this.pinyin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pinyin2.Location = new System.Drawing.Point(67, 427);
            this.pinyin2.Name = "pinyin2";
            this.pinyin2.Size = new System.Drawing.Size(63, 25);
            this.pinyin2.TabIndex = 4;
            this.pinyin2.Text = "pinyin";
            // 
            // iterater
            // 
            this.iterater.AutoSize = true;
            this.iterater.Location = new System.Drawing.Point(90, 26);
            this.iterater.Name = "iterater";
            this.iterater.Size = new System.Drawing.Size(40, 13);
            this.iterater.TabIndex = 5;
            this.iterater.Text = "Iterator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 603);
            this.Controls.Add(this.iterater);
            this.Controls.Add(this.pinyin2);
            this.Controls.Add(this.character2);
            this.Controls.Add(this.pinyin1);
            this.Controls.Add(this.character1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BaseForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label character1;
        private System.Windows.Forms.Label pinyin1;
        private System.Windows.Forms.Label character2;
        private System.Windows.Forms.Label pinyin2;
        private System.Windows.Forms.Label iterater;
    }
}

