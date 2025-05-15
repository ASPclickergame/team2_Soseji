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
            this.btncheckTMR = new System.Windows.Forms.Timer(this.components);
            this.clickPNL = new System.Windows.Forms.Panel();
            this.jusikBtn = new System.Windows.Forms.Button();
            this.levelupBTN = new System.Windows.Forms.Button();
            this.expCostLBL = new System.Windows.Forms.Label();
            this.expLBL = new System.Windows.Forms.Label();
            this.levelLBL = new System.Windows.Forms.Label();
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
            this.moneyLBL.Size = new System.Drawing.Size(42, 21);
            this.moneyLBL.TabIndex = 1;
            this.moneyLBL.Text = "0원";
            // 
            // fifthJobBTN
            // 
            this.fifthJobBTN.Location = new System.Drawing.Point(33, 676);
            this.fifthJobBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fifthJobBTN.Name = "fifthJobBTN";
            this.fifthJobBTN.Size = new System.Drawing.Size(258, 51);
            this.fifthJobBTN.TabIndex = 6;
            this.fifthJobBTN.Text = "건물주";
            this.fifthJobBTN.UseVisualStyleBackColor = true;
            this.fifthJobBTN.Click += new System.EventHandler(this.fifthJobBTN_Click);
            // 
            // forthJobBTN
            // 
            this.forthJobBTN.Location = new System.Drawing.Point(33, 598);
            this.forthJobBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.forthJobBTN.Name = "forthJobBTN";
            this.forthJobBTN.Size = new System.Drawing.Size(258, 51);
            this.forthJobBTN.TabIndex = 7;
            this.forthJobBTN.Text = "공무원";
            this.forthJobBTN.UseVisualStyleBackColor = true;
            this.forthJobBTN.Click += new System.EventHandler(this.forthJobBTN_Click);
            // 
            // thirdJobBTN
            // 
            this.thirdJobBTN.Location = new System.Drawing.Point(33, 520);
            this.thirdJobBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thirdJobBTN.Name = "thirdJobBTN";
            this.thirdJobBTN.Size = new System.Drawing.Size(258, 51);
            this.thirdJobBTN.TabIndex = 8;
            this.thirdJobBTN.Text = "편의점 알바";
            this.thirdJobBTN.UseVisualStyleBackColor = true;
            this.thirdJobBTN.Click += new System.EventHandler(this.thirdJobBTN_Click);
            // 
            // secondJobBTN
            // 
            this.secondJobBTN.Location = new System.Drawing.Point(33, 441);
            this.secondJobBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.secondJobBTN.Name = "secondJobBTN";
            this.secondJobBTN.Size = new System.Drawing.Size(258, 51);
            this.secondJobBTN.TabIndex = 9;
            this.secondJobBTN.Text = "전단지 알바";
            this.secondJobBTN.UseVisualStyleBackColor = true;
            this.secondJobBTN.Click += new System.EventHandler(this.secondJobBTN_Click);
            // 
            // firstJobBTN
            // 
            this.firstJobBTN.Location = new System.Drawing.Point(33, 373);
            this.firstJobBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstJobBTN.Name = "firstJobBTN";
            this.firstJobBTN.Size = new System.Drawing.Size(258, 51);
            this.firstJobBTN.TabIndex = 10;
            this.firstJobBTN.Text = "노숙자";
            this.firstJobBTN.UseVisualStyleBackColor = true;
            this.firstJobBTN.Click += new System.EventHandler(this.firstJobBTN_Click);
            // 
            // clickPNL
            // 
            this.clickPNL.Controls.Add(this.jusikBtn);
            this.clickPNL.Controls.Add(this.levelupBTN);
            this.clickPNL.Controls.Add(this.expCostLBL);
            this.clickPNL.Controls.Add(this.expLBL);
            this.clickPNL.Controls.Add(this.levelLBL);
            this.clickPNL.Controls.Add(this.thirdJobTimerLBL);
            this.clickPNL.Controls.Add(this.fifthJobTimerLBL);
            this.clickPNL.Controls.Add(this.forthJobTimerLBL);
            this.clickPNL.Controls.Add(this.label4);
            this.clickPNL.Controls.Add(this.secondJobTimerLBL);
            this.clickPNL.Controls.Add(this.firstJobTimerLBL);
            this.clickPNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clickPNL.Location = new System.Drawing.Point(0, 0);
            this.clickPNL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clickPNL.Name = "clickPNL";
            this.clickPNL.Size = new System.Drawing.Size(1043, 782);
            this.clickPNL.TabIndex = 11;
            this.clickPNL.Click += new System.EventHandler(this.clickPNL_Click);
            // 
            // jusikBtn
            // 
            this.jusikBtn.Location = new System.Drawing.Point(806, 26);
            this.jusikBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.jusikBtn.Name = "jusikBtn";
            this.jusikBtn.Size = new System.Drawing.Size(170, 46);
            this.jusikBtn.TabIndex = 10;
            this.jusikBtn.Text = "거래소 입장";
            this.jusikBtn.UseVisualStyleBackColor = true;
            this.jusikBtn.Click += new System.EventHandler(this.jusikBtn_Click);
            // 
            // levelupBTN
            // 
            this.levelupBTN.Location = new System.Drawing.Point(734, 676);
            this.levelupBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.levelupBTN.Name = "levelupBTN";
            this.levelupBTN.Size = new System.Drawing.Size(242, 51);
            this.levelupBTN.TabIndex = 9;
            this.levelupBTN.Text = "레벨 업(&F)";
            this.levelupBTN.UseVisualStyleBackColor = true;
            this.levelupBTN.Click += new System.EventHandler(this.levelupBTN_Click);
            // 
            // expCostLBL
            // 
            this.expCostLBL.AutoSize = true;
            this.expCostLBL.Location = new System.Drawing.Point(13, 122);
            this.expCostLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.expCostLBL.Name = "expCostLBL";
            this.expCostLBL.Size = new System.Drawing.Size(58, 21);
            this.expCostLBL.TabIndex = 8;
            this.expCostLBL.Text = "label5";
            // 
            // expLBL
            // 
            this.expLBL.AutoSize = true;
            this.expLBL.Location = new System.Drawing.Point(13, 88);
            this.expLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.expLBL.Name = "expLBL";
            this.expLBL.Size = new System.Drawing.Size(58, 21);
            this.expLBL.TabIndex = 7;
            this.expLBL.Text = "label3";
            // 
            // levelLBL
            // 
            this.levelLBL.AutoSize = true;
            this.levelLBL.Location = new System.Drawing.Point(13, 52);
            this.levelLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.levelLBL.Name = "levelLBL";
            this.levelLBL.Size = new System.Drawing.Size(58, 21);
            this.levelLBL.TabIndex = 6;
            this.levelLBL.Text = "label2";
            // 
            // thirdJobTimerLBL
            // 
            this.thirdJobTimerLBL.AutoSize = true;
            this.thirdJobTimerLBL.Location = new System.Drawing.Point(309, 536);
            this.thirdJobTimerLBL.Name = "thirdJobTimerLBL";
            this.thirdJobTimerLBL.Size = new System.Drawing.Size(0, 21);
            this.thirdJobTimerLBL.TabIndex = 5;
            // 
            // fifthJobTimerLBL
            // 
            this.fifthJobTimerLBL.AutoSize = true;
            this.fifthJobTimerLBL.Location = new System.Drawing.Point(309, 691);
            this.fifthJobTimerLBL.Name = "fifthJobTimerLBL";
            this.fifthJobTimerLBL.Size = new System.Drawing.Size(0, 21);
            this.fifthJobTimerLBL.TabIndex = 4;
            // 
            // forthJobTimerLBL
            // 
            this.forthJobTimerLBL.AutoSize = true;
            this.forthJobTimerLBL.Location = new System.Drawing.Point(309, 612);
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
            this.secondJobTimerLBL.Location = new System.Drawing.Point(309, 457);
            this.secondJobTimerLBL.Name = "secondJobTimerLBL";
            this.secondJobTimerLBL.Size = new System.Drawing.Size(0, 21);
            this.secondJobTimerLBL.TabIndex = 1;
            // 
            // firstJobTimerLBL
            // 
            this.firstJobTimerLBL.AutoSize = true;
            this.firstJobTimerLBL.Location = new System.Drawing.Point(309, 388);
            this.firstJobTimerLBL.Name = "firstJobTimerLBL";
            this.firstJobTimerLBL.Size = new System.Drawing.Size(0, 21);
            this.firstJobTimerLBL.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 782);
            this.Controls.Add(this.firstJobBTN);
            this.Controls.Add(this.secondJobBTN);
            this.Controls.Add(this.thirdJobBTN);
            this.Controls.Add(this.forthJobBTN);
            this.Controls.Add(this.fifthJobBTN);
            this.Controls.Add(this.moneyLBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clickPNL);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Growing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
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
        private System.Windows.Forms.Timer btncheckTMR;
        private System.Windows.Forms.Panel clickPNL;
        private System.Windows.Forms.Label thirdJobTimerLBL;
        private System.Windows.Forms.Label fifthJobTimerLBL;
        private System.Windows.Forms.Label forthJobTimerLBL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label secondJobTimerLBL;
        private System.Windows.Forms.Label firstJobTimerLBL;
        private System.Windows.Forms.Timer updateCountdownTMR;
        private System.Windows.Forms.Label expCostLBL;
        private System.Windows.Forms.Label expLBL;
        private System.Windows.Forms.Label levelLBL;
        private System.Windows.Forms.Button levelupBTN;
        private System.Windows.Forms.Button jusikBtn;
    }
}

