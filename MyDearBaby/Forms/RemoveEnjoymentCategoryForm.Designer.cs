
namespace MyDearBaby
{
    partial class RemoveEnjoymentCategoryForm
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
            this.checkedListBoxCategories = new System.Windows.Forms.CheckedListBox();
            this.btnRemove = new MyDearBaby.RoundButton();
            this.SuspendLayout();
            // 
            // checkedListBoxCategories
            // 
            this.checkedListBoxCategories.FormattingEnabled = true;
            this.checkedListBoxCategories.Location = new System.Drawing.Point(26, 26);
            this.checkedListBoxCategories.Name = "checkedListBoxCategories";
            this.checkedListBoxCategories.Size = new System.Drawing.Size(426, 158);
            this.checkedListBoxCategories.TabIndex = 1;
            this.checkedListBoxCategories.Validating += new System.ComponentModel.CancelEventHandler(this.checkedListBoxCategories_Validating);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(171)))), ((int)(((byte)(135)))));
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(197, 208);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(71, 69);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Odstraň";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // RemoveEnjoymentCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 289);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.checkedListBoxCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RemoveEnjoymentCategoryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxCategories;
        private RoundButton btnRemove;
    }
}