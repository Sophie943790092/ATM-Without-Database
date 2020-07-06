namespace ATM自助存取款终端
{
    partial class FrmSelectTransactionItem
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
            this.btnWithwraw = new System.Windows.Forms.Button();
            this.btnInquiry = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnAltPwd = new System.Windows.Forms.Button();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.lblSever = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWithwraw
            // 
            this.btnWithwraw.Location = new System.Drawing.Point(145, 151);
            this.btnWithwraw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWithwraw.Name = "btnWithwraw";
            this.btnWithwraw.Size = new System.Drawing.Size(123, 48);
            this.btnWithwraw.TabIndex = 0;
            this.btnWithwraw.Text = "取款";
            this.btnWithwraw.UseVisualStyleBackColor = true;
            this.btnWithwraw.Click += new System.EventHandler(this.btnWithwraw_Click);
            // 
            // btnInquiry
            // 
            this.btnInquiry.Location = new System.Drawing.Point(145, 258);
            this.btnInquiry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.Size = new System.Drawing.Size(123, 50);
            this.btnInquiry.TabIndex = 1;
            this.btnInquiry.Text = "查询";
            this.btnInquiry.UseVisualStyleBackColor = true;
            this.btnInquiry.Click += new System.EventHandler(this.btnInquiry_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(145, 376);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(123, 52);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "转账";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(637, 151);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(128, 48);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "存款";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnAltPwd
            // 
            this.btnAltPwd.Location = new System.Drawing.Point(637, 258);
            this.btnAltPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAltPwd.Name = "btnAltPwd";
            this.btnAltPwd.Size = new System.Drawing.Size(128, 50);
            this.btnAltPwd.TabIndex = 4;
            this.btnAltPwd.Text = "修改密码";
            this.btnAltPwd.UseVisualStyleBackColor = true;
            // 
            // btnExit2
            // 
            this.btnExit2.Location = new System.Drawing.Point(637, 376);
            this.btnExit2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(128, 52);
            this.btnExit2.TabIndex = 5;
            this.btnExit2.Text = "退出";
            this.btnExit2.UseVisualStyleBackColor = true;
            this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
            // 
            // lblSever
            // 
            this.lblSever.AutoSize = true;
            this.lblSever.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSever.Location = new System.Drawing.Point(366, 74);
            this.lblSever.Name = "lblSever";
            this.lblSever.Size = new System.Drawing.Size(178, 24);
            this.lblSever.TabIndex = 6;
            this.lblSever.Text = "请选择服务项目";
            // 
            // FrmSelectTransactionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.lblSever);
            this.Controls.Add(this.btnExit2);
            this.Controls.Add(this.btnAltPwd);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnInquiry);
            this.Controls.Add(this.btnWithwraw);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSelectTransactionItem";
            this.Text = "ATM自助终端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWithwraw;
        private System.Windows.Forms.Button btnInquiry;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnAltPwd;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.Label lblSever;
    }
}