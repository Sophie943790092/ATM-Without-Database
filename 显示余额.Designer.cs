namespace ATM自助存取款终端
{
    partial class FrmShowBalance
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
            this.btnExit5 = new System.Windows.Forms.Button();
            this.btnWithdraw2 = new System.Windows.Forms.Button();
            this.btnExit4 = new System.Windows.Forms.Button();
            this.btnDeposit2 = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtavailableBlance = new System.Windows.Forms.TextBox();
            this.txtotalBalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit5
            // 
            this.btnExit5.Location = new System.Drawing.Point(597, 260);
            this.btnExit5.Name = "btnExit5";
            this.btnExit5.Size = new System.Drawing.Size(107, 32);
            this.btnExit5.TabIndex = 0;
            this.btnExit5.Text = "返回主菜单";
            this.btnExit5.UseVisualStyleBackColor = true;
            this.btnExit5.Click += new System.EventHandler(this.btnExit5_Click);
            // 
            // btnWithdraw2
            // 
            this.btnWithdraw2.Location = new System.Drawing.Point(597, 173);
            this.btnWithdraw2.Name = "btnWithdraw2";
            this.btnWithdraw2.Size = new System.Drawing.Size(107, 32);
            this.btnWithdraw2.TabIndex = 1;
            this.btnWithdraw2.Text = "取款";
            this.btnWithdraw2.UseVisualStyleBackColor = true;
            this.btnWithdraw2.Click += new System.EventHandler(this.btnWithdraw2_Click);
            // 
            // btnExit4
            // 
            this.btnExit4.Location = new System.Drawing.Point(47, 260);
            this.btnExit4.Name = "btnExit4";
            this.btnExit4.Size = new System.Drawing.Size(97, 33);
            this.btnExit4.TabIndex = 2;
            this.btnExit4.Text = "退出终端";
            this.btnExit4.UseVisualStyleBackColor = true;
            this.btnExit4.Click += new System.EventHandler(this.btnExit4_Click);
            // 
            // btnDeposit2
            // 
            this.btnDeposit2.Location = new System.Drawing.Point(47, 173);
            this.btnDeposit2.Name = "btnDeposit2";
            this.btnDeposit2.Size = new System.Drawing.Size(97, 32);
            this.btnDeposit2.TabIndex = 4;
            this.btnDeposit2.Text = "存款";
            this.btnDeposit2.UseVisualStyleBackColor = true;
            this.btnDeposit2.Click += new System.EventHandler(this.btnDeposit2_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.Location = new System.Drawing.Point(242, 177);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(99, 19);
            this.label.TabIndex = 5;
            this.label.Text = "可用余额:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(242, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "账户余额:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(352, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "交易成功";
            // 
            // txtavailableBlance
            // 
            this.txtavailableBlance.Location = new System.Drawing.Point(355, 174);
            this.txtavailableBlance.Name = "txtavailableBlance";
            this.txtavailableBlance.Size = new System.Drawing.Size(164, 25);
            this.txtavailableBlance.TabIndex = 8;
            this.txtavailableBlance.TextChanged += new System.EventHandler(this.txtavailableBlance_TextChanged);
            // 
            // txtotalBalance
            // 
            this.txtotalBalance.Location = new System.Drawing.Point(355, 111);
            this.txtotalBalance.Name = "txtotalBalance";
            this.txtotalBalance.Size = new System.Drawing.Size(164, 25);
            this.txtotalBalance.TabIndex = 9;
            this.txtotalBalance.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FrmShowBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtotalBalance);
            this.Controls.Add(this.txtavailableBlance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnDeposit2);
            this.Controls.Add(this.btnExit4);
            this.Controls.Add(this.btnWithdraw2);
            this.Controls.Add(this.btnExit5);
            this.Name = "FrmShowBalance";
            this.Text = "ATM自助终端";
            this.Load += new System.EventHandler(this.FrmShowBalance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit5;
        private System.Windows.Forms.Button btnWithdraw2;
        private System.Windows.Forms.Button btnExit4;
        private System.Windows.Forms.Button btnDeposit2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtavailableBlance;
        private System.Windows.Forms.TextBox txtotalBalance;
    }
}