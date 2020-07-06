namespace ATM自助存取款终端
{
    partial class FrmWithdrawalSuccessful
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
            this.btnBackToFrmSelectTransactionItem = new System.Windows.Forms.Button();
            this.btnContinueWithdrawal = new System.Windows.Forms.Button();
            this.btnShowBalance = new System.Windows.Forms.Button();
            this.btnPrintTickertape = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount1 = new System.Windows.Forms.TextBox();
            this.txtServiceCharge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit3
            // 
            this.btnExit3.Location = new System.Drawing.Point(74, 338);
            this.btnExit3.Name = "btnExit3";
            this.btnExit3.Size = new System.Drawing.Size(98, 28);
            this.btnExit3.TabIndex = 0;
            this.btnExit3.Text = "退出终端";
            this.btnExit3.UseVisualStyleBackColor = true;
            this.btnExit3.Click += new System.EventHandler(this.btnExit3_Click);
            // 
            // btnBackToFrmSelectTransactionItem
            // 
            this.btnBackToFrmSelectTransactionItem.Location = new System.Drawing.Point(598, 250);
            this.btnBackToFrmSelectTransactionItem.Name = "btnBackToFrmSelectTransactionItem";
            this.btnBackToFrmSelectTransactionItem.Size = new System.Drawing.Size(104, 30);
            this.btnBackToFrmSelectTransactionItem.TabIndex = 1;
            this.btnBackToFrmSelectTransactionItem.Text = "返回主菜单";
            this.btnBackToFrmSelectTransactionItem.UseVisualStyleBackColor = true;
            this.btnBackToFrmSelectTransactionItem.Click += new System.EventHandler(this.btnBackToFrmSelectTransactionItem_Click);
            // 
            // btnContinueWithdrawal
            // 
            this.btnContinueWithdrawal.Location = new System.Drawing.Point(598, 160);
            this.btnContinueWithdrawal.Name = "btnContinueWithdrawal";
            this.btnContinueWithdrawal.Size = new System.Drawing.Size(104, 33);
            this.btnContinueWithdrawal.TabIndex = 2;
            this.btnContinueWithdrawal.Text = "继续取款";
            this.btnContinueWithdrawal.UseVisualStyleBackColor = true;
            this.btnContinueWithdrawal.Click += new System.EventHandler(this.btnContinueWithdrawal_Click);
            // 
            // btnShowBalance
            // 
            this.btnShowBalance.Location = new System.Drawing.Point(74, 250);
            this.btnShowBalance.Name = "btnShowBalance";
            this.btnShowBalance.Size = new System.Drawing.Size(98, 30);
            this.btnShowBalance.TabIndex = 3;
            this.btnShowBalance.Text = "显示余额";
            this.btnShowBalance.UseVisualStyleBackColor = true;
            this.btnShowBalance.Click += new System.EventHandler(this.btnShowBalance_Click);
            // 
            // btnPrintTickertape
            // 
            this.btnPrintTickertape.Location = new System.Drawing.Point(74, 160);
            this.btnPrintTickertape.Name = "btnPrintTickertape";
            this.btnPrintTickertape.Size = new System.Drawing.Size(98, 33);
            this.btnPrintTickertape.TabIndex = 4;
            this.btnPrintTickertape.Text = "打印凭条";
            this.btnPrintTickertape.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(204, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "交易金额:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(225, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "手续费:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(336, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "交易成功";
            // 
            // txtAmount1
            // 
            this.txtAmount1.Location = new System.Drawing.Point(310, 128);
            this.txtAmount1.Name = "txtAmount1";
            this.txtAmount1.Size = new System.Drawing.Size(183, 25);
            this.txtAmount1.TabIndex = 8;
            this.txtAmount1.TextChanged += new System.EventHandler(this.txtAmount1_TextChanged);
            // 
            // txtServiceCharge
            // 
            this.txtServiceCharge.Location = new System.Drawing.Point(310, 204);
            this.txtServiceCharge.Name = "txtServiceCharge";
            this.txtServiceCharge.Size = new System.Drawing.Size(183, 25);
            this.txtServiceCharge.TabIndex = 9;
            this.txtServiceCharge.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FrmWithdrawalSuccessful
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtServiceCharge);
            this.Controls.Add(this.txtAmount1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintTickertape);
            this.Controls.Add(this.btnShowBalance);
            this.Controls.Add(this.btnContinueWithdrawal);
            this.Controls.Add(this.btnBackToFrmSelectTransactionItem);
            this.Controls.Add(this.btnExit3);
            this.Name = "FrmWithdrawalSuccessful";
            this.Text = "ATM自助终端";
            this.Load += new System.EventHandler(this.FrmWithdrawalSuccessful_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit3;
        private System.Windows.Forms.Button btnBackToFrmSelectTransactionItem;
        private System.Windows.Forms.Button btnContinueWithdrawal;
        private System.Windows.Forms.Button btnShowBalance;
        private System.Windows.Forms.Button btnPrintTickertape;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtAmount1;
        private System.Windows.Forms.TextBox txtServiceCharge;
    }
}