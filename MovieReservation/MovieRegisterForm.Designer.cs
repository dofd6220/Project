namespace MovieReservation
{
    partial class MovieRegisterForm
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
            this.Logolb = new System.Windows.Forms.Label();
            this.IDlb = new System.Windows.Forms.Label();
            this.PASSlb = new System.Windows.Forms.Label();
            this.PASSexlb = new System.Windows.Forms.Label();
            this.Namelb = new System.Windows.Forms.Label();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.PASStxt = new System.Windows.Forms.TextBox();
            this.PASSextxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Registerbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logolb
            // 
            this.Logolb.AutoSize = true;
            this.Logolb.Font = new System.Drawing.Font("굴림", 30F);
            this.Logolb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Logolb.Location = new System.Drawing.Point(350, 37);
            this.Logolb.Name = "Logolb";
            this.Logolb.Size = new System.Drawing.Size(101, 40);
            this.Logolb.TabIndex = 0;
            this.Logolb.Text = "CLM";
            // 
            // IDlb
            // 
            this.IDlb.AutoSize = true;
            this.IDlb.Location = new System.Drawing.Point(215, 136);
            this.IDlb.Name = "IDlb";
            this.IDlb.Size = new System.Drawing.Size(41, 12);
            this.IDlb.TabIndex = 1;
            this.IDlb.Text = "아이디";
            // 
            // PASSlb
            // 
            this.PASSlb.AutoSize = true;
            this.PASSlb.Location = new System.Drawing.Point(215, 175);
            this.PASSlb.Name = "PASSlb";
            this.PASSlb.Size = new System.Drawing.Size(53, 12);
            this.PASSlb.TabIndex = 2;
            this.PASSlb.Text = "비밀번호";
            // 
            // PASSexlb
            // 
            this.PASSexlb.AutoSize = true;
            this.PASSexlb.Location = new System.Drawing.Point(215, 214);
            this.PASSexlb.Name = "PASSexlb";
            this.PASSexlb.Size = new System.Drawing.Size(93, 12);
            this.PASSexlb.TabIndex = 3;
            this.PASSexlb.Text = "비밀번호 재확인";
            // 
            // Namelb
            // 
            this.Namelb.AutoSize = true;
            this.Namelb.Location = new System.Drawing.Point(215, 253);
            this.Namelb.Name = "Namelb";
            this.Namelb.Size = new System.Drawing.Size(29, 12);
            this.Namelb.TabIndex = 4;
            this.Namelb.Text = "이름";
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(315, 133);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(168, 21);
            this.IDtxt.TabIndex = 9;
            // 
            // PASStxt
            // 
            this.PASStxt.Location = new System.Drawing.Point(315, 171);
            this.PASStxt.Name = "PASStxt";
            this.PASStxt.Size = new System.Drawing.Size(168, 21);
            this.PASStxt.TabIndex = 10;
            // 
            // PASSextxt
            // 
            this.PASSextxt.Location = new System.Drawing.Point(315, 209);
            this.PASSextxt.Name = "PASSextxt";
            this.PASSextxt.Size = new System.Drawing.Size(168, 21);
            this.PASSextxt.TabIndex = 11;
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(315, 247);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(168, 21);
            this.Nametxt.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Registerbtn);
            this.panel1.Controls.Add(this.PASSexlb);
            this.panel1.Controls.Add(this.IDlb);
            this.panel1.Controls.Add(this.Logolb);
            this.panel1.Controls.Add(this.PASSlb);
            this.panel1.Controls.Add(this.Namelb);
            this.panel1.Controls.Add(this.IDtxt);
            this.panel1.Controls.Add(this.PASStxt);
            this.panel1.Controls.Add(this.PASSextxt);
            this.panel1.Controls.Add(this.Nametxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 414);
            this.panel1.TabIndex = 17;
            // 
            // Registerbtn
            // 
            this.Registerbtn.Location = new System.Drawing.Point(357, 298);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(75, 23);
            this.Registerbtn.TabIndex = 17;
            this.Registerbtn.Text = "회원가입";
            this.Registerbtn.UseVisualStyleBackColor = true;
            // 
            // MovieRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 414);
            this.Controls.Add(this.panel1);
            this.Name = "MovieRegisterForm";
            this.Text = "MovieRegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Logolb;
        private System.Windows.Forms.Label IDlb;
        private System.Windows.Forms.Label PASSlb;
        private System.Windows.Forms.Label PASSexlb;
        private System.Windows.Forms.Label Namelb;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.TextBox PASStxt;
        private System.Windows.Forms.TextBox PASSextxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Registerbtn;
    }
}