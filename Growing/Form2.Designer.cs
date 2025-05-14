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
            this.KwangE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buyBtn = new System.Windows.Forms.Button();
            this.sellBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KwangE
            // 
            this.KwangE.Location = new System.Drawing.Point(63, 22);
            this.KwangE.Name = "KwangE";
            this.KwangE.Size = new System.Drawing.Size(149, 60);
            this.KwangE.TabIndex = 0;
            this.KwangE.Text = "광운전자";
            this.KwangE.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "보유 주식 수:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(737, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // buyBtn
            // 
            this.buyBtn.Location = new System.Drawing.Point(689, 420);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(99, 60);
            this.buyBtn.TabIndex = 6;
            this.buyBtn.Text = "구매";
            this.buyBtn.UseVisualStyleBackColor = true;
            // 
            // sellBtn
            // 
            this.sellBtn.Location = new System.Drawing.Point(841, 420);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(99, 60);
            this.sellBtn.TabIndex = 7;
            this.sellBtn.Text = "판매";
            this.sellBtn.UseVisualStyleBackColor = true;
            // 
            // MDLstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 510);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KwangE);
            this.Name = "MDLstock";
            this.Text = "광스피";
            this.Load += new System.EventHandler(this.MDlstock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KwangE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.Button sellBtn;
    }
}