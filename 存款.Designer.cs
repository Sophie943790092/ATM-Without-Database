namespace ATM自助存取款终端
{
    partial class FrmDeposit
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit6 = new System.Windows.Forms.Button();
            this.btnConfirm2 = new System.Windows.Forms.Button();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(285, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入存款金额";
            // 
            // btnExit6
            // 
            this.btnExit6.Location = new System.Drawing.Point(271, 217);
            this.btnExit6.Name = "btnExit6";
            this.btnExit6.Size = new System.Drawing.Size(85, 36);
            this.btnExit6.TabIndex = 1;
            this.btnExit6.Text = "取消";
            this.btnExit6.UseVisualStyleBackColor = true;
            this.btnExit6.Click += new System.EventHandler(this.btnExit6_Click);
            // 
            // btnConfirm2
            // 
            this.btnConfirm2.Location = new System.Drawing.Point(408, 217);
            this.btnConfirm2.Name = "btnConfirm2";
            this.btnConfirm2.Size = new System.Drawing.Size(83, 36);
            this.btnConfirm2.TabIndex = 2;
            this.btnConfirm2.Text = "确认";
            this.btnConfirm2.UseVisualStyleBackColor = true;
            this.btnConfirm2.Click += new System.EventHandler(this.btnConfirm2_Click);
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Location = new System.Drawing.Point(271, 139);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(220, 25);
            this.txtDepositAmount.TabIndex = 3;
            // 
            // FrmDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDepositAmount);
            this.Controls.Add(this.btnConfirm2);
            this.Controls.Add(this.btnExit6);
            this.Controls.Add(this.label1);
            this.Name = "FrmDeposit";
            this.Text = "ATM自助终端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit6;
        private System.Windows.Forms.Button btnConfirm2;
        private System.Windows.Forms.TextBox txtDepositAmount;
    }
}