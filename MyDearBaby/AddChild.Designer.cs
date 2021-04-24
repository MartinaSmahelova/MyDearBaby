
using System.Windows.Forms;

namespace MyDearBaby
{
    partial class AddChild
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
            this.components = new System.ComponentModel.Container();
            this.btn_OK = new System.Windows.Forms.Button();
            this.tb_childName = new System.Windows.Forms.TextBox();
            this.rb_girl = new System.Windows.Forms.RadioButton();
            this.rb_boy = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_dayOFBirth = new System.Windows.Forms.TextBox();
            this.tb_monthOfBirth = new System.Windows.Forms.TextBox();
            this.tb_yearOfBirth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(164, 332);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(94, 29);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // tb_childName
            // 
            this.tb_childName.Location = new System.Drawing.Point(34, 69);
            this.tb_childName.Name = "tb_childName";
            this.tb_childName.Size = new System.Drawing.Size(174, 27);
            this.tb_childName.TabIndex = 1;
            this.tb_childName.TextChanged += new System.EventHandler(this.tb_childName_TextChanged);
            // 
            // rb_girl
            // 
            this.rb_girl.AutoSize = true;
            this.rb_girl.Location = new System.Drawing.Point(34, 136);
            this.rb_girl.Name = "rb_girl";
            this.rb_girl.Size = new System.Drawing.Size(69, 24);
            this.rb_girl.TabIndex = 2;
            this.rb_girl.TabStop = true;
            this.rb_girl.Text = "Holka\r\n";
            this.rb_girl.UseVisualStyleBackColor = true;
            this.rb_girl.CheckedChanged += new System.EventHandler(this.rb_girl_CheckedChanged);
            // 
            // rb_boy
            // 
            this.rb_boy.AutoSize = true;
            this.rb_boy.Location = new System.Drawing.Point(34, 166);
            this.rb_boy.Name = "rb_boy";
            this.rb_boy.Size = new System.Drawing.Size(58, 24);
            this.rb_boy.TabIndex = 3;
            this.rb_boy.TabStop = true;
            this.rb_boy.Text = "Kluk\r\n";
            this.rb_boy.UseVisualStyleBackColor = true;
            this.rb_boy.CheckedChanged += new System.EventHandler(this.rb_boy_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jméno Vašeho dítěte\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pohlaví ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum narození";
            // 
            // tb_dayOFBirth
            // 
            this.tb_dayOFBirth.Location = new System.Drawing.Point(34, 255);
            this.tb_dayOFBirth.Name = "tb_dayOFBirth";
            this.tb_dayOFBirth.Size = new System.Drawing.Size(58, 27);
            this.tb_dayOFBirth.TabIndex = 7;
            // 
            // tb_monthOfBirth
            // 
            this.tb_monthOfBirth.Location = new System.Drawing.Point(98, 255);
            this.tb_monthOfBirth.Name = "tb_monthOfBirth";
            this.tb_monthOfBirth.Size = new System.Drawing.Size(58, 27);
            this.tb_monthOfBirth.TabIndex = 8;
            // 
            // tb_yearOfBirth
            // 
            this.tb_yearOfBirth.Location = new System.Drawing.Point(162, 255);
            this.tb_yearOfBirth.Name = "tb_yearOfBirth";
            this.tb_yearOfBirth.Size = new System.Drawing.Size(94, 27);
            this.tb_yearOfBirth.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Měsíc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Den";
            // 
            // dateTimePicker_dateOfBirth
            // 
            this.dateTimePicker_dateOfBirth.Location = new System.Drawing.Point(34, 288);
            this.dateTimePicker_dateOfBirth.Name = "dateTimePicker_dateOfBirth";
            this.dateTimePicker_dateOfBirth.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker_dateOfBirth.TabIndex = 13;
            this.dateTimePicker_dateOfBirth.ValueChanged += new System.EventHandler(this.dateTimePicker_dateOfBirth_ValueChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataMember = "";
            // 
            // AddChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 395);
            this.Controls.Add(this.dateTimePicker_dateOfBirth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_yearOfBirth);
            this.Controls.Add(this.tb_monthOfBirth);
            this.Controls.Add(this.tb_dayOFBirth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_boy);
            this.Controls.Add(this.rb_girl);
            this.Controls.Add(this.tb_childName);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddChild";
            this.Text = "PopupFormChildInfo";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox tb_childName;
        private System.Windows.Forms.RadioButton rb_girl;
        private System.Windows.Forms.RadioButton rb_boy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_dayOFBirth;
        private System.Windows.Forms.TextBox tb_monthOfBirth;
        private System.Windows.Forms.TextBox tb_yearOfBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateOfBirth;
        private ErrorProvider errorProvider1;
    }
}