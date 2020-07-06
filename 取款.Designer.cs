namespace ATM自助存取款终端
{
    partial class FrmWithdraw
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
            this.btnExit3 = new System.Windows.Forms.Button();
            this.btnWithdraw3000 = new System.Windows.Forms.Button();
            this.btnWithdraw1000 = new System.Windows.Forms.Button();
            this.btnWithdraw100 = new System.Windows.Forms.Button();
            this.btnConfirm1 = new System.Windows.Forms.Button();
            this.btnWithdraw2000 = new System.Windows.Forms.Button();
            this.btnWithdraw300 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWithdrawalAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnWithdraw5000 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit3
            // 
            this.btnExit3.Location = new System.Drawing.Point(101, 334);
            this.btnExit3.Name = "btnExit3";
            this.btnExit3.Size = new System.Drawing.Size(94, 45);
            this.btnExit3.TabIndex = 0;
            this.btnExit3.Text = "取消";
            this.btnExit3.UseVisualStyleBackColor = true;
            this.btnExit3.Click += new System.EventHandler(this.btnExit3_Click);
            // 
            // btnWithdraw3000
            // 
            this.btnWithdraw3000.Location = new System.Drawing.Point(101, 260);
            this.btnWithdraw3000.Name = "btnWithdraw3000";
            this.btnWithdraw3000.Size = new System.Drawing.Size(94, 49);
            this.btnWithdraw3000.TabIndex = 1;
            this.btnWithdraw3000.Text = "3000";
            this.btnWithdraw3000.UseVisualStyleBackColor = true;
            this.btnWithdraw3000.Click += new System.EventHandler(this.btnWithdraw3000_Click);
            // 
            // btnWithdraw1000
            // 
            this.btnWithdraw1000.Location = new System.Drawing.Point(101, 179);
            this.btnWithdraw1000.Name = "btnWithdraw1000";
            this.btnWithdraw1000.Size = new System.Drawing.Size(94, 49);
            this.btnWithdraw1000.TabIndex = 2;
            this.btnWithdraw1000.Text = "1000";
            this.btnWithdraw1000.UseVisualStyleBackColor = true;
            this.btnWithdraw1000.Click += new System.EventHandler(this.btnWithdraw1000_Click);
            // 
            // btnWithdraw100
            // 
            this.btnWithdraw100.Location = new System.Drawing.Point(101, 93);
            this.btnWithdraw100.Name = "btnWithdraw100";
            this.btnWithdraw100.Size = new System.Drawing.Size(94, 52);
            this.btnWithdraw100.TabIndex = 3;
            this.btnWithdraw100.Text = "100";
            this.btnWithdraw100.UseVisualStyleBackColor = true;
            this.btnWithdraw100.Click += new System.EventHandler(this.btnWithdraw100_Click);
            // 
            // btnConfirm1
            // 
            this.btnConfirm1.Location = new System.Drawing.Point(590, 334);
            this.btnConfirm1.Name = "btnConfirm1";
            this.btnConfirm1.Size = new System.Drawing.Size(90, 45);
            this.btnConfirm1.TabIndex = 4;
            this.btnConfirm1.Text = "确认";
            this.btnConfirm1.UseVisualStyleBackColor = true;
            this.btnConfirm1.Click += new System.EventHandler(this.btnConfirm1_Click);
            // 
            // btnWithdraw2000
            // 
            this.btnWithdraw2000.Location = new System.Drawing.Point(590, 179);
            this.btnWithdraw2000.Name = "btnWithdraw2000";
            this.btnWithdraw2000.Size = new System.Drawing.Size(90, 49);
            this.btnWithdraw2000.TabIndex = 6;
            this.btnWithdraw2000.Text = "2000";
            this.btnWithdraw2000.UseVisualStyleBackColor = true;
            this.btnWithdraw2000.Click += new System.EventHandler(this.btnWithdraw2000_Click);
            // 
            // btnWithdraw300
            // 
            this.btnWithdraw300.Location = new System.Drawing.Point(590, 93);
            this.btnWithdraw300.Name = "btnWithdraw300";
            this.btnWithdraw300.Size = new System.Drawing.Size(90, 52);
            this.btnWithdraw300.TabIndex = 7;
            this.btnWithdraw300.Text = "300";
            this.btnWithdraw300.UseVisualStyleBackColor = true;
            this.btnWithdraw300.Click += new System.EventHandler(this.btnWithdraw300_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(246, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "请选择或输入取款金额";
            // 
            // txtWithdrawalAmount
            // 
            this.txtWithdrawalAmount.Location = new System.Drawing.Point(277, 119);
            this.txtWithdrawalAmount.Name = "txtWithdrawalAmount";
            this.txtWithdrawalAmount.Size = new System.Drawing.Size(207, 25);
            this.txtWithdrawalAmount.TabIndex = 9;
            this.txtWithdrawalAmount.TextChanged += new System.EventHandler(this.txtWithdrawalAmount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "本机只提供面额100元人民币,且单笔最多取5000元。";
            // 
            // btnWithdraw5000
            // 
            this.btnWithdraw5000.Location = new System.Drawing.Point(590, 262);
            this.btnWithdraw5000.Name = "btnWithdraw5000";
            this.btnWithdraw5000.Size = new System.Drawing.Size(90, 44);
            this.btnWithdraw5000.TabIndex = 11;
            this.btnWithdraw5000.Text = "5000";
            this.btnWithdraw5000.UseVisualStyleBackColor = true;
            this.btnWithdraw5000.Click += new System.EventHandler(this.btnWithdraw5000_Click);
            // 
            // FrmWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWithdraw5000);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWithdrawalAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWithdraw300);
            this.Controls.Add(this.btnWithdraw2000);
            this.Controls.Add(this.btnConfirm1);
            this.Controls.Add(this.btnWithdraw100);
            this.Controls.Add(this.btnWithdraw1000);
            this.Controls.Add(this.btnWithdraw3000);
            this.Controls.Add(this.btnExit3);
            this.Name = "FrmWithdraw";
            this.Text = "ATM自助终端";
            this.Load += new System.EventHandler(this.FrmWithdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit3;
        private System.Windows.Forms.Button btnWithdraw3000;
        private System.Windows.Forms.Button btnWithdraw1000;
        private System.Windows.Forms.Button btnWithdraw100;
        private System.Windows.Forms.Button btnConfirm1;
        private System.Windows.Forms.Button btnWithdraw2000;
        private System.Windows.Forms.Button btnWithdraw300;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtWithdrawalAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnWithdraw5000;
    }
}