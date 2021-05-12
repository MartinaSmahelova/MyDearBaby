
namespace MyDearBaby
{
    partial class MyDearChildMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyDearChildMainForm));
            this.roundButton1 = new MyDearBaby.RoundButton();
            this.btn_addEnjoyment = new MyDearBaby.RoundButton();
            this.tnEnjoyments = new MyDearBaby.RoundButton();
            this.btnAddChild = new MyDearBaby.RoundButton();
            this.btnRemoveEnjoymentCategory = new MyDearBaby.RoundButton();
            this.btnRemoveChild = new MyDearBaby.RoundButton();
            this.btnX = new MyDearBaby.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(207)))), ((int)(((byte)(177)))));
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Location = new System.Drawing.Point(101, 190);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(91, 87);
            this.roundButton1.TabIndex = 6;
            this.roundButton1.Text = "Pridej kategorii zážitků";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.btnAddEnjoymentCategory_Click);
            // 
            // btn_addEnjoyment
            // 
            this.btn_addEnjoyment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(240)))), ((int)(((byte)(89)))));
            this.btn_addEnjoyment.FlatAppearance.BorderSize = 0;
            this.btn_addEnjoyment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addEnjoyment.Location = new System.Drawing.Point(266, 310);
            this.btn_addEnjoyment.Name = "btn_addEnjoyment";
            this.btn_addEnjoyment.Size = new System.Drawing.Size(82, 76);
            this.btn_addEnjoyment.TabIndex = 7;
            this.btn_addEnjoyment.Text = "Pridej zážitek";
            this.btn_addEnjoyment.UseVisualStyleBackColor = false;
            this.btn_addEnjoyment.Click += new System.EventHandler(this.btnAddEnjoyment_Click);
            // 
            // tnEnjoyments
            // 
            this.tnEnjoyments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.tnEnjoyments.FlatAppearance.BorderSize = 0;
            this.tnEnjoyments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tnEnjoyments.Location = new System.Drawing.Point(449, 240);
            this.tnEnjoyments.Name = "tnEnjoyments";
            this.tnEnjoyments.Size = new System.Drawing.Size(78, 78);
            this.tnEnjoyments.TabIndex = 8;
            this.tnEnjoyments.Text = "Zážitky";
            this.tnEnjoyments.UseVisualStyleBackColor = false;
            this.tnEnjoyments.Click += new System.EventHandler(this.btnEnjoyments_Click);
            // 
            // btnAddChild
            // 
            this.btnAddChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(175)))), ((int)(((byte)(248)))));
            this.btnAddChild.FlatAppearance.BorderSize = 0;
            this.btnAddChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddChild.Location = new System.Drawing.Point(21, 105);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(83, 79);
            this.btnAddChild.TabIndex = 9;
            this.btnAddChild.Text = "Pridej profil dítěte";
            this.btnAddChild.UseVisualStyleBackColor = false;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // btnRemoveEnjoymentCategory
            // 
            this.btnRemoveEnjoymentCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(171)))), ((int)(((byte)(135)))));
            this.btnRemoveEnjoymentCategory.FlatAppearance.BorderSize = 0;
            this.btnRemoveEnjoymentCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveEnjoymentCategory.Location = new System.Drawing.Point(21, 310);
            this.btnRemoveEnjoymentCategory.Name = "btnRemoveEnjoymentCategory";
            this.btnRemoveEnjoymentCategory.Size = new System.Drawing.Size(100, 98);
            this.btnRemoveEnjoymentCategory.TabIndex = 10;
            this.btnRemoveEnjoymentCategory.Text = "Odeber kategorii zážitků";
            this.btnRemoveEnjoymentCategory.UseVisualStyleBackColor = false;
            this.btnRemoveEnjoymentCategory.Click += new System.EventHandler(this.btnRemoveEnjoymentCategory_Click);
            // 
            // btnRemoveChild
            // 
            this.btnRemoveChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(249)))));
            this.btnRemoveChild.FlatAppearance.BorderSize = 0;
            this.btnRemoveChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveChild.Location = new System.Drawing.Point(491, 83);
            this.btnRemoveChild.Name = "btnRemoveChild";
            this.btnRemoveChild.Size = new System.Drawing.Size(86, 81);
            this.btnRemoveChild.TabIndex = 11;
            this.btnRemoveChild.Text = "Odeber profil dítěte";
            this.btnRemoveChild.UseVisualStyleBackColor = false;
            this.btnRemoveChild.Click += new System.EventHandler(this.btnRemoveChild_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Location = new System.Drawing.Point(557, 12);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(40, 38);
            this.btnX.TabIndex = 12;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(414, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "MyDearBaby";
            // 
            // MyDearChildMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(609, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnRemoveChild);
            this.Controls.Add(this.btnRemoveEnjoymentCategory);
            this.Controls.Add(this.btnAddChild);
            this.Controls.Add(this.tnEnjoyments);
            this.Controls.Add(this.btn_addEnjoyment);
            this.Controls.Add(this.roundButton1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "MyDearChildMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyDearChildMainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundButton roundButton1;
        private RoundButton btn_addEnjoyment;
        private RoundButton tnEnjoyments;
        private RoundButton btnAddChild;
        private RoundButton btnRemoveEnjoymentCategory;
        private RoundButton btnRemoveChild;
        private RoundButton btnX;
        private System.Windows.Forms.Label label1;
    }
}

