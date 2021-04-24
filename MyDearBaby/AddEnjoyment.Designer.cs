
namespace MyDearBaby
{
    partial class AddEnjoyment
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl_actualDate = new System.Windows.Forms.Label();
            this.checkedListBox_children = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(59, 197);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(417, 241);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lbl_actualDate
            // 
            this.lbl_actualDate.AutoSize = true;
            this.lbl_actualDate.Location = new System.Drawing.Point(59, 53);
            this.lbl_actualDate.Name = "lbl_actualDate";
            this.lbl_actualDate.Size = new System.Drawing.Size(41, 20);
            this.lbl_actualDate.TabIndex = 1;
            this.lbl_actualDate.Text = "Date";
            // 
            // checkedListBox_children
            // 
            this.checkedListBox_children.FormattingEnabled = true;
            this.checkedListBox_children.Location = new System.Drawing.Point(59, 76);
            this.checkedListBox_children.Name = "checkedListBox_children";
            this.checkedListBox_children.Size = new System.Drawing.Size(417, 114);
            this.checkedListBox_children.TabIndex = 2;
            // 
            // AddEnjoyment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.checkedListBox_children);
            this.Controls.Add(this.lbl_actualDate);
            this.Controls.Add(this.richTextBox1);
            this.Name = "AddEnjoyment";
            this.Text = "PopupFormAddEnjoyment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbl_actualDate;
        private System.Windows.Forms.CheckedListBox checkedListBox_children;
    }
}