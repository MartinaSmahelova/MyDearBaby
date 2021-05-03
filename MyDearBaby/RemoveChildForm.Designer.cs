
namespace MyDearBaby
{
    partial class RemoveChildForm
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.checkedListBoxChildren = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRemove.Location = new System.Drawing.Point(196, 168);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 29);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Odstraň";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // checkedListBoxChildren
            // 
            this.checkedListBoxChildren.FormattingEnabled = true;
            this.checkedListBoxChildren.Location = new System.Drawing.Point(91, 40);
            this.checkedListBoxChildren.Name = "checkedListBoxChildren";
            this.checkedListBoxChildren.Size = new System.Drawing.Size(296, 92);
            this.checkedListBoxChildren.TabIndex = 1;
            // 
            // RemoveChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 224);
            this.Controls.Add(this.checkedListBoxChildren);
            this.Controls.Add(this.btnRemove);
            this.Name = "RemoveChildForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RemoveChildForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.CheckedListBox checkedListBoxChildren;
    }
}