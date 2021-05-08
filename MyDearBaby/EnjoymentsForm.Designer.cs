
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCategoryFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.textBoxKeyWord = new System.Windows.Forms.TextBox();
            this.checkedListBoxCategories = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // richTextBoxEnjoyments
            // 
            this.richTextBoxEnjoyments.Location = new System.Drawing.Point(50, 37);
            this.richTextBoxEnjoyments.Name = "richTextBoxEnjoyments";
            this.richTextBoxEnjoyments.Size = new System.Drawing.Size(462, 431);
            this.richTextBoxEnjoyments.TabIndex = 0;
            this.richTextBoxEnjoyments.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCategoryFilter
            // 
            this.btnCategoryFilter.Location = new System.Drawing.Point(365, 556);
            this.btnCategoryFilter.Name = "btnCategoryFilter";
            this.btnCategoryFilter.Size = new System.Drawing.Size(114, 62);
            this.btnCategoryFilter.TabIndex = 2;
            this.btnCategoryFilter.Text = "Filtruj podle kategorie";
            this.btnCategoryFilter.UseVisualStyleBackColor = true;
            this.btnCategoryFilter.Click += new System.EventHandler(this.btnCategoryFilter_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(365, 488);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(147, 62);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "filtruj podle klíčového slova";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // textBoxKeyWord
            // 
            this.textBoxKeyWord.Location = new System.Drawing.Point(50, 506);
            this.textBoxKeyWord.Name = "textBoxKeyWord";
            this.textBoxKeyWord.Size = new System.Drawing.Size(300, 27);
            this.textBoxKeyWord.TabIndex = 5;
            // 
            // checkedListBoxCategories
            // 
            this.checkedListBoxCategories.FormattingEnabled = true;
            this.checkedListBoxCategories.Location = new System.Drawing.Point(49, 548);
            this.checkedListBoxCategories.Name = "checkedListBoxCategories";
            this.checkedListBoxCategories.Size = new System.Drawing.Size(301, 70);
            this.checkedListBoxCategories.TabIndex = 6;
            // 
            // EnjoymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 625);
            this.Controls.Add(this.checkedListBoxCategories);
            this.Controls.Add(this.textBoxKeyWord);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnCategoryFilter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxEnjoyments);
            this.Name = "EnjoymentsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCategoryFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.RichTextBox richTextBoxEnjoyments;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.TextBox textBoxKeyWord;
        private System.Windows.Forms.CheckedListBox checkedListBoxCategories;
    }
}