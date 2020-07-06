using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM自助存取款终端
{
    public partial class FrmSelectTransactionItem : Form
    {
        public FrmSelectTransactionItem()
        {
            InitializeComponent();
        }

        
        private void btnExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();//结束应用程序

        }

        private void btnWithwraw_Click(object sender, EventArgs e)
        {
            FrmWithdraw frmWithdraw = new FrmWithdraw();
            frmWithdraw.Show();
            this.Close();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            FrmShowBalance frmShowBalance = new FrmShowBalance();
            frmShowBalance.Show();
            this.Close();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            FrmDeposit frmDeposit = new FrmDeposit();
            frmDeposit.Show();
            this.Close();

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            FrmTransferAccount frmTransferAccount = new FrmTransferAccount();
            frmTransferAccount.Show();
            this.Close();
        }
    }
}
