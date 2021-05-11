
namespace MyDearBaby
{
    partial class EnjoymentsForm
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
            this.richTextBoxEnjoyments = new System.Windows.Forms.RichTextBox();
            this.textBoxKeyWord = new System.Windows.Forms.TextBox();
            this.checkedListBoxCategories = new System.Windows.Forms.CheckedListBox();
            this.btnKeyWordFilter = new MyDearBaby.RoundButton();
            this.btnCategoryFilter = new MyDearBaby.RoundButton();
            this.btnSaveEnjoyments = new MyDearBaby.RoundButton();
            this.roundButton3 = new MyDearBaby.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxEnjoyments
            // 
            this.richTextBoxEnjoyments.Location = new System.Drawing.Point(32, 47);
            this.richTextBoxEnjoyments.Name = "richTextBoxEnjoyments";
            this.richTextBoxEnjoyments.Size = new System.Drawing.Size(487, 414);
            this.richTextBoxEnjoyments.TabIndex = 0;
            this.richTextBoxEnjoyments.Text = "";
            // 
            // textBoxKeyWord
            // 
            this.textBoxKeyWord.Location = new System.Drawing.Point(50, 581);
            this.textBoxKeyWord.Name = "textBoxKeyWord";
            this.textBoxKeyWord.Size = new System.Drawing.Size(300, 27);
            this.textBoxKeyWord.TabIndex = 5;
            // 
            // checkedListBoxCategories
            // 
            this.checkedListBoxCategories.FormattingEnabled = true;
            this.checkedListBoxCategories.Location = new System.Drawing.Point(50, 639);
            this.checkedListBoxCategories.Name = "checkedListBoxCategories";
            this.checkedListBoxCategories.Size = new System.Drawing.Size(301, 70);
            this.checkedListBoxCategories.TabIndex = 6;
            // 
            // btnKeyWordFilter
            // 
            this.btnKeyWordFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(249)))));
            this.btnKeyWordFilter.FlatAppearance.BorderSize = 0;
            this.btnKeyWordFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeyWordFilter.ForeColor = System.Drawing.Color.Black;
            this.btnKeyWordFilter.Location = new System.Drawing.Point(356, 554);
            this.btnKeyWordFilter.Name = "btnKeyWordFilter";
            this.btnKeyWordFilter.Size = new System.Drawing.Size(87, 81);
            this.btnKeyWordFilter.TabIndex = 7;
            this.btnKeyWordFilter.Text = "Hledej klíčové slovo";
            this.btnKeyWordFilter.UseVisualStyleBackColor = false;
            this.btnKeyWordFilter.Click += new System.EventHandler(this.btnKeyWordFilter_Click);
            // 
            // btnCategoryFilter
            // 
            this.btnCategoryFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(171)))), ((int)(((byte)(135)))));
            this.btnCategoryFilter.FlatAppearance.BorderSize = 0;
            this.btnCategoryFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryFilter.Location = new System.Drawing.Point(423, 627);
            this.btnCategoryFilter.Name = "btnCategoryFilter";
            this.btnCategoryFilter.Size = new System.Drawing.Size(84, 82);
            this.btnCategoryFilter.TabIndex = 8;
            this.btnCategoryFilter.Text = "Hledej kategorii";
            this.btnCategoryFilter.UseVisualStyleBackColor = false;
            this.btnCategoryFilter.Click += new System.EventHandler(this.btnCategoryFilter_Click);
            // 
            // btnSaveEnjoyments
            // 
            this.btnSaveEnjoyments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(240)))), ((int)(((byte)(89)))));
            this.btnSaveEnjoyments.FlatAppearance.BorderSize = 0;
            this.btnSaveEnjoyments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEnjoyments.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSaveEnjoyments.Location = new System.Drawing.Point(61, 476);
            this.btnSaveEnjoyments.Name = "btnSaveEnjoyments";
            this.btnSaveEnjoyments.Size = new System.Drawing.Size(86, 81);
            this.btnSaveEnjoyments.TabIndex = 9;
            this.btnSaveEnjoyments.Text = "Uložiť zážitky do souboru";
            this.btnSaveEnjoyments.UseVisualStyleBackColor = false;
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Location = new System.Drawing.Point(432, 476);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(87, 81);
            this.roundButton3.TabIndex = 11;
            this.roundButton3.Text = "Zobraziť všetky zážitky\r\n";
            this.roundButton3.UseVisualStyleBackColor = false;
            this.roundButton3.Click += new System.EventHandler(this.btnShowAllEnjoyments_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Zážitky:";
            // 
            // EnjoymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 730);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.btnSaveEnjoyments);
            this.Controls.Add(this.btnCategoryFilter);
            this.Controls.Add(this.btnKeyWordFilter);
            this.Controls.Add(this.checkedListBoxCategories);
            this.Controls.Add(this.textBoxKeyWord);
            this.Controls.Add(this.richTextBoxEnjoyments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EnjoymentsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBoxEnjoyments;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.TextBox textBoxKeyWord;
        private System.Windows.Forms.CheckedListBox checkedListBoxCategories;
        private RoundButton btnKeyWordFilter;
        private RoundButton btnCategoryFilter;
        private RoundButton btnSaveEnjoyments;
        private RoundButton roundButton3;
        private System.Windows.Forms.Label label1;
    }
}