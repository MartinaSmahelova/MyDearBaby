
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
            this.butRemoveChild = new System.Windows.Forms.Button();
            this.btnAddEnjoymentCategory = new System.Windows.Forms.Button();
            this.btnRemoveEnjoymentCategory = new System.Windows.Forms.Button();
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
            // butRemoveChild
            // 
            this.butRemoveChild.Location = new System.Drawing.Point(87, 121);
            this.butRemoveChild.Name = "butRemoveChild";
            this.butRemoveChild.Size = new System.Drawing.Size(206, 29);
            this.butRemoveChild.TabIndex = 2;
            this.butRemoveChild.Text = "Odeber dítě z aplikace";
            this.butRemoveChild.UseVisualStyleBackColor = true;
            this.butRemoveChild.Click += new System.EventHandler(this.butRemoveChild_Click);
            // 
            // btnAddEnjoymentCategory
            // 
            this.btnAddEnjoymentCategory.Location = new System.Drawing.Point(87, 272);
            this.btnAddEnjoymentCategory.Name = "btnAddEnjoymentCategory";
            this.btnAddEnjoymentCategory.Size = new System.Drawing.Size(206, 29);
            this.btnAddEnjoymentCategory.TabIndex = 3;
            this.btnAddEnjoymentCategory.Text = "Přidej kategórii zážitků";
            this.btnAddEnjoymentCategory.UseVisualStyleBackColor = true;
            this.btnAddEnjoymentCategory.Click += new System.EventHandler(this.btnAddEnjoymentCategory_Click);
            // 
            // btnRemoveEnjoymentCategory
            // 
            this.btnRemoveEnjoymentCategory.Location = new System.Drawing.Point(87, 323);
            this.btnRemoveEnjoymentCategory.Name = "btnRemoveEnjoymentCategory";
            this.btnRemoveEnjoymentCategory.Size = new System.Drawing.Size(206, 29);
            this.btnRemoveEnjoymentCategory.TabIndex = 4;
            this.btnRemoveEnjoymentCategory.Text = "Odeber kategórii zážitků";
            this.btnRemoveEnjoymentCategory.UseVisualStyleBackColor = true;
            this.btnRemoveEnjoymentCategory.Click += new System.EventHandler(this.btnRemoveEnjoymentCategory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveEnjoymentCategory);
            this.Controls.Add(this.btnAddEnjoymentCategory);
            this.Controls.Add(this.butRemoveChild);
            this.Controls.Add(this.btn_addEnjoyment);
            this.Controls.Add(this.btn_addChild);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addChild;
        private System.Windows.Forms.Button btn_addEnjoyment;
        private System.Windows.Forms.Button butRemoveChild;
        private System.Windows.Forms.Button btnAddEnjoymentCategory;
        private System.Windows.Forms.Button btnRemoveEnjoymentCategory;
    }
}

