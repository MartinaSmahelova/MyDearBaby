
namespace MyDearBaby
{
    partial class AddEnjoymentCategoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewEnjoymentsCategories = new System.Windows.Forms.ListView();
            this.btnAddCategory = new MyDearBaby.RoundButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Momentálně máte tyto kategorie:";
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Location = new System.Drawing.Point(29, 210);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.Size = new System.Drawing.Size(426, 27);
            this.tbCategoryName.TabIndex = 2;
            this.tbCategoryName.TextChanged += new System.EventHandler(this.tbCategoryname_TextChanged);
            this.tbCategoryName.Validating += new System.ComponentModel.CancelEventHandler(this.tbCategoryName_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zedejte novou kategorii:";
            // 
            // listViewEnjoymentsCategories
            // 
            this.listViewEnjoymentsCategories.HideSelection = false;
            this.listViewEnjoymentsCategories.Location = new System.Drawing.Point(29, 53);
            this.listViewEnjoymentsCategories.Name = "listViewEnjoymentsCategories";
            this.listViewEnjoymentsCategories.Size = new System.Drawing.Size(426, 107);
            this.listViewEnjoymentsCategories.TabIndex = 3;
            this.listViewEnjoymentsCategories.UseCompatibleStateImageBehavior = false;
            this.listViewEnjoymentsCategories.View = System.Windows.Forms.View.List;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(207)))), ((int)(((byte)(177)))));
            this.btnAddCategory.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Location = new System.Drawing.Point(203, 254);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(67, 67);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "OK";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // AddEnjoymentCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 335);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.listViewEnjoymentsCategories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCategoryName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEnjoymentCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewEnjoymentsCategories;
        private RoundButton btnAddCategory;
    }
}