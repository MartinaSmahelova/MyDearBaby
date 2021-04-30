
using System.Windows.Forms;

namespace MyDearBaby
{
    partial class AddChildForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.tbChildName = new System.Windows.Forms.TextBox();
            this.rbGirl = new System.Windows.Forms.RadioButton();
            this.rbBoy = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.groupBoxRadioButtons = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(164, 332);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 29);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbChildName
            // 
            this.tbChildName.Location = new System.Drawing.Point(34, 69);
            this.tbChildName.Name = "tbChildName";
            this.tbChildName.Size = new System.Drawing.Size(174, 27);
            this.tbChildName.TabIndex = 1;
            this.tbChildName.TextChanged += new System.EventHandler(this.tbChildName_TextChanged);
            this.tbChildName.Validating += new System.ComponentModel.CancelEventHandler(this.tbChildName_Validating);
            // 
            // rbGirl
            // 
            this.rbGirl.AutoSize = true;
            this.rbGirl.Location = new System.Drawing.Point(6, 21);
            this.rbGirl.Name = "rbGirl";
            this.rbGirl.Size = new System.Drawing.Size(69, 24);
            this.rbGirl.TabIndex = 2;
            this.rbGirl.TabStop = true;
            this.rbGirl.Text = "Holka\r\n";
            this.rbGirl.UseVisualStyleBackColor = true;
            this.rbGirl.CheckedChanged += new System.EventHandler(this.rbGirl_CheckedChanged);
            // 
            // rbBoy
            // 
            this.rbBoy.AutoSize = true;
            this.rbBoy.Location = new System.Drawing.Point(6, 51);
            this.rbBoy.Name = "rbBoy";
            this.rbBoy.Size = new System.Drawing.Size(58, 24);
            this.rbBoy.TabIndex = 3;
            this.rbBoy.TabStop = true;
            this.rbBoy.Text = "Kluk\r\n";
            this.rbBoy.UseVisualStyleBackColor = true;
            this.rbBoy.CheckedChanged += new System.EventHandler(this.rbBoy_CheckedChanged);
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
            this.dateTimePickerDateOfBirth.ValueChanged += new System.EventHandler(this.dateTimePickerDateOfBirth_ValueChanged);
            this.dateTimePickerDateOfBirth.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerDateOfBirth_Validating);
            // 
            // groupBoxRadioButtons
            // 
            this.groupBoxRadioButtons.Controls.Add(this.rbBoy);
            this.groupBoxRadioButtons.Controls.Add(this.rbGirl);
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
            // AddChildForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 395);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.groupBoxRadioButtons);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbChildName);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddChildForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddChild_FormClosing);
            this.groupBoxRadioButtons.ResumeLayout(false);
            this.groupBoxRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbChildName;
        private System.Windows.Forms.RadioButton rbGirl;
        private System.Windows.Forms.RadioButton rbBoy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DateTimePicker dateTimePickerDateOfBirth;
        private GroupBox groupBoxRadioButtons;
        private MaskedTextBox maskedTextBox1;
    }
}