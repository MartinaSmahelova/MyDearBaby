
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.tb_childName = new System.Windows.Forms.TextBox();
            this.rb_girl = new System.Windows.Forms.RadioButton();
            this.rb_boy = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.groupBoxRadioButtons = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(164, 332);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(94, 29);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // tb_childName
            // 
            this.tb_childName.Location = new System.Drawing.Point(34, 69);
            this.tb_childName.Name = "tb_childName";
            this.tb_childName.Size = new System.Drawing.Size(174, 27);
            this.tb_childName.TabIndex = 1;
            this.tb_childName.TextChanged += new System.EventHandler(this.tb_childName_TextChanged);
            this.tb_childName.Validating += new System.ComponentModel.CancelEventHandler(this.tb_childName_Validating);
            // 
            // rb_girl
            // 
            this.rb_girl.AutoSize = true;
            this.rb_girl.Location = new System.Drawing.Point(6, 21);
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
            this.rb_boy.Location = new System.Drawing.Point(6, 51);
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
            this.label2.Location = new System.Drawing.Point(34, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pohlaví ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum narození";
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.CustomFormat = "dd. MM. yyyy";
            this.dateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(34, 271);
            this.dateTimePickerDateOfBirth.MinDate = new System.DateTime(1921, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(146, 27);
            this.dateTimePickerDateOfBirth.TabIndex = 13;
            this.dateTimePickerDateOfBirth.Value = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            this.dateTimePickerDateOfBirth.ValueChanged += new System.EventHandler(this.dateTimePicker_dateOfBirth_ValueChanged);
            this.dateTimePickerDateOfBirth.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerDateOfBirth_Validating);
            // 
            // groupBoxRadioButtons
            // 
            this.groupBoxRadioButtons.Controls.Add(this.rb_boy);
            this.groupBoxRadioButtons.Controls.Add(this.rb_girl);
            this.groupBoxRadioButtons.Location = new System.Drawing.Point(34, 147);
            this.groupBoxRadioButtons.Name = "groupBoxRadioButtons";
            this.groupBoxRadioButtons.Size = new System.Drawing.Size(212, 81);
            this.groupBoxRadioButtons.TabIndex = 14;
            this.groupBoxRadioButtons.TabStop = false;
            this.groupBoxRadioButtons.Validating += new System.ComponentModel.CancelEventHandler(this.groupBoxRadioButtons_Validating);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(237, 69);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(125, 27);
            this.maskedTextBox1.TabIndex = 15;
            // 
            // AddChild
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 395);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.groupBoxRadioButtons);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_childName);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddChild";
            this.Text = "PopupFormChildInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddChild_FormClosing);
            this.groupBoxRadioButtons.ResumeLayout(false);
            this.groupBoxRadioButtons.PerformLayout();
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
        private DateTimePicker dateTimePickerDateOfBirth;
        private GroupBox groupBoxRadioButtons;
        private MaskedTextBox maskedTextBox1;
    }
}