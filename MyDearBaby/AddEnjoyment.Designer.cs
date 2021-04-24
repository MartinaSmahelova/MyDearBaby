
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
            this.richTextBox_enjoyment = new System.Windows.Forms.RichTextBox();
            this.lbl_actualDate = new System.Windows.Forms.Label();
            this.checkedListBox_children = new System.Windows.Forms.CheckedListBox();
            this.btn_addEnjoyment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_enjoyment
            // 
            this.richTextBox_enjoyment.Location = new System.Drawing.Point(59, 197);
            this.richTextBox_enjoyment.Name = "richTextBox_enjoyment";
            this.richTextBox_enjoyment.Size = new System.Drawing.Size(417, 241);
            this.richTextBox_enjoyment.TabIndex = 0;
            this.richTextBox_enjoyment.Text = "";
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
            this.checkedListBox_children.Location = new System.Drawing.Point(59, 87);
            this.checkedListBox_children.Name = "checkedListBox_children";
            this.checkedListBox_children.Size = new System.Drawing.Size(417, 92);
            this.checkedListBox_children.TabIndex = 2;
            // 
            // btn_addEnjoyment
            // 
            this.btn_addEnjoyment.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_addEnjoyment.Location = new System.Drawing.Point(190, 465);
            this.btn_addEnjoyment.Name = "btn_addEnjoyment";
            this.btn_addEnjoyment.Size = new System.Drawing.Size(142, 29);
            this.btn_addEnjoyment.TabIndex = 3;
            this.btn_addEnjoyment.Text = "Přidej zážitek";
            this.btn_addEnjoyment.UseVisualStyleBackColor = true;
            this.btn_addEnjoyment.Click += new System.EventHandler(this.btn_addEnjoyment_Click);
            // 
            // AddEnjoyment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 506);
            this.Controls.Add(this.btn_addEnjoyment);
            this.Controls.Add(this.checkedListBox_children);
            this.Controls.Add(this.lbl_actualDate);
            this.Controls.Add(this.richTextBox_enjoyment);
            this.Name = "AddEnjoyment";
            this.Text = "PopupFormAddEnjoyment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_enjoyment;
        private System.Windows.Forms.Label lbl_actualDate;
        private System.Windows.Forms.CheckedListBox checkedListBox_children;
        private System.Windows.Forms.Button btn_addEnjoyment;
    }
}