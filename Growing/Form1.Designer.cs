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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fifthJobPB = new System.Windows.Forms.PictureBox();
            this.forthJobPB = new System.Windows.Forms.PictureBox();
            this.thirdJobPB = new System.Windows.Forms.PictureBox();
            this.secondJobPB = new System.Windows.Forms.PictureBox();
            this.firstJobPB = new System.Windows.Forms.PictureBox();
            this.jusikBtn = new System.Windows.Forms.Button();
            this.levelupBTN = new System.Windows.Forms.Button();
            this.expLBL = new System.Windows.Forms.Label();
            this.levelLBL = new System.Windows.Forms.Label();
            this.thirdJobTimerLBL = new System.Windows.Forms.Label();
            this.fifthJobTimerLBL = new System.Windows.Forms.Label();
            this.forthJobTimerLBL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.secondJobTimerLBL = new System.Windows.Forms.Label();
            this.firstJobTimerLBL = new System.Windows.Forms.Label();
            this.updateCountdownTMR = new System.Windows.Forms.Timer(this.components);
            this.gameTMR = new System.Windows.Forms.Timer(this.components);
            this.lblClickIncome = new System.Windows.Forms.Label();
            this.lblWorkerIncome = new System.Windows.Forms.Label();
            this.expProgressBar = new System.Windows.Forms.ProgressBar();
            this.clickPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthJobPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forthJobPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdJobPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondJobPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstJobPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "모은돈";
            // 
            // moneyLBL
            // 
            this.moneyLBL.AutoSize = true;
            this.moneyLBL.Location = new System.Drawing.Point(106, 10);
            this.moneyLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moneyLBL.Name = "moneyLBL";
            this.moneyLBL.Size = new System.Drawing.Size(30, 15);
            this.moneyLBL.TabIndex = 1;
            this.moneyLBL.Text = "0원";
            // 
            // fifthJobBTN
            // 
            this.fifthJobBTN.Location = new System.Drawing.Point(24, 482);
            this.fifthJobBTN.Margin = new System.Windows.Forms.Padding(2);
            this.fifthJobBTN.Name = "fifthJobBTN";
            this.fifthJobBTN.Size = new System.Drawing.Size(187, 38);
            this.fifthJobBTN.TabIndex = 6;
            this.fifthJobBTN.Text = "건물주";
            this.fifthJobBTN.UseVisualStyleBackColor = true;
            this.fifthJobBTN.Click += new System.EventHandler(this.fifthJobBTN_Click);
            // 
            // forthJobBTN
            // 
            this.forthJobBTN.Location = new System.Drawing.Point(24, 428);
            this.forthJobBTN.Margin = new System.Windows.Forms.Padding(2);
            this.forthJobBTN.Name = "forthJobBTN";
            this.forthJobBTN.Size = new System.Drawing.Size(187, 38);
            this.forthJobBTN.TabIndex = 7;
            this.forthJobBTN.Text = "공무원";
            this.forthJobBTN.UseVisualStyleBackColor = true;
            this.forthJobBTN.Click += new System.EventHandler(this.forthJobBTN_Click);
            // 
            // thirdJobBTN
            // 
            this.thirdJobBTN.Location = new System.Drawing.Point(24, 372);
            this.thirdJobBTN.Margin = new System.Windows.Forms.Padding(2);
            this.thirdJobBTN.Name = "thirdJobBTN";
            this.thirdJobBTN.Size = new System.Drawing.Size(187, 38);
            this.thirdJobBTN.TabIndex = 8;
            this.thirdJobBTN.Text = "편의점 알바";
            this.thirdJobBTN.UseVisualStyleBackColor = true;
            this.thirdJobBTN.Click += new System.EventHandler(this.thirdJobBTN_Click);
            // 
            // secondJobBTN
            // 
            this.secondJobBTN.Location = new System.Drawing.Point(24, 315);
            this.secondJobBTN.Margin = new System.Windows.Forms.Padding(2);
            this.secondJobBTN.Name = "secondJobBTN";
            this.secondJobBTN.Size = new System.Drawing.Size(187, 38);
            this.secondJobBTN.TabIndex = 9;
            this.secondJobBTN.Text = "전단지 알바";
            this.secondJobBTN.UseVisualStyleBackColor = true;
            this.secondJobBTN.Click += new System.EventHandler(this.secondJobBTN_Click);
            // 
            // firstJobBTN
            // 
            this.firstJobBTN.Location = new System.Drawing.Point(24, 268);
            this.firstJobBTN.Margin = new System.Windows.Forms.Padding(2);
            this.firstJobBTN.Name = "firstJobBTN";
            this.firstJobBTN.Size = new System.Drawing.Size(187, 38);
            this.firstJobBTN.TabIndex = 10;
            this.firstJobBTN.Text = "노숙자";
            this.firstJobBTN.UseVisualStyleBackColor = true;
            this.firstJobBTN.Click += new System.EventHandler(this.firstJobBTN_Click);
            // 
            // clickPNL
            // 
            this.clickPNL.Controls.Add(this.expProgressBar);
            this.clickPNL.Controls.Add(this.lblWorkerIncome);
            this.clickPNL.Controls.Add(this.lblClickIncome);
            this.clickPNL.Controls.Add(this.pictureBox1);
            this.clickPNL.Controls.Add(this.fifthJobPB);
            this.clickPNL.Controls.Add(this.forthJobPB);
            this.clickPNL.Controls.Add(this.thirdJobPB);
            this.clickPNL.Controls.Add(this.secondJobPB);
            this.clickPNL.Controls.Add(this.firstJobPB);
            this.clickPNL.Controls.Add(this.label1);
            this.clickPNL.Controls.Add(this.jusikBtn);
            this.clickPNL.Controls.Add(this.levelupBTN);
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
            this.clickPNL.Margin = new System.Windows.Forms.Padding(2);
            this.clickPNL.Name = "clickPNL";
            this.clickPNL.Size = new System.Drawing.Size(758, 558);
            this.clickPNL.TabIndex = 11;
            this.clickPNL.Click += new System.EventHandler(this.clickPNL_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Growing.Properties.Resources.Money_image;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // fifthJobPB
            // 
            this.fifthJobPB.Location = new System.Drawing.Point(574, 254);
            this.fifthJobPB.Margin = new System.Windows.Forms.Padding(2);
            this.fifthJobPB.Name = "fifthJobPB";
            this.fifthJobPB.Size = new System.Drawing.Size(165, 162);
            this.fifthJobPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fifthJobPB.TabIndex = 16;
            this.fifthJobPB.TabStop = false;
            this.fifthJobPB.Click += new System.EventHandler(this.clickPNL_Click);
            // 
            // forthJobPB
            // 
            this.forthJobPB.Location = new System.Drawing.Point(352, 254);
            this.forthJobPB.Margin = new System.Windows.Forms.Padding(2);
            this.forthJobPB.Name = "forthJobPB";
            this.forthJobPB.Size = new System.Drawing.Size(157, 162);
            this.forthJobPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.forthJobPB.TabIndex = 15;
            this.forthJobPB.TabStop = false;
            this.forthJobPB.Click += new System.EventHandler(this.clickPNL_Click);
            // 
            // thirdJobPB
            // 
            this.thirdJobPB.Location = new System.Drawing.Point(352, 62);
            this.thirdJobPB.Margin = new System.Windows.Forms.Padding(2);
            this.thirdJobPB.Name = "thirdJobPB";
            this.thirdJobPB.Size = new System.Drawing.Size(154, 168);
            this.thirdJobPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thirdJobPB.TabIndex = 14;
            this.thirdJobPB.TabStop = false;
            this.thirdJobPB.Click += new System.EventHandler(this.clickPNL_Click);
            // 
            // secondJobPB
            // 
            this.secondJobPB.Location = new System.Drawing.Point(574, 62);
            this.secondJobPB.Margin = new System.Windows.Forms.Padding(2);
            this.secondJobPB.Name = "secondJobPB";
            this.secondJobPB.Size = new System.Drawing.Size(165, 168);
            this.secondJobPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.secondJobPB.TabIndex = 13;
            this.secondJobPB.TabStop = false;
            this.secondJobPB.Click += new System.EventHandler(this.clickPNL_Click);
            // 
            // firstJobPB
            // 
            this.firstJobPB.Location = new System.Drawing.Point(139, 62);
            this.firstJobPB.Margin = new System.Windows.Forms.Padding(2);
            this.firstJobPB.Name = "firstJobPB";
            this.firstJobPB.Size = new System.Drawing.Size(152, 168);
            this.firstJobPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.firstJobPB.TabIndex = 12;
            this.firstJobPB.TabStop = false;
            this.firstJobPB.Click += new System.EventHandler(this.clickPNL_Click);
            // 
            // jusikBtn
            // 
            this.jusikBtn.Location = new System.Drawing.Point(586, 18);
            this.jusikBtn.Margin = new System.Windows.Forms.Padding(2);
            this.jusikBtn.Name = "jusikBtn";
            this.jusikBtn.Size = new System.Drawing.Size(123, 32);
            this.jusikBtn.TabIndex = 10;
            this.jusikBtn.Text = "거래소 입장";
            this.jusikBtn.UseVisualStyleBackColor = true;
            this.jusikBtn.Click += new System.EventHandler(this.jusikBtn_Click);
            // 
            // levelupBTN
            // 
            this.levelupBTN.Location = new System.Drawing.Point(534, 458);
            this.levelupBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.levelupBTN.Name = "levelupBTN";
            this.levelupBTN.Size = new System.Drawing.Size(176, 62);
            this.levelupBTN.TabIndex = 9;
            this.levelupBTN.Text = "레벨 업(&F)";
            this.levelupBTN.UseVisualStyleBackColor = true;
            this.levelupBTN.Click += new System.EventHandler(this.levelupBTN_Click);
            // 
            // expLBL
            // 
            this.expLBL.AutoSize = true;
            this.expLBL.Location = new System.Drawing.Point(49, 117);
            this.expLBL.Name = "expLBL";
            this.expLBL.Size = new System.Drawing.Size(45, 15);
            this.expLBL.TabIndex = 7;
            this.expLBL.Text = "label3";
            // 
            // levelLBL
            // 
            this.levelLBL.AutoSize = true;
            this.levelLBL.Location = new System.Drawing.Point(49, 92);
            this.levelLBL.Name = "levelLBL";
            this.levelLBL.Size = new System.Drawing.Size(45, 15);
            this.levelLBL.TabIndex = 6;
            this.levelLBL.Text = "label2";
            // 
            // thirdJobTimerLBL
            // 
            this.thirdJobTimerLBL.AutoSize = true;
            this.thirdJobTimerLBL.Location = new System.Drawing.Point(225, 382);
            this.thirdJobTimerLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thirdJobTimerLBL.Name = "thirdJobTimerLBL";
            this.thirdJobTimerLBL.Size = new System.Drawing.Size(0, 15);
            this.thirdJobTimerLBL.TabIndex = 5;
            // 
            // fifthJobTimerLBL
            // 
            this.fifthJobTimerLBL.AutoSize = true;
            this.fifthJobTimerLBL.Location = new System.Drawing.Point(225, 492);
            this.fifthJobTimerLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fifthJobTimerLBL.Name = "fifthJobTimerLBL";
            this.fifthJobTimerLBL.Size = new System.Drawing.Size(0, 15);
            this.fifthJobTimerLBL.TabIndex = 4;
            // 
            // forthJobTimerLBL
            // 
            this.forthJobTimerLBL.AutoSize = true;
            this.forthJobTimerLBL.Location = new System.Drawing.Point(225, 438);
            this.forthJobTimerLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.forthJobTimerLBL.Name = "forthJobTimerLBL";
            this.forthJobTimerLBL.Size = new System.Drawing.Size(0, 15);
            this.forthJobTimerLBL.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // secondJobTimerLBL
            // 
            this.secondJobTimerLBL.AutoSize = true;
            this.secondJobTimerLBL.Location = new System.Drawing.Point(225, 328);
            this.secondJobTimerLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.secondJobTimerLBL.Name = "secondJobTimerLBL";
            this.secondJobTimerLBL.Size = new System.Drawing.Size(0, 15);
            this.secondJobTimerLBL.TabIndex = 1;
            // 
            // firstJobTimerLBL
            // 
            this.firstJobTimerLBL.AutoSize = true;
            this.firstJobTimerLBL.Location = new System.Drawing.Point(225, 278);
            this.firstJobTimerLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstJobTimerLBL.Name = "firstJobTimerLBL";
            this.firstJobTimerLBL.Size = new System.Drawing.Size(0, 15);
            this.firstJobTimerLBL.TabIndex = 0;
            // 
            // lblClickIncome
            // 
            this.lblClickIncome.AutoSize = true;
            this.lblClickIncome.Location = new System.Drawing.Point(49, 35);
            this.lblClickIncome.Name = "lblClickIncome";
            this.lblClickIncome.Size = new System.Drawing.Size(45, 15);
            this.lblClickIncome.TabIndex = 18;
            this.lblClickIncome.Text = "label2";
            // 
            // lblWorkerIncome
            // 
            this.lblWorkerIncome.AutoSize = true;
            this.lblWorkerIncome.Location = new System.Drawing.Point(49, 62);
            this.lblWorkerIncome.Name = "lblWorkerIncome";
            this.lblWorkerIncome.Size = new System.Drawing.Size(45, 15);
            this.lblWorkerIncome.TabIndex = 19;
            this.lblWorkerIncome.Text = "label2";
            // 
            // expProgressBar
            // 
            this.expProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.expProgressBar.Location = new System.Drawing.Point(0, 535);
            this.expProgressBar.Name = "expProgressBar";
            this.expProgressBar.Size = new System.Drawing.Size(758, 23);
            this.expProgressBar.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 558);
            this.Controls.Add(this.firstJobBTN);
            this.Controls.Add(this.secondJobBTN);
            this.Controls.Add(this.thirdJobBTN);
            this.Controls.Add(this.forthJobBTN);
            this.Controls.Add(this.fifthJobBTN);
            this.Controls.Add(this.moneyLBL);
            this.Controls.Add(this.clickPNL);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Growing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.clickPNL.ResumeLayout(false);
            this.clickPNL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthJobPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forthJobPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdJobPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondJobPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstJobPB)).EndInit();
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
        private System.Windows.Forms.Label expLBL;
        private System.Windows.Forms.Label levelLBL;
        private System.Windows.Forms.Button levelupBTN;
        private System.Windows.Forms.Button jusikBtn;
        private System.Windows.Forms.Timer gameTMR;
        private System.Windows.Forms.PictureBox thirdJobPB;
        private System.Windows.Forms.PictureBox secondJobPB;
        private System.Windows.Forms.PictureBox firstJobPB;
        private System.Windows.Forms.PictureBox fifthJobPB;
        private System.Windows.Forms.PictureBox forthJobPB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWorkerIncome;
        private System.Windows.Forms.Label lblClickIncome;
        private System.Windows.Forms.ProgressBar expProgressBar;
    }
}

