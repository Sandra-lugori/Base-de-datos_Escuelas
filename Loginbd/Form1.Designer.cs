namespace Loginbd
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.userTxtBox = new System.Windows.Forms.TextBox();
            this.pwTxtBox = new System.Windows.Forms.TextBox();
            this.butreg = new System.Windows.Forms.Button();
            this.butlog = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 49);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userTxtBox
            // 
            this.userTxtBox.Location = new System.Drawing.Point(275, 132);
            this.userTxtBox.Name = "userTxtBox";
            this.userTxtBox.Size = new System.Drawing.Size(216, 20);
            this.userTxtBox.TabIndex = 3;
            this.userTxtBox.TextChanged += new System.EventHandler(this.userTxtBox_TextChanged);
            // 
            // pwTxtBox
            // 
            this.pwTxtBox.Location = new System.Drawing.Point(275, 248);
            this.pwTxtBox.Name = "pwTxtBox";
            this.pwTxtBox.Size = new System.Drawing.Size(216, 20);
            this.pwTxtBox.TabIndex = 4;
            this.pwTxtBox.TextChanged += new System.EventHandler(this.pwTxtBox_TextChanged);
            // 
            // butreg
            // 
            this.butreg.BackColor = System.Drawing.Color.Crimson;
            this.butreg.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butreg.Location = new System.Drawing.Point(469, 321);
            this.butreg.Name = "butreg";
            this.butreg.Size = new System.Drawing.Size(213, 92);
            this.butreg.TabIndex = 5;
            this.butreg.Text = "Register";
            this.butreg.UseVisualStyleBackColor = false;
            this.butreg.Click += new System.EventHandler(this.butreg_Click);
            // 
            // butlog
            // 
            this.butlog.BackColor = System.Drawing.Color.Crimson;
            this.butlog.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butlog.Location = new System.Drawing.Point(84, 321);
            this.butlog.Name = "butlog";
            this.butlog.Size = new System.Drawing.Size(213, 92);
            this.butlog.TabIndex = 6;
            this.butlog.Text = "Login";
            this.butlog.UseVisualStyleBackColor = false;
            this.butlog.Click += new System.EventHandler(this.butlog_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 52);
            this.label2.TabIndex = 7;
            this.label2.Text = "User";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pw
            // 
            this.pw.AutoSize = true;
            this.pw.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw.Location = new System.Drawing.Point(287, 174);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(180, 52);
            this.pw.TabIndex = 1;
            this.pw.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butlog);
            this.Controls.Add(this.butreg);
            this.Controls.Add(this.pwTxtBox);
            this.Controls.Add(this.userTxtBox);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userTxtBox;
        private System.Windows.Forms.TextBox pwTxtBox;
        private System.Windows.Forms.Button butreg;
        private System.Windows.Forms.Button butlog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pw;
    }
}

