
namespace MyDearBaby
{
    partial class MainForm
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
            this.btn_addChild = new System.Windows.Forms.Button();
            this.btn_addEnjoyment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addChild
            // 
            this.btn_addChild.Location = new System.Drawing.Point(87, 73);
            this.btn_addChild.Name = "btn_addChild";
            this.btn_addChild.Size = new System.Drawing.Size(206, 29);
            this.btn_addChild.TabIndex = 0;
            this.btn_addChild.Text = "Přidat díte do aplikace";
            this.btn_addChild.UseVisualStyleBackColor = true;
            this.btn_addChild.Click += new System.EventHandler(this.btn_addChild_Click);
            // 
            // btn_addEnjoyment
            // 
            this.btn_addEnjoyment.Location = new System.Drawing.Point(87, 190);
            this.btn_addEnjoyment.Name = "btn_addEnjoyment";
            this.btn_addEnjoyment.Size = new System.Drawing.Size(206, 42);
            this.btn_addEnjoyment.TabIndex = 1;
            this.btn_addEnjoyment.Text = "Pridat zážitek";
            this.btn_addEnjoyment.UseVisualStyleBackColor = true;
            this.btn_addEnjoyment.Click += new System.EventHandler(this.btn_addEnjoyment_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_addEnjoyment);
            this.Controls.Add(this.btn_addChild);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addChild;
        private System.Windows.Forms.Button btn_addEnjoyment;
    }
}

