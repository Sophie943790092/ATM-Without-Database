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
    public partial class FrmDeposit : Form
    {
        public FrmDeposit()
        {
            InitializeComponent();
        }

        private void btnExit6_Click(object sender, EventArgs e)
        {
            FrmSelectTransactionItem frmSelectTransactionItem = new FrmSelectTransactionItem();
            frmSelectTransactionItem.Show();
            this.Close();
        }

        private void btnConfirm2_Click(object sender, EventArgs e)
        {
            FrmLogin f1 = new FrmLogin();
            f1.Deposit(txtDepositAmount.Text);
            this.Close();
        }
    }
}
