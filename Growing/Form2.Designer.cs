namespace Growing
{
    partial class MDLstock
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.kwangE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stockNum1 = new System.Windows.Forms.Label();
            this.curPrice1 = new System.Windows.Forms.Label();
            this.buyBtn = new System.Windows.Forms.Button();
            this.sellBtn = new System.Windows.Forms.Button();
            this.kwangJ = new System.Windows.Forms.Button();
            this.kwangC = new System.Windows.Forms.Button();
            this.kwangS = new System.Windows.Forms.Button();
            this.stockNum2 = new System.Windows.Forms.Label();
            this.stockNum3 = new System.Windows.Forms.Label();
            this.stockNum4 = new System.Windows.Forms.Label();
            this.curPrice2 = new System.Windows.Forms.Label();
            this.curPrice3 = new System.Windows.Forms.Label();
            this.curPrice4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_개수 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chartPrice = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.newsBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // kwangE
            // 
            this.kwangE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kwangE.Location = new System.Drawing.Point(48, 78);
            this.kwangE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kwangE.Name = "kwangE";
            this.kwangE.Size = new System.Drawing.Size(186, 60);
            this.kwangE.TabIndex = 0;
            this.kwangE.Text = "광운전자";
            this.kwangE.UseVisualStyleBackColor = true;
            this.kwangE.Click += new System.EventHandler(this.btnSelect0_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "현재 가격";
            // 
            // stockNum1
            // 
            this.stockNum1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stockNum1.AutoSize = true;
            this.stockNum1.Location = new System.Drawing.Point(521, 96);
            this.stockNum1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stockNum1.Name = "stockNum1";
            this.stockNum1.Size = new System.Drawing.Size(69, 24);
            this.stockNum1.TabIndex = 4;
            this.stockNum1.Text = "label2";
            // 
            // curPrice1
            // 
            this.curPrice1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.curPrice1.AutoSize = true;
            this.curPrice1.Location = new System.Drawing.Point(319, 96);
            this.curPrice1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curPrice1.Name = "curPrice1";
            this.curPrice1.Size = new System.Drawing.Size(69, 24);
            this.curPrice1.TabIndex = 5;
            this.curPrice1.Text = "label3";
            // 
            // buyBtn
            // 
            this.buyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buyBtn.Location = new System.Drawing.Point(409, 504);
            this.buyBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(136, 60);
            this.buyBtn.TabIndex = 6;
            this.buyBtn.Text = "구매";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // sellBtn
            // 
            this.sellBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sellBtn.Location = new System.Drawing.Point(576, 504);
            this.sellBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(136, 60);
            this.sellBtn.TabIndex = 7;
            this.sellBtn.Text = "판매";
            this.sellBtn.UseVisualStyleBackColor = true;
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
            // 
            // kwangJ
            // 
            this.kwangJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kwangJ.Location = new System.Drawing.Point(48, 170);
            this.kwangJ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kwangJ.Name = "kwangJ";
            this.kwangJ.Size = new System.Drawing.Size(186, 60);
            this.kwangJ.TabIndex = 8;
            this.kwangJ.Text = "광운중공업";
            this.kwangJ.UseVisualStyleBackColor = true;
            this.kwangJ.Click += new System.EventHandler(this.btnSelect1_Click);
            // 
            // kwangC
            // 
            this.kwangC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kwangC.Location = new System.Drawing.Point(48, 274);
            this.kwangC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kwangC.Name = "kwangC";
            this.kwangC.Size = new System.Drawing.Size(186, 60);
            this.kwangC.TabIndex = 9;
            this.kwangC.Text = "광운자동차";
            this.kwangC.UseVisualStyleBackColor = true;
            this.kwangC.Click += new System.EventHandler(this.btnSelect2_Click);
            // 
            // kwangS
            // 
            this.kwangS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kwangS.Location = new System.Drawing.Point(48, 376);
            this.kwangS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kwangS.Name = "kwangS";
            this.kwangS.Size = new System.Drawing.Size(186, 60);
            this.kwangS.TabIndex = 10;
            this.kwangS.Text = "광운소프트";
            this.kwangS.UseVisualStyleBackColor = true;
            this.kwangS.Click += new System.EventHandler(this.btnSelect3_Click);
            // 
            // stockNum2
            // 
            this.stockNum2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stockNum2.AutoSize = true;
            this.stockNum2.Location = new System.Drawing.Point(521, 188);
            this.stockNum2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stockNum2.Name = "stockNum2";
            this.stockNum2.Size = new System.Drawing.Size(69, 24);
            this.stockNum2.TabIndex = 11;
            this.stockNum2.Text = "label2";
            // 
            // stockNum3
            // 
            this.stockNum3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stockNum3.AutoSize = true;
            this.stockNum3.Location = new System.Drawing.Point(521, 292);
            this.stockNum3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stockNum3.Name = "stockNum3";
            this.stockNum3.Size = new System.Drawing.Size(69, 24);
            this.stockNum3.TabIndex = 12;
            this.stockNum3.Text = "label2";
            this.stockNum3.Click += new System.EventHandler(this.stockNum3_Click);
            // 
            // stockNum4
            // 
            this.stockNum4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stockNum4.AutoSize = true;
            this.stockNum4.Location = new System.Drawing.Point(521, 394);
            this.stockNum4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stockNum4.Name = "stockNum4";
            this.stockNum4.Size = new System.Drawing.Size(69, 24);
            this.stockNum4.TabIndex = 13;
            this.stockNum4.Text = "label2";
            this.stockNum4.Click += new System.EventHandler(this.stockNum4_Click);
            // 
            // curPrice2
            // 
            this.curPrice2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.curPrice2.AutoSize = true;
            this.curPrice2.Location = new System.Drawing.Point(319, 188);
            this.curPrice2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curPrice2.Name = "curPrice2";
            this.curPrice2.Size = new System.Drawing.Size(69, 24);
            this.curPrice2.TabIndex = 14;
            this.curPrice2.Text = "label3";
            // 
            // curPrice3
            // 
            this.curPrice3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.curPrice3.AutoSize = true;
            this.curPrice3.Location = new System.Drawing.Point(319, 292);
            this.curPrice3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curPrice3.Name = "curPrice3";
            this.curPrice3.Size = new System.Drawing.Size(69, 24);
            this.curPrice3.TabIndex = 15;
            this.curPrice3.Text = "label3";
            // 
            // curPrice4
            // 
            this.curPrice4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.curPrice4.AutoSize = true;
            this.curPrice4.Location = new System.Drawing.Point(319, 394);
            this.curPrice4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curPrice4.Name = "curPrice4";
            this.curPrice4.Size = new System.Drawing.Size(69, 24);
            this.curPrice4.TabIndex = 16;
            this.curPrice4.Text = "label3";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "보유 주식 수:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_개수
            // 
            this.txt_개수.Location = new System.Drawing.Point(169, 519);
            this.txt_개수.Name = "txt_개수";
            this.txt_개수.Size = new System.Drawing.Size(150, 35);
            this.txt_개수.TabIndex = 18;
            this.txt_개수.TextChanged += new System.EventHandler(this.txt_개수_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "개수";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // chartPrice
            // 
            chartArea3.Name = "ChartArea1";
            this.chartPrice.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartPrice.Legends.Add(legend3);
            this.chartPrice.Location = new System.Drawing.Point(743, 2);
            this.chartPrice.Name = "chartPrice";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartPrice.Series.Add(series3);
            this.chartPrice.Size = new System.Drawing.Size(748, 617);
            this.chartPrice.TabIndex = 20;
            this.chartPrice.Text = "chart1";
            // 
            // newsBox
            // 
            this.newsBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newsBox.Location = new System.Drawing.Point(0, 717);
            this.newsBox.Name = "newsBox";
            this.newsBox.Size = new System.Drawing.Size(1531, 227);
            this.newsBox.TabIndex = 21;
            this.newsBox.Text = "";
            // 
            // MDLstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 944);
            this.Controls.Add(this.newsBox);
            this.Controls.Add(this.chartPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_개수);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.curPrice4);
            this.Controls.Add(this.curPrice3);
            this.Controls.Add(this.curPrice2);
            this.Controls.Add(this.stockNum4);
            this.Controls.Add(this.stockNum3);
            this.Controls.Add(this.stockNum2);
            this.Controls.Add(this.kwangS);
            this.Controls.Add(this.kwangC);
            this.Controls.Add(this.kwangJ);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.curPrice1);
            this.Controls.Add(this.stockNum1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kwangE);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MDLstock";
            this.Text = "광스피";
            this.Load += new System.EventHandler(this.MDlstock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kwangE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stockNum1;
        private System.Windows.Forms.Label curPrice1;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.Button sellBtn;
        private System.Windows.Forms.Button kwangJ;
        private System.Windows.Forms.Button kwangC;
        private System.Windows.Forms.Button kwangS;
        private System.Windows.Forms.Label stockNum2;
        private System.Windows.Forms.Label stockNum3;
        private System.Windows.Forms.Label stockNum4;
        private System.Windows.Forms.Label curPrice2;
        private System.Windows.Forms.Label curPrice3;
        private System.Windows.Forms.Label curPrice4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_개수;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrice;
        private System.Windows.Forms.RichTextBox newsBox;
    }
}