namespace Loginbd
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.userTxtBox = new System.Windows.Forms.TextBox();
            this.pw = new System.Windows.Forms.Label();
            this.pwTxtBox = new System.Windows.Forms.TextBox();
            this.butreg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 52);
            this.label2.TabIndex = 8;
            this.label2.Text = "User";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // userTxtBox
            // 
            this.userTxtBox.Location = new System.Drawing.Point(264, 125);
            this.userTxtBox.Name = "userTxtBox";
            this.userTxtBox.Size = new System.Drawing.Size(216, 20);
            this.userTxtBox.TabIndex = 9;
            this.userTxtBox.TextChanged += new System.EventHandler(this.userTxtBox_TextChanged);
            // 
            // pw
            // 
            this.pw.AutoSize = true;
            this.pw.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw.Location = new System.Drawing.Point(283, 168);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(180, 52);
            this.pw.TabIndex = 10;
            this.pw.Text = "Password";
            // 
            // pwTxtBox
            // 
            this.pwTxtBox.Location = new System.Drawing.Point(264, 232);
            this.pwTxtBox.Name = "pwTxtBox";
            this.pwTxtBox.Size = new System.Drawing.Size(216, 20);
            this.pwTxtBox.TabIndex = 11;
            this.pwTxtBox.TextChanged += new System.EventHandler(this.pwTxtBox_TextChanged);
            // 
            // butreg
            // 
            this.butreg.BackColor = System.Drawing.Color.Crimson;
            this.butreg.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butreg.Location = new System.Drawing.Point(264, 307);
            this.butreg.Name = "butreg";
            this.butreg.Size = new System.Drawing.Size(213, 92);
            this.butreg.TabIndex = 12;
            this.butreg.Text = "Register";
            this.butreg.UseVisualStyleBackColor = false;
            this.butreg.Click += new System.EventHandler(this.butreg_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butreg);
            this.Controls.Add(this.pwTxtBox);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.userTxtBox);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userTxtBox;
        private System.Windows.Forms.Label pw;
        private System.Windows.Forms.TextBox pwTxtBox;
        private System.Windows.Forms.Button butreg;
    }
}