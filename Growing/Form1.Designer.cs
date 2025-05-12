namespace Growing
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.firstJobTMR = new System.Windows.Forms.Timer(this.components);
            this.secondJobTMR = new System.Windows.Forms.Timer(this.components);
            this.thirdJobTMR = new System.Windows.Forms.Timer(this.components);
            this.forthJobTMR = new System.Windows.Forms.Timer(this.components);
            this.fifthJobTMR = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.moneyLBL = new System.Windows.Forms.Label();
            this.fifthJobBTN = new System.Windows.Forms.Button();
            this.forthJobBTN = new System.Windows.Forms.Button();
            this.thirdJobBTN = new System.Windows.Forms.Button();
            this.secondJobBTN = new System.Windows.Forms.Button();
            this.firstJobBTN = new System.Windows.Forms.Button();
            this.gameTMR = new System.Windows.Forms.Timer(this.components);
            this.btncheckTMR = new System.Windows.Forms.Timer(this.components);
            this.clickPNL = new System.Windows.Forms.Panel();
            this.thirdJobTimerLBL = new System.Windows.Forms.Label();
            this.fifthJobTimerLBL = new System.Windows.Forms.Label();
            this.forthJobTimerLBL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.secondJobTimerLBL = new System.Windows.Forms.Label();
            this.firstJobTimerLBL = new System.Windows.Forms.Label();
            this.updateCountdownTMR = new System.Windows.Forms.Timer(this.components);
            this.clickPNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "모은돈";
            // 
            // moneyLBL
            // 
            this.moneyLBL.AutoSize = true;
            this.moneyLBL.Location = new System.Drawing.Point(92, 14);
            this.moneyLBL.Name = "moneyLBL";
            this.moneyLBL.Size = new System.Drawing.Size(0, 21);
            this.moneyLBL.TabIndex = 1;
            // 
            // fifthJobBTN
            // 
            this.fifthJobBTN.Location = new System.Drawing.Point(33, 676);
            this.fifthJobBTN.Name = "fifthJobBTN";
            this.fifthJobBTN.Size = new System.Drawing.Size(242, 50);
            this.fifthJobBTN.TabIndex = 6;
            this.fifthJobBTN.Text = "건물주";
            this.fifthJobBTN.UseVisualStyleBackColor = true;
            this.fifthJobBTN.Click += new System.EventHandler(this.fifthJobBTN_Click);
            // 
            // forthJobBTN
            // 
            this.forthJobBTN.Location = new System.Drawing.Point(33, 598);
            this.forthJobBTN.Name = "forthJobBTN";
            this.forthJobBTN.Size = new System.Drawing.Size(242, 50);
            this.forthJobBTN.TabIndex = 7;
            this.forthJobBTN.Text = "공무원";
            this.forthJobBTN.UseVisualStyleBackColor = true;
            this.forthJobBTN.Click += new System.EventHandler(this.forthJobBTN_Click);
            // 
            // thirdJobBTN
            // 
            this.thirdJobBTN.Location = new System.Drawing.Point(33, 520);
            this.thirdJobBTN.Name = "thirdJobBTN";
            this.thirdJobBTN.Size = new System.Drawing.Size(242, 50);
            this.thirdJobBTN.TabIndex = 8;
            this.thirdJobBTN.Text = "편의점 알바";
            this.thirdJobBTN.UseVisualStyleBackColor = true;
            this.thirdJobBTN.Click += new System.EventHandler(this.thirdJobBTN_Click);
            // 
            // secondJobBTN
            // 
            this.secondJobBTN.Location = new System.Drawing.Point(33, 441);
            this.secondJobBTN.Name = "secondJobBTN";
            this.secondJobBTN.Size = new System.Drawing.Size(242, 50);
            this.secondJobBTN.TabIndex = 9;
            this.secondJobBTN.Text = "전단지 알바";
            this.secondJobBTN.UseVisualStyleBackColor = true;
            this.secondJobBTN.Click += new System.EventHandler(this.secondJobBTN_Click);
            // 
            // firstJobBTN
            // 
            this.firstJobBTN.Location = new System.Drawing.Point(33, 373);
            this.firstJobBTN.Name = "firstJobBTN";
            this.firstJobBTN.Size = new System.Drawing.Size(242, 50);
            this.firstJobBTN.TabIndex = 10;
            this.firstJobBTN.Text = "노숙자";
            this.firstJobBTN.UseVisualStyleBackColor = true;
            this.firstJobBTN.Click += new System.EventHandler(this.firstJobBTN_Click);
            // 
            // clickPNL
            // 
            this.clickPNL.Controls.Add(this.thirdJobTimerLBL);
            this.clickPNL.Controls.Add(this.fifthJobTimerLBL);
            this.clickPNL.Controls.Add(this.forthJobTimerLBL);
            this.clickPNL.Controls.Add(this.label4);
            this.clickPNL.Controls.Add(this.secondJobTimerLBL);
            this.clickPNL.Controls.Add(this.firstJobTimerLBL);
            this.clickPNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clickPNL.Location = new System.Drawing.Point(0, 0);
            this.clickPNL.Name = "clickPNL";
            this.clickPNL.Size = new System.Drawing.Size(1043, 783);
            this.clickPNL.TabIndex = 11;
            this.clickPNL.Click += new System.EventHandler(this.clickPNL_Click);
            // 
            // thirdJobTimerLBL
            // 
            this.thirdJobTimerLBL.AutoSize = true;
            this.thirdJobTimerLBL.Location = new System.Drawing.Point(281, 535);
            this.thirdJobTimerLBL.Name = "thirdJobTimerLBL";
            this.thirdJobTimerLBL.Size = new System.Drawing.Size(0, 21);
            this.thirdJobTimerLBL.TabIndex = 5;
            // 
            // fifthJobTimerLBL
            // 
            this.fifthJobTimerLBL.AutoSize = true;
            this.fifthJobTimerLBL.Location = new System.Drawing.Point(281, 691);
            this.fifthJobTimerLBL.Name = "fifthJobTimerLBL";
            this.fifthJobTimerLBL.Size = new System.Drawing.Size(0, 21);
            this.fifthJobTimerLBL.TabIndex = 4;
            // 
            // forthJobTimerLBL
            // 
            this.forthJobTimerLBL.AutoSize = true;
            this.forthJobTimerLBL.Location = new System.Drawing.Point(281, 613);
            this.forthJobTimerLBL.Name = "forthJobTimerLBL";
            this.forthJobTimerLBL.Size = new System.Drawing.Size(0, 21);
            this.forthJobTimerLBL.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // secondJobTimerLBL
            // 
            this.secondJobTimerLBL.AutoSize = true;
            this.secondJobTimerLBL.Location = new System.Drawing.Point(281, 456);
            this.secondJobTimerLBL.Name = "secondJobTimerLBL";
            this.secondJobTimerLBL.Size = new System.Drawing.Size(0, 21);
            this.secondJobTimerLBL.TabIndex = 1;
            // 
            // firstJobTimerLBL
            // 
            this.firstJobTimerLBL.AutoSize = true;
            this.firstJobTimerLBL.Location = new System.Drawing.Point(281, 388);
            this.firstJobTimerLBL.Name = "firstJobTimerLBL";
            this.firstJobTimerLBL.Size = new System.Drawing.Size(0, 21);
            this.firstJobTimerLBL.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 783);
            this.Controls.Add(this.firstJobBTN);
            this.Controls.Add(this.secondJobBTN);
            this.Controls.Add(this.thirdJobBTN);
            this.Controls.Add(this.forthJobBTN);
            this.Controls.Add(this.fifthJobBTN);
            this.Controls.Add(this.moneyLBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clickPNL);
            this.Name = "Form1";
            this.Text = "Growing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.clickPNL.ResumeLayout(false);
            this.clickPNL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer firstJobTMR;
        private System.Windows.Forms.Timer secondJobTMR;
        private System.Windows.Forms.Timer thirdJobTMR;
        private System.Windows.Forms.Timer forthJobTMR;
        private System.Windows.Forms.Timer fifthJobTMR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label moneyLBL;
        private System.Windows.Forms.Button fifthJobBTN;
        private System.Windows.Forms.Button forthJobBTN;
        private System.Windows.Forms.Button thirdJobBTN;
        private System.Windows.Forms.Button secondJobBTN;
        private System.Windows.Forms.Button firstJobBTN;
        private System.Windows.Forms.Timer gameTMR;
        private System.Windows.Forms.Timer btncheckTMR;
        private System.Windows.Forms.Panel clickPNL;
        private System.Windows.Forms.Label thirdJobTimerLBL;
        private System.Windows.Forms.Label fifthJobTimerLBL;
        private System.Windows.Forms.Label forthJobTimerLBL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label secondJobTimerLBL;
        private System.Windows.Forms.Label firstJobTimerLBL;
        private System.Windows.Forms.Timer updateCountdownTMR;
    }
}

