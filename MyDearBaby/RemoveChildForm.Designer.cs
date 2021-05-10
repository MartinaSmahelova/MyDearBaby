
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
            this.checkedListBoxChildren = new System.Windows.Forms.CheckedListBox();
            this.btnRemove = new MyDearBaby.RoundButton();
            this.SuspendLayout();
            // 
            // checkedListBoxChildren
            // 
            this.checkedListBoxChildren.FormattingEnabled = true;
            this.checkedListBoxChildren.Location = new System.Drawing.Point(24, 27);
            this.checkedListBoxChildren.Name = "checkedListBoxChildren";
            this.checkedListBoxChildren.Size = new System.Drawing.Size(386, 136);
            this.checkedListBoxChildren.TabIndex = 1;
            this.checkedListBoxChildren.Validating += new System.ComponentModel.CancelEventHandler(this.checkedListBoxChildren_Validating);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(181, 169);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(71, 69);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Odstraň";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // RemoveChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 246);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.checkedListBoxChildren);
            this.Name = "RemoveChildForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBoxChildren;
        private RoundButton btnRemove;
    }
}