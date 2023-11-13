namespace MovieReservation
{
    partial class MovieLoginForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.CLMlogo = new System.Windows.Forms.Label();
            this.IDlb = new System.Windows.Forms.Label();
            this.PASSlb = new System.Windows.Forms.Label();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.PASStxt = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CLMlogo
            // 
            this.CLMlogo.AutoSize = true;
            this.CLMlogo.Font = new System.Drawing.Font("굴림", 30F);
            this.CLMlogo.Location = new System.Drawing.Point(346, 77);
            this.CLMlogo.Name = "CLMlogo";
            this.CLMlogo.Size = new System.Drawing.Size(101, 40);
            this.CLMlogo.TabIndex = 0;
            this.CLMlogo.Text = "CLM";
            // 
            // IDlb
            // 
            this.IDlb.AutoSize = true;
            this.IDlb.Location = new System.Drawing.Point(309, 208);
            this.IDlb.Name = "IDlb";
            this.IDlb.Size = new System.Drawing.Size(16, 12);
            this.IDlb.TabIndex = 1;
            this.IDlb.Text = "ID";
            // 
            // PASSlb
            // 
            this.PASSlb.AutoSize = true;
            this.PASSlb.Location = new System.Drawing.Point(309, 257);
            this.PASSlb.Name = "PASSlb";
            this.PASSlb.Size = new System.Drawing.Size(37, 12);
            this.PASSlb.TabIndex = 2;
            this.PASSlb.Text = "PASS";
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(353, 205);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(100, 21);
            this.IDtxt.TabIndex = 3;
            // 
            // PASStxt
            // 
            this.PASStxt.Location = new System.Drawing.Point(353, 254);
            this.PASStxt.Name = "PASStxt";
            this.PASStxt.Size = new System.Drawing.Size(100, 21);
            this.PASStxt.TabIndex = 4;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(311, 353);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(405, 353);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(75, 23);
            this.RegisterBtn.TabIndex = 6;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            // 
            // MovieLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PASStxt);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.PASSlb);
            this.Controls.Add(this.IDlb);
            this.Controls.Add(this.CLMlogo);
            this.Name = "MovieLoginForm";
            this.Text = "MovieReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CLMlogo;
        private System.Windows.Forms.Label IDlb;
        private System.Windows.Forms.Label PASSlb;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.TextBox PASStxt;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button RegisterBtn;
    }
}

