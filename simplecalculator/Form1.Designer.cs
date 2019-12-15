namespace simplecalculator
{
    partial class Form1
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
            this.exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.txtB2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnT = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCa = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.txtBS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = global::simplecalculator.Properties.Resources.exit;
            this.exit.Location = new System.Drawing.Point(221, 11);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(32, 32);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exit.TabIndex = 0;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "1.Number";
            // 
            // txtB1
            // 
            this.txtB1.Location = new System.Drawing.Point(114, 59);
            this.txtB1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(114, 29);
            this.txtB1.TabIndex = 0;
            this.txtB1.TextChanged += new System.EventHandler(this.txtB1_TextChanged);
            this.txtB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB1_KeyPress);
            // 
            // txtB2
            // 
            this.txtB2.Location = new System.Drawing.Point(114, 95);
            this.txtB2.Margin = new System.Windows.Forms.Padding(2);
            this.txtB2.Name = "txtB2";
            this.txtB2.Size = new System.Drawing.Size(114, 29);
            this.txtB2.TabIndex = 1;
            this.txtB2.TextChanged += new System.EventHandler(this.txtB2_TextChanged);
            this.txtB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "2.Number";
            // 
            // btnT
            // 
            this.btnT.ForeColor = System.Drawing.Color.Black;
            this.btnT.Location = new System.Drawing.Point(30, 139);
            this.btnT.Margin = new System.Windows.Forms.Padding(10);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(40, 35);
            this.btnT.TabIndex = 2;
            this.btnT.Text = "+";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnC
            // 
            this.btnC.ForeColor = System.Drawing.Color.Black;
            this.btnC.Location = new System.Drawing.Point(80, 139);
            this.btnC.Margin = new System.Windows.Forms.Padding(10);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(40, 35);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "-";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCa
            // 
            this.btnCa.ForeColor = System.Drawing.Color.Black;
            this.btnCa.Location = new System.Drawing.Point(133, 139);
            this.btnCa.Margin = new System.Windows.Forms.Padding(10);
            this.btnCa.Name = "btnCa";
            this.btnCa.Size = new System.Drawing.Size(40, 35);
            this.btnCa.TabIndex = 4;
            this.btnCa.Text = "*";
            this.btnCa.UseVisualStyleBackColor = true;
            this.btnCa.Click += new System.EventHandler(this.btnCa_Click);
            // 
            // btnB
            // 
            this.btnB.ForeColor = System.Drawing.Color.Black;
            this.btnB.Location = new System.Drawing.Point(188, 139);
            this.btnB.Margin = new System.Windows.Forms.Padding(10);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(40, 35);
            this.btnB.TabIndex = 5;
            this.btnB.Text = "/";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // txtBS
            // 
            this.txtBS.Location = new System.Drawing.Point(30, 186);
            this.txtBS.Margin = new System.Windows.Forms.Padding(2);
            this.txtBS.Name = "txtBS";
            this.txtBS.Size = new System.Drawing.Size(198, 29);
            this.txtBS.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "@yusufhan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(262, 225);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBS);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnCa);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.txtB2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Font = new System.Drawing.Font("Arial", 14F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.TextBox txtB2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCa;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.TextBox txtBS;
        private System.Windows.Forms.Label label3;
    }
}

