namespace ATM自助存取款终端
{
    partial class FrmTransferAccount
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
            this.btnConfirm3 = new System.Windows.Forms.Button();
            this.btnExit7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYollon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTransferAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConfirm3
            // 
            this.btnConfirm3.Location = new System.Drawing.Point(430, 264);
            this.btnConfirm3.Name = "btnConfirm3";
            this.btnConfirm3.Size = new System.Drawing.Size(99, 32);
            this.btnConfirm3.TabIndex = 0;
            this.btnConfirm3.Text = "确认";
            this.btnConfirm3.UseVisualStyleBackColor = true;
            this.btnConfirm3.Click += new System.EventHandler(this.btnConfirm3_Click);
            // 
            // btnExit7
            // 
            this.btnExit7.Location = new System.Drawing.Point(216, 264);
            this.btnExit7.Name = "btnExit7";
            this.btnExit7.Size = new System.Drawing.Size(101, 32);
            this.btnExit7.TabIndex = 1;
            this.btnExit7.Text = "返回主菜单";
            this.btnExit7.UseVisualStyleBackColor = true;
            this.btnExit7.Click += new System.EventHandler(this.btnExit7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(212, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "转账金额";
            // 
            // txtYollon
            // 
            this.txtYollon.Location = new System.Drawing.Point(308, 129);
            this.txtYollon.Name = "txtYollon";
            this.txtYollon.Size = new System.Drawing.Size(197, 25);
            this.txtYollon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(212, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "收款账户";
            // 
            // txtTransferAmount
            // 
            this.txtTransferAmount.Location = new System.Drawing.Point(308, 192);
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.Size = new System.Drawing.Size(197, 25);
            this.txtTransferAmount.TabIndex = 5;
            // 
            // FrmTransferAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTransferAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYollon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit7);
            this.Controls.Add(this.btnConfirm3);
            this.Name = "FrmTransferAccount";
            this.Text = "ATM自助终端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm3;
        private System.Windows.Forms.Button btnExit7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYollon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTransferAmount;
    }
}