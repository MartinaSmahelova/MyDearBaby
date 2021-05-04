
namespace MyDearBaby
{
    partial class AddEnjoymentForm
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
            this.richTextBoxEnjoyment = new System.Windows.Forms.RichTextBox();
            this.lblActualDate = new System.Windows.Forms.Label();
            this.checkedListBoxChildren = new System.Windows.Forms.CheckedListBox();
            this.btnAddEnjoyment = new System.Windows.Forms.Button();
            this.checkedListBoxEnjoymentsCategories = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // richTextBoxEnjoyment
            // 
            this.richTextBoxEnjoyment.Location = new System.Drawing.Point(27, 304);
            this.richTextBoxEnjoyment.Name = "richTextBoxEnjoyment";
            this.richTextBoxEnjoyment.Size = new System.Drawing.Size(423, 210);
            this.richTextBoxEnjoyment.TabIndex = 0;
            this.richTextBoxEnjoyment.Text = "";
            // 
            // lblActualDate
            // 
            this.lblActualDate.AutoSize = true;
            this.lblActualDate.Location = new System.Drawing.Point(27, 47);
            this.lblActualDate.Name = "lblActualDate";
            this.lblActualDate.Size = new System.Drawing.Size(41, 20);
            this.lblActualDate.TabIndex = 1;
            this.lblActualDate.Text = "Date";
            // 
            // checkedListBoxChildren
            // 
            this.checkedListBoxChildren.BackColor = System.Drawing.SystemColors.HighlightText;
            this.checkedListBoxChildren.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxChildren.FormattingEnabled = true;
            this.checkedListBoxChildren.Location = new System.Drawing.Point(27, 94);
            this.checkedListBoxChildren.Name = "checkedListBoxChildren";
            this.checkedListBoxChildren.Size = new System.Drawing.Size(423, 88);
            this.checkedListBoxChildren.TabIndex = 2;
            // 
            // btnAddEnjoyment
            // 
            this.btnAddEnjoyment.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddEnjoyment.Location = new System.Drawing.Point(177, 538);
            this.btnAddEnjoyment.Name = "btnAddEnjoyment";
            this.btnAddEnjoyment.Size = new System.Drawing.Size(117, 29);
            this.btnAddEnjoyment.TabIndex = 3;
            this.btnAddEnjoyment.Text = "Přidej zážitek";
            this.btnAddEnjoyment.UseVisualStyleBackColor = true;
            this.btnAddEnjoyment.Click += new System.EventHandler(this.btnAddEnjoyment_Click);
            // 
            // checkedListBoxEnjoymentsCategories
            // 
            this.checkedListBoxEnjoymentsCategories.BackColor = System.Drawing.SystemColors.HighlightText;
            this.checkedListBoxEnjoymentsCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxEnjoymentsCategories.FormattingEnabled = true;
            this.checkedListBoxEnjoymentsCategories.Location = new System.Drawing.Point(27, 200);
            this.checkedListBoxEnjoymentsCategories.Name = "checkedListBoxEnjoymentsCategories";
            this.checkedListBoxEnjoymentsCategories.Size = new System.Drawing.Size(423, 88);
            this.checkedListBoxEnjoymentsCategories.TabIndex = 5;
            // 
            // AddEnjoyment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 594);
            this.Controls.Add(this.checkedListBoxEnjoymentsCategories);
            this.Controls.Add(this.btnAddEnjoyment);
            this.Controls.Add(this.checkedListBoxChildren);
            this.Controls.Add(this.lblActualDate);
            this.Controls.Add(this.richTextBoxEnjoyment);
            this.Name = "AddEnjoyment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEnjoyment_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxEnjoyment;
        private System.Windows.Forms.Label lblActualDate;
        private System.Windows.Forms.CheckedListBox checkedListBoxChildren;
        private System.Windows.Forms.Button btnAddEnjoyment;
        private System.Windows.Forms.CheckedListBox checkedListBoxEnjoymentsCategories;
    }
}